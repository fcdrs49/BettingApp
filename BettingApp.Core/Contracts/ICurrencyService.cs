using BettingApp.Core.Models.Currency;

namespace BettingApp.Core.Contracts
{
	public interface ICurrencyService
	{
		public Task<IEnumerable<CurrencyModel>> AllAsync();
		public Task<CurrencyModel> ByCodeAsync(string ISOCode);
		public Task CreateAsync(CurrencyModel model);
		public Task EditAsync(CurrencyModel model);
		public Task DeleteAsync(string ISOCode);
	}
}
