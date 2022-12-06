using BettingApp.Core.Models.Bet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BettingApp.Controllers
{
    public class GameController : Controller
    {
        public async Task<IActionResult> All()
        {
            var model = new BetsQueryModel();

            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> Mine()
        {
            var model = new BetsQueryModel();

            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var model = new BetDetailsViewModel();

            return View(model);
        }
    }
}
