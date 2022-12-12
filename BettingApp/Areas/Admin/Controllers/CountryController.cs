using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Country;
using Microsoft.AspNetCore.Authorization;
using static BettingApp.Areas.Admin.AdminConstants;
using Microsoft.AspNetCore.Mvc;

namespace BettingApp.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = AdminRoleName)]
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
            return View(await countryService.AllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await countryService.ByIdAsync(id);

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

            return RedirectToAction("Countries", "Admin");
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

            return RedirectToAction("Countries", "Admin");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await countryService.DeleteAsync(id);
            return RedirectToAction("Countries", "Admin");
        }
    }
}
