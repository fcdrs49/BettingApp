using BettingApp.Core.Models.Season;

namespace BettingApp.Core.Contracts
{
    public interface ISeasonService
    {
        public Task<SeasonModel> GetByIdAsync(int id);
        public Task EditAsync(SeasonModel model);
        public Task<IEnumerable<SeasonModel>> GetAllAsync();
        public Task CreateAsync(SeasonModel model);
    }
}
