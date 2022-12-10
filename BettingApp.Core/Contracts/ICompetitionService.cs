using BettingApp.Core.Models.Competition;
using System.Collections.Generic;

namespace BettingApp.Core.Contracts
{
	public interface ICompetitionService
    {
        public Task<CompetitionViewModel> GetByIdAsync(int id);
        public Task<IEnumerable<CompetitionViewModel>> GetAllAsync();
    }
}
