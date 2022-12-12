using BettingApp.Areas.Admin;
using BettingApp.Areas.Bookmaker;
using BettingApp.Core.Contracts;
using BettingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
            if(User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction("Index", "Home", new { area = AdminConstants.AdminRoleName });
            }
            if(User.IsInRole(BookmakerConstants.BookmakerRoleName))
            {
                return RedirectToAction("All", "Games", new { area = BookmakerConstants.BookmakerRoleName });
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