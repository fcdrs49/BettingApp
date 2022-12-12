using BettingApp.Core.Contracts;
using BettingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static BettingApp.Areas.Admin.AdminConstants;

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
            if(User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }
            var model = await gameService.NextTenGames();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}