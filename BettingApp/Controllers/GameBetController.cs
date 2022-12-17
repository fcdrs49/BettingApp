using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Bet;
using BettingApp.Core.Models.GameBet;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Models;
using Humanizer.Bytes;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BettingApp.Controllers
{
    public class GameBetController : Controller
    {
        private readonly IRepository repo;
        private readonly IBetService betService;

        public GameBetController(IRepository _repo, IBetService _betService)
        {
            repo = _repo;
            betService = _betService;
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
        [ValidateAntiForgeryToken]
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(int gameId, string prediction)
        {
            var model = await betService.CreateGameBet(gameId, prediction);
            var bets = await GetBetsFromSessionStorage();
            bets = betService.AddGameBetToCollection(bets, gameId, model, prediction);

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
