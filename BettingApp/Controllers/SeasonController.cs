using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Country;
using BettingApp.Core.Models.Season;
using BettingApp.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace BettingApp.Controllers
{
    public class SeasonController : Controller
    {
        private readonly ISeasonService seasonService;

        public SeasonController(ISeasonService _seasonService)
        {
            seasonService = _seasonService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            return View(await seasonService.GetAllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await seasonService.GetByIdAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SeasonModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await seasonService.EditAsync(model);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new SeasonModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(SeasonModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await seasonService.CreateAsync(model);

            return RedirectToAction(nameof(All));
        }
    }
}
