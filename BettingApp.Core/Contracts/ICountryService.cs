using BettingApp.Core.Models.Country;

namespace BettingApp.Core.Contracts
{
    public interface ICountryService
    {
        public Task<IEnumerable<CountryModel>> AllAsync();
        public Task<CountryModel> ByIdAsync(int id);
        public Task EditAsync(CountryModel model);
        public Task CreateAsync(CountryModel model);
        public Task DeleteAsync(int id);
    }
}