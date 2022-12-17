using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Currency;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using static BettingApp.Areas.Admin.AdminConstants;

namespace BettingApp.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = AdminRoleName)]
    public class CurrencyController : Controller
    {
        private readonly ICurrencyService currencyService;
        private readonly IMemoryCache cache;

        public CurrencyController(ICurrencyService _currencyService, IMemoryCache _cache)
        {
            currencyService = _currencyService;
            cache = _cache;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var currencies = await currencyService.AllAsync();

            var cacheOptions = new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(TimeSpan.FromMinutes(1440));
             
            cache.Set(CurrenciesCacheKey, currencies, cacheOptions);

            return View(currencies);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string ISOCode)
        {
            return View(await currencyService.ByCodeAsync(ISOCode));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CurrencyModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await currencyService.EditAsync(model);
            cache.Remove(CurrenciesCacheKey);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new CurrencyModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(CurrencyModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await currencyService.CreateAsync(model);
            cache.Remove(CurrenciesCacheKey);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string ISOCode)
        {
            await currencyService.DeleteAsync(ISOCode);
            cache.Remove(CurrenciesCacheKey);
            return RedirectToAction(nameof(All));
        }
    }
}
