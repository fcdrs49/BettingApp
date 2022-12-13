using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Bet;
using BettingApp.Core.Models.Game;
using BettingApp.Core.Models.GameBet;
using BettingApp.Infrastructure.Data;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Enums;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace BettingApp.Core.Services
{
    public class BetService : IBetService
    {
        private readonly IRepository repo;

        public BetService(IRepository _repo)
        {
            repo = _repo;
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
                Amount = model.Amount,
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
                    BetRate = gb.BetRate,
                    GameId = gb.GameId,
                    Prediction = sign
                };

                await repo.AddAsync(gameBet);
                await repo.SaveChangesAsync();
            }
        }

        public decimal GetBetsAmount(string userId)
        {
            return repo.AllReadonly<Bet>()
                .Where(b => b.UserId == userId)
                .Sum(b => b.WinAmount - b.Amount);
        }

        public async Task<IEnumerable<BetViewModel>> GetUserBets(string userId)
        {
            var bets = await repo.AllReadonly<Bet>()
                .Where(b => b.UserId == userId)
                .Select(b => new BetViewModel()
                {
                    Id = b.Id,
                    Amount = b.Amount,
                    //CurrencyCode = b.CurrencyCode,
                    CurrencyCode = "BGN",
                    DateTime = b.DateTime,
                    Closed = b.Closed,
                    WinAmount = b.WinAmount
                })
                .ToListAsync();

            foreach (var bet in bets)
            {
                var gameBets = await repo.AllReadonly<GameBet>()
                    .Where(gb => gb.BetId == bet.Id)
                    .ToListAsync();
                bet.GamesCount = gameBets.Count;
                var betRates = gameBets.Select(gb => gb.BetRate).ToList();
                bet.BetRate = betRates.Aggregate((a, b) => a * b);
            }

            return bets;
        }

        public async Task<IEnumerable<GameBetViewModel>> GetGameBets(int betId)
        {
            var bet = await repo.GetByIdAsync<Bet>(betId);
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
                    BetRate = b.BetRate,
                    Prediction = b.Prediction.ToString()
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
                var bet = await repo.GetByIdAsync<Bet>(lostBet.BetId);
                if (!bet.Closed && !bet.Cancelled)
                {
                    bet.Closed = true;
                }
            }

            var wonBets = await repo.AllReadonly<GameBet>()
                .Where(gb => gb.GameId == game.Id &&
                        gb.Prediction == game.ScoreSign)
                .ToListAsync();
            foreach (var wonBet in wonBets)
            {
                wonBet.Won = true;
                var gameBets = await repo.AllReadonly<GameBet>()
                    .Where(b => b.BetId == wonBet.BetId &&
                           b.GameId != wonBet.GameId)
                    .ToListAsync();

                if (!gameBets.Any(g => g.Won == false))
                {
                    var betRate = gameBets.Select(gb => gb.BetRate).Aggregate((a, b) => a * b) * wonBet.BetRate;
                    var bet = await repo.GetByIdAsync<Bet>(wonBet.BetId);
                    if (!bet.Cancelled)
                    {
                        bet.Won = true;
                        bet.Closed = true;
                        bet.WinAmount = betRate * bet.Amount;
                    }
                }
            }

            await repo.SaveChangesAsync();
        }

        public async Task UpdateBetsWhenGameCorrected(GameFormModel game)
        {
            var gameBets = await repo.AllReadonly<GameBet>()
                .Where(gb => gb.BetId == game.Id)
                .ToListAsync();

            foreach (var gameBet in gameBets)
            {
                gameBet.Won = false;
                var bet = await repo.GetByIdAsync<Bet>(gameBet.BetId);
                if(!bet.Cancelled && bet.Closed)
                {
                    bet.Won = false;
                    bet.Closed = false;
                }
            }

            await repo.SaveChangesAsync();
        }
    }
}
