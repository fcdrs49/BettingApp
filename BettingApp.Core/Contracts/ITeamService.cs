using BettingApp.Core.Models.Team;

namespace BettingApp.Core.Contracts
{
	public interface ITeamService
	{
		public Task<TeamViewModel> GetDetailsByIdAsync(int id);
		public Task<TeamFormModel> GetByIdAsync(int id);
		public Task EditAsync(TeamFormModel model);
		public Task AddAsync(TeamFormModel model);
		public Task<IEnumerable<TeamViewModel>> GetAllAsync();
		public Task DeleteAsync(int id);
	}
}
