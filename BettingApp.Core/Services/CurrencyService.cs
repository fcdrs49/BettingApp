using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Currency;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.Core.Services
{
	public class CurrencyService : ICurrencyService
	{
		private readonly IRepository repo;

		public CurrencyService(IRepository _repo)
		{
			repo = _repo;
		}

		public async Task<IEnumerable<CurrencyModel>> AllAsync()
		{
			return await repo.AllReadonly<Currency>()
				.Select(c => new CurrencyModel()
				{
					ISOCode = c.ISOCode,
					Description = c.Description,
					ShortDescription = c.ShortDescription,
					ExchangeRate = c.ExchangeRate,
					DateTime = c.DateTime
				})
				.ToListAsync();
		}

		public async Task<CurrencyModel> ByCodeAsync(string ISOCode)
		{
			return await repo.AllReadonly<Currency>()
				.Where(c => c.ISOCode == ISOCode)	
				.Select(c => new CurrencyModel()
				{
					ISOCode = c.ISOCode,
					Description = c.Description,
					ExchangeRate = c.ExchangeRate,
					DateTime = c.DateTime,
					ShortDescription = c.ShortDescription
				})
				.FirstAsync();
		}

		public async Task CreateAsync(CurrencyModel model)
		{
			var currency = new Currency()
			{
				DateTime = DateTime.Now,
				Description = model.Description,
				ExchangeRate = model.ExchangeRate,
				ISOCode = model.ISOCode,
				ShortDescription = model.ShortDescription
			};

			await repo.AddAsync(currency);
			await repo.SaveChangesAsync();
		}

		public async Task DeleteAsync(string ISOCode)
		{
			if(await repo.AllReadonly<Bet>()
				.Where(b => b.CurrencyCode == ISOCode)
				.AnyAsync())
			{
				throw new InvalidOperationException("This currency is used in bets!");
			}

			if(await repo.AllReadonly<Transaction>()
				.Where(t => t.CurrencyCode == ISOCode)
				.AnyAsync())
			{
				throw new InvalidOperationException("This currency is used in transactions!");
			}

			await repo.DeleteAsync<Currency>(ISOCode);
			await repo.SaveChangesAsync();
		}

		public async Task EditAsync(CurrencyModel model)
		{
			var currency = await repo.GetByIdAsync<Currency>(model.ISOCode);

			currency.ISOCode = model.ISOCode;
			currency.ExchangeRate = model.ExchangeRate;
			currency.ShortDescription = model.ShortDescription;
			currency.Description = model.Description;
			currency.DateTime = DateTime.Now;

			repo.Update(currency);
			await repo.SaveChangesAsync();
		}
	}
}
