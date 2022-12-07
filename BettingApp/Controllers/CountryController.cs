using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Country;
using Microsoft.AspNetCore.Mvc;

namespace BettingApp.Controllers
{
    public class CountryController : Controller
    {
        private readonly ICountryService countryService;

        public CountryController(ICountryService _countryService)
        {
            countryService = _countryService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            return View(await countryService.GetAllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await countryService.GetByIdAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CountryModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await countryService.EditAsync(model);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new CountryModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(CountryModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await countryService.CreateAsync(model);

            return RedirectToAction(nameof(All));
        }
    }
}
