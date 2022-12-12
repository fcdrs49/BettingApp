using BettingApp.Core.Models.Team;

namespace BettingApp.Core.Contracts
{
	public interface ITeamService
	{
		public Task<TeamViewModel> DetailsByIdAsync(int id);
		public Task<TeamFormModel> ByIdAsync(int id);
		public Task EditAsync(TeamFormModel model);
		public Task AddAsync(TeamFormModel model);
		public Task<IEnumerable<TeamViewModel>> AllAsync();
		public Task DeleteAsync(int id);
	}
}
