using BettingApp.Core.Models.Bet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BettingApp.Controllers
{
    [Authorize]
    public class BetController : Controller
    {
        public async Task<IActionResult> All()
        {
            var model = new BetsQueryModel();

            return View(model);
        }

        public async Task<IActionResult> Mine()
        {
            var model = new BetsQueryModel();

            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> User(int userId)
        {
            var model = new BetsQueryModel();

            return View(model);
        }
    }
}
