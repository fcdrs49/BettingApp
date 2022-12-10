using BettingApp.Core.Contracts;
using BettingApp.Core.Models.GameBet;
using BettingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace BettingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGameService gameService;

        public HomeController(IGameService _gameService)
        {
            gameService = _gameService;
        }

        public async Task<IActionResult> Index()
        {   
            var model = await gameService.NextTenGames();

            HttpContext.Session.Remove("GameBets");
            List<GameBetViewModel> gameBets = new List<GameBetViewModel>();
            foreach (var game in model)
            {
                gameBets.Add(new GameBetViewModel()
                {
                    GameId = game.Id,
                    HomeTeam = game.HomeTeam.Name,
                    AwayTeam = game.AwayTeam.Name,
                    BetRate = game.HomeRate,
                    Prediction = "1"
                });
            }
            HttpContext.Session.SetString("GameBets", JsonSerializer.Serialize(gameBets));

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}