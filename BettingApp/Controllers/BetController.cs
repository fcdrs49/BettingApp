using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Bet;
using BettingApp.Core.Models.GameBet;
using BettingApp.Extensions;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BettingApp.Controllers
{
    [Authorize]
    public class BetController : Controller
    {
        public readonly IUserService userService;
        public readonly IBetService betService;
        public readonly IRepository repo;

        public BetController(IUserService _userService, IBetService _betService, IRepository _repo)
        {
            userService = _userService;
            betService = _betService;
            repo = _repo;
        }

        [HttpPost]
        public async Task<IActionResult> PlaceBet(BetQueryModel model)
        {
            var balance = userService.GetBalance(User.Id());
            if (!ModelState.IsValid || model.Amount > balance)
            {
                TempData["ErrorMessage"] = "Invalid Amount!";

                return RedirectToAction("Index", "Home");
            }

            model.GameBets = await GetBetsFromSessionStorage();

            await betService.CreateBetAsync(model, User.Id());

            ClearBetsFromSessionStorage();

            return RedirectToAction("UserBets", "User");
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

        public void ClearBetsFromSessionStorage()
        {
            HttpContext.Session.Remove("GameBets");
        }

        [HttpGet]
        public async Task<ActionResult> GetBetDetails(int betId)
        {
            return PartialView("_BetDetailsPartial", await betService.GetGameBets(betId));
        }

        [HttpPost]
        public async Task<IActionResult> Cancel(int id)
        {
            await betService.CancelBet(id);

            return RedirectToAction("UserBets", "User");
        }
    }
}
