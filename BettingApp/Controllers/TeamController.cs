using BettingApp.Core.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BettingApp.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService teamService;

        public TeamController(ITeamService _teamService)
        {
            teamService = _teamService;
        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var model = await teamService.DetailsByIdAsync(id);

            return View(model);
        }
    }
}
