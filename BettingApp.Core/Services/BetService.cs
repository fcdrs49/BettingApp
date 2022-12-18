using BettingApp.Core.Constants;
using BettingApp.Core.Contracts;
using BettingApp.Core.Exceptions;
using BettingApp.Core.Models.Bet;
using BettingApp.Core.Models.Game;
using BettingApp.Core.Models.GameBet;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Enums;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.Core.Services
{
    public class BetService : IBetService
    {
        private readonly IRepository repo;
        private readonly IGuard guard;

        public BetService(IRepository _repo, IGuard _guard)
        {
            repo = _repo;
            guard = _guard;
        }

        public async Task CreateBetAsync(BetQueryModel model, string userId)
        {
            if(model.GameBets.Count < 1)
            {
                throw new InvalidOperationException("No games selected for bet!");
            }

            var bet = new Bet()
            {
                UserId = userId,
                Amount = Math.Round(model.Amount, 2),
                CurrencyCode = "BGN",
                DateTime = DateTime.Now
            };
            await repo.AddAsync(bet);
            await repo.SaveChangesAsync();

            foreach (var gb in model.GameBets)
            {
                ScoreSign sign = ScoreSign.Draw;

                switch(gb.Prediction)
                {
                    case "1": sign = ScoreSign.Home; break;
                    case "2": sign = ScoreSign.Away; break;
                    case "X": sign = ScoreSign.Draw; break;
                }
                var gameBet = new GameBet()
                {
                    BetId = bet.Id,
                    BetRate = Math.Round(gb.BetRate, 2),
                    GameId = gb.GameId,
                    Prediction = sign
                };

                await repo.AddAsync(gameBet);
                await repo.SaveChangesAsync();
            }
        }

        public decimal GetBetsAmount(string userId)
        {
            return Math.Round(repo.AllReadonly<Bet>()
                .Where(b => b.UserId == userId)
                .Sum(b => b.WinAmount - b.Amount),2);
        }

        public async Task<IEnumerable<BetViewModel>> GetUserBets(string userId)
        {
            var bets = await repo.AllReadonly<Bet>()
                .Where(b => b.UserId == userId)
                .Select(b => new BetViewModel()
                {
                    Id = b.Id,
                    Amount = Math.Round(b.Amount, 2),
                    //CurrencyCode = b.CurrencyCode,
                    CurrencyCode = "BGN",
                    DateTime = b.DateTime,
                    Closed = b.Closed,
                    WinAmount = Math.Round(b.WinAmount, 2)
                })
                .ToListAsync();

            foreach (var bet in bets)
            {
                var gameBets = await repo.AllReadonly<GameBet>()
                    .Where(gb => gb.BetId == bet.Id)
                    .Include(gb => gb.Game)
                    .ToListAsync();
                bet.GamesCount = gameBets.Count;
                var betRates = gameBets.Select(gb => gb.BetRate).ToList();
                bet.BetRate = Math.Round(betRates.Aggregate((a, b) => a * b),2);
                bet.Won = await IsBetWon(bet.Id);
                bet.CanBeClosed = !bet.Closed &&
                    !gameBets.Any(gb => gb.Game.Finished == true) &&
                    !gameBets.Any(gb => gb.Game.DateTime < DateTime.Now);
            }

            return bets;
        }

        public async Task<IEnumerable<GameBetViewModel>> GetGameBets(int betId)
        {
            var bet = await repo.GetByIdAsync<Bet>(betId);
            guard.AgainstNull(bet, string.Format(ExceptionMessages.NotFound, nameof(Bet), betId));
            return await repo.AllReadonly<GameBet>()
                .Where(gb => gb.BetId == betId)
                .Include(gb => gb.Game)
                .ThenInclude(g => g.HomeTeam)
                .Include(gb => gb.Game)
                .ThenInclude(g => g.AwayTeam)
                .Select(b => new GameBetViewModel()
                {
                    GameId = b.GameId,
                    HomeTeam = b.Game.HomeTeam.Name,
                    AwayTeam = b.Game.AwayTeam.Name,
                    BetRate = Math.Round(b.BetRate,2),
                    Prediction = b.Prediction.ToString(),
                    Won = b.Won ? "✔️" : 
                          b.Game.Finished ? "❌" : ""
                })
                .ToListAsync();
        }

        public async Task UpdateBetsWhenGameFinished(GameFormModel game)
        {
            var lostBets = await repo.AllReadonly<GameBet>()
                .Where(gb => gb.GameId == game.Id &&
                       gb.Prediction != game.ScoreSign)
                .ToListAsync();
            foreach (var lostBet in lostBets)
            {
                lostBet.Won = false;
                repo.Update(lostBet);
                var bet = await repo.GetByIdAsync<Bet>(lostBet.BetId);
                if (!bet.Closed && !bet.Cancelled)
                {
                    bet.Closed = true;
                    repo.Update(bet);
                }
            }

            var wonBets = await repo.AllReadonly<GameBet>()
                .Where(gb => gb.GameId == game.Id &&
                        gb.Prediction == game.ScoreSign)
                .ToListAsync();
            foreach (var wonBet in wonBets)
            {
                wonBet.Won = true;
                repo.Update(wonBet);
                var gameBets = await repo.AllReadonly<GameBet>()
                    .Where(b => b.BetId == wonBet.BetId &&
                           b.GameId != wonBet.GameId)
                    .ToListAsync();

                if (!gameBets.Any(g => g.Won == false))
                {
                    var betRate = wonBet.BetRate;
                    if (gameBets.Count > 0)
                    {
                        betRate = gameBets.Select(gb => gb.BetRate).Aggregate((a, b) => a * b) * wonBet.BetRate;
                    }
                    var bet = await repo.GetByIdAsync<Bet>(wonBet.BetId);
                    if (!bet.Cancelled)
                    {
                        bet.Won = true;
                        bet.Closed = true;
                        bet.WinAmount = Math.Round(betRate * bet.Amount,2);
                        repo.Update(bet);
                    }
                }
            }
            await repo.SaveChangesAsync();
        }

        public async Task UpdateBetsWhenGameCorrected(GameFormModel game)
        {
            var gameBets = await repo.AllReadonly<GameBet>()
                .Where(gb => gb.GameId == game.Id)
                .ToListAsync();

            foreach (var gameBet in gameBets)
            {
                gameBet.Won = false;
                repo.Update(gameBet);
                var bet = await repo.GetByIdAsync<Bet>(gameBet.BetId);
                if(!bet.Cancelled && bet.Closed)
                {
                    bet.Won = false;
                    bet.Closed = false;
                    bet.WinAmount = 0;
                    repo.Update(bet);
                }
            }

            await repo.SaveChangesAsync();
        }

        private async Task<string> IsBetWon(int betId)
        {
            var bet = await repo.GetByIdAsync<Bet>(betId);
            guard.AgainstNull(bet, string.Format(ExceptionMessages.NotFound, nameof(Bet), betId));
            var gameBets = await repo.AllReadonly<GameBet>()
                .Include(gb => gb.Game)
                .Where(gb => gb.BetId == bet.Id)
                .ToListAsync();
            if(gameBets.All(gb => gb.Won == true) || bet.Cancelled)
            {
                return "✔️";
            }

            if(gameBets.Any(gb => gb.Won == false && gb.Game.Finished == true))
            {
                return "❌";
            }

                return "";
        }

        public async Task CancelBet(int betId)
        {
            var bet = await repo.GetByIdAsync<Bet>(betId);
            guard.AgainstNull(bet, string.Format(ExceptionMessages.NotFound, nameof(Bet), betId));
            bet.Cancelled = true;
            bet.Closed = true;
            bet.Won = true;
            bet.WinAmount = Math.Round(bet.Amount,2);
            repo.Update(bet);
            await repo.SaveChangesAsync();
        }

        public async Task<GameBetViewModel> CreateGameBet(int gameId, string prediction)
        {
            var game = await repo.GetByIdAsync<Game>(gameId);
            var homeTeam = await repo.GetByIdAsync<Team>(game.HomeTeamId);
            var awayTeam = await repo.GetByIdAsync<Team>(game.AwayTeamId);
            decimal betRate = 1;
            switch (prediction)
            {
                case "1": betRate = game.HomeRate; break;
                case "X": betRate = game.DrawRate; break;
                case "2": betRate = game.AwayRate; break;
            }
            var model = new GameBetViewModel()
            {
                GameId = game.Id,
                HomeTeam = homeTeam.Name,
                AwayTeam = awayTeam.Name,
                BetRate = Math.Round(betRate,2),
                Prediction = prediction
            };
            return model;
        }

        public List<GameBetViewModel> AddGameBetToCollection(List<GameBetViewModel> bets, GameBetViewModel model)
        {
            if (bets.Any(b => b.GameId == model.GameId))
            {
                var bet = bets.First(b => b.GameId == model.GameId);
                bet.Prediction = model.Prediction;
                bet.BetRate = model.BetRate;
            }
            else
            {
                bets.Add(model);
            }

            return bets;
        }
    }
}
