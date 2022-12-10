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
        public IActionResult GetAll()
        {
            return PartialView("_GameBetsPartialData", GetBetsFromSessionStorage());
        }

        [HttpDelete]
        public IActionResult Remove(int gameId)
        {
            var bets = GetBetsFromSessionStorage();
            var betToRemove = bets.FirstOrDefault(b => b.GameId == gameId);
            if(betToRemove != null)
            {
                bets.Remove(betToRemove);
            }
            SetGameBetsToSessionStorage(bets);
            return PartialView("_GameBetsPartialData", bets);
        }

        [HttpPost]
        public async Task<IActionResult> Add(int gameId, string prediction, decimal betRate)
        {
            var game = await repo.GetByIdAsync<Game>(gameId);
            var model = new GameBetViewModel()
            {
                GameId = game.Id,
                HomeTeam = game.HomeTeam.Name,
                AwayTeam = game.AwayTeam.Name,
                BetRate = betRate,
                Prediction = prediction
            };
            var bets = GetBetsFromSessionStorage();
            bets.Add(model);

            return PartialView("_GameBetsPartialData", bets);
        }

        private List<GameBetViewModel> GetBetsFromSessionStorage()
        {
            string? gameBetsString = HttpContext.Session.GetString("GameBets");
            var gameBets = new List<GameBetViewModel>();
            if (gameBetsString != null)
            {
                gameBets = JsonSerializer.Deserialize<List<GameBetViewModel>>(gameBetsString)
                    ?? new List<GameBetViewModel>();
            }
            return gameBets;
        }

        private void SetGameBetsToSessionStorage(List<GameBetViewModel> bets)
        {
            HttpContext.Session.SetString("GameBets", JsonSerializer.Serialize(bets));
        }
    }
}
