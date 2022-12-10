using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Currency;
using Microsoft.AspNetCore.Mvc;

namespace BettingApp.Controllers
{
	public class CurrencyController : Controller
	{
		private readonly ICurrencyService currencyService;

		public CurrencyController(ICurrencyService _currencyService)
		{
			currencyService = _currencyService;
		}


		[HttpGet]
		public async Task<IActionResult> Edit(string ISOCode)
		{
			return View(await currencyService.ByCodeAsync(ISOCode));
		}

		[HttpPost]
		public async Task<IActionResult> Edit(CurrencyModel model)
		{
			if(!ModelState.IsValid)
			{
				return View(model);
			}

			await currencyService.EditAsync(model);

            return RedirectToAction("Currencies", "Admin");
        }

		[HttpGet]
		public IActionResult Add()
		{
			return View(new CurrencyModel());
		}

		[HttpPost]
		public async Task<IActionResult> Add(CurrencyModel model)
		{
			if(!ModelState.IsValid)
			{
				return View(model);
			}

			await currencyService.CreateAsync(model);
            return RedirectToAction("Currencies", "Admin");
        }

		[HttpGet]
		public async Task<IActionResult> Delete(string ISOCode)
		{
			await currencyService.DeleteAsync(ISOCode);

            return RedirectToAction("Currencies", "Admin");
        }
	}
}
