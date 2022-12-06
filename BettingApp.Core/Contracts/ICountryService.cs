using BettingApp.Core.Models.Country;

namespace BettingApp.Core.Contracts
{
    public interface ICountryService
    {
        public Task<IEnumerable<CountryModel>> GetAllAsync();
    }
}
