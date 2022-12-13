using BettingApp.Core.Models.Competition;

namespace BettingApp.Core.Contracts
{
    public interface ICompetitionService
    {
        public Task<CompetitionViewModel> GetByIdAsync(int id);
        public Task<IEnumerable<CompetitionViewModel>> GetAllAsync();
        public Task<StandingViewModel> Standings(int competitionId);
    }
}
