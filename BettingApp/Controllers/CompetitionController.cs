using BettingApp.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BettingApp.Controllers
{
    public class CompetitionController : Controller
    {
        private readonly ICompetitionService competitionService;

        public CompetitionController(ICompetitionService _competitionService)
        {
            competitionService = _competitionService;
        }

        [Route("{controller}/{id}/Standings")]
        public async Task<IActionResult> Standings(int id)
        {
            var model = await competitionService.Standings(id);
            return View(model);
        }
    }
}
