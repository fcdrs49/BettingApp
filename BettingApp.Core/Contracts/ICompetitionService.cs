using BettingApp.Core.Models.Competition;

namespace BettingApp.Core.Contracts
{
	public interface ICompetitionService
    {
        public Task<CompetitionViewModel> GetByIdAsync(int id);
    }
}
