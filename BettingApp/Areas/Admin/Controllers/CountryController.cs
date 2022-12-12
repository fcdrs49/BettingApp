using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Country;
using Microsoft.AspNetCore.Authorization;
using static BettingApp.Areas.Admin.AdminConstants;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace BettingApp.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = AdminRoleName)]
    public class CountryController : Controller
    {
        private readonly ICountryService countryService;
        private readonly IMemoryCache cache;

        public CountryController(ICountryService _countryService, IMemoryCache _cache)
        {
            countryService = _countryService;
            cache = _cache;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var countries = await countryService.AllAsync();

            var cacheOptions = new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(TimeSpan.FromMinutes(1440));

            cache.Set(CountriesCacheKey, countries, cacheOptions);

            return View(countries);
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
            cache.Remove(CountriesCacheKey);
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
            cache.Remove(CountriesCacheKey);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await countryService.DeleteAsync(id);
            cache.Remove(CountriesCacheKey);
            return RedirectToAction(nameof(All));
        }
    }
}
