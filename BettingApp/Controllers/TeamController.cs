using BettingApp.Core.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BettingApp.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService teamService;
        private readonly IGameService gameService;

        public TeamController(ITeamService _teamService, IGameService _gameService)
        {
            teamService = _teamService;
            gameService = _gameService;
        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var model = await teamService.DetailsByIdAsync(id);
            model.Games = await gameService.NextNGames(5, id);

            return View(model);
        }
    }
}
