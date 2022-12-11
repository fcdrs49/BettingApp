using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Bet;
using BettingApp.Core.Models.GameBet;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BettingApp.Controllers
{
    public class GameBetController : Controller
    {
        private readonly IRepository repo;

        public GameBetController(IRepository _repo)
        {
            repo = _repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var bets = await GetBetsFromSessionStorage();
            var model = new BetQueryModel()
            {
                GameBets = bets
            };
            return PartialView("_GameBetsPartialData", model);
        }

        [HttpDelete]
        public async Task<IActionResult> Remove(int gameId)
        {
            var bets = await GetBetsFromSessionStorage();
            var betToRemove = bets.FirstOrDefault(b => b.GameId == gameId);
            if(betToRemove != null)
            {
                bets.Remove(betToRemove);
            }
            SetGameBetsToSessionStorage(bets);
            var model = new BetQueryModel
            {
                GameBets = bets
            };
            return PartialView("_GameBetsPartialData", model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(int gameId, string prediction)
        {
            var game = await repo.GetByIdAsync<Game>(gameId);
            var homeTeam = await repo.GetByIdAsync<Team>(game.HomeTeamId);
            var awayTeam = await repo.GetByIdAsync<Team>(game.AwayTeamId);
            decimal betRate = 1;
            switch(prediction)
            {
                case "1": betRate = game.HomeRate;break;
                case "X": betRate = game.DrawRate;break;
                case "2": betRate = game.AwayRate;break;
            }
            var model = new GameBetViewModel()
            {
                GameId = game.Id,
                HomeTeam = homeTeam.Name,
                AwayTeam = awayTeam.Name,
                BetRate = betRate,
                Prediction = prediction
            };
            var bets = await GetBetsFromSessionStorage();
            if (bets.Any(b => b.GameId == gameId))
            {
                var bet = bets.First(b => b.GameId == gameId);
                bet.Prediction = prediction;
                bet.BetRate = betRate;
            }
            else
            {
                bets.Add(model);
            }

            SetGameBetsToSessionStorage(bets);

            var betModel = new BetQueryModel()
            {
                GameBets = bets
            };
            return PartialView("_GameBetsPartialData", betModel);
        }

        [HttpGet]
        public string GetBetsFromSessionStorageRaw()
        {
            return HttpContext.Session.GetString("GameBets") ?? "";
        }

        public async Task<List<GameBetViewModel>> GetBetsFromSessionStorage()
        {
            string? gameBetsString = HttpContext.Session.GetString("GameBets");
            var gameBets = new List<GameBetViewModel>();
            if (gameBetsString != null)
            {
                gameBets = JsonSerializer.Deserialize<List<GameBetViewModel>>(gameBetsString)
                    ?? new List<GameBetViewModel>();
            }
            foreach (var gameBet in gameBets)
            {
                var game = await repo.GetByIdAsync<Game>(gameBet.GameId);
                if (game.DateTime < DateTime.Now)
                {
                    gameBets.Remove(gameBet);
                }
            }
            return gameBets;
        }
        public void SetGameBetsToSessionStorage(List<GameBetViewModel> bets)
        {
            HttpContext.Session.SetString("GameBets", JsonSerializer.Serialize(bets));
        }

    }
}
