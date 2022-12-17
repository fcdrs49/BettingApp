using BettingApp.Core.Constants;
using BettingApp.Core.Contracts;
using BettingApp.Core.Exceptions;
using BettingApp.Core.Models.Currency;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.Core.Services
{
	public class CurrencyService : ICurrencyService
	{
		private readonly IRepository repo;
		private readonly IGuard guard;

		public CurrencyService(IRepository _repo, IGuard _guard)
		{
			repo = _repo;
			guard = _guard;
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
			var currency = await repo.AllReadonly<Currency>()
				.Where(c => c.ISOCode == ISOCode)
				.FirstOrDefaultAsync();
            guard.AgainstNull(currency, string.Format(ExceptionMessages.NotFound, nameof(Currency), ISOCode));

			return new CurrencyModel()
			{
				ISOCode = currency.ISOCode,
				Description = currency.Description,
				ExchangeRate = currency.ExchangeRate,
				DateTime = currency.DateTime,
				ShortDescription = currency.ShortDescription
			};
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
			var currency = await ByCodeAsync(ISOCode);
			if(await repo.AllReadonly<Transaction>()
				.Where(t => t.CurrencyCode == ISOCode)
				.AnyAsync())
            {
                throw new InvalidOperationException(
                    string.Format(ExceptionMessages.EntityExistsMessageOnDelete,
                                  nameof(Currency),
                                  currency.Description,
                                  nameof(Transaction)));
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
