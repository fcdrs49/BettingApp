using BettingApp.Core.Constants;
using BettingApp.Core.Contracts;
using BettingApp.Core.Exceptions;
using BettingApp.Core.Models.Competition;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.Core.Services
{
	public class CompetitionService : ICompetitionService
    {
        private readonly IRepository repo;
        private readonly ITeamService teamService;
        private readonly IGuard guard;

		public CompetitionService(IRepository _repo, ITeamService _teamService, IGuard _guard)
		{
			repo = _repo;
			teamService = _teamService;
			guard = _guard;
		}

		public async Task<IEnumerable<CompetitionViewModel>> GetAllAsync()
		{
			return await repo.AllReadonly<Competition>()
				.Select(c => new CompetitionViewModel()
				{
					Id = c.Id,
					Name = c.Name,
					ImageUrl = c.ImageUrl
				})
				.ToListAsync();
		}

		public async Task<CompetitionViewModel> GetByIdAsync(int id)
		{
			var competition = await repo.GetByIdAsync<Competition>(id);
            guard.AgainstNull(competition, string.Format(ExceptionMessages.NotFound, nameof(Competition), id));

            return new CompetitionViewModel()
			{
				Id = competition.Id,
				Name = competition.Name,
				ImageUrl = competition.ImageUrl
			};
		}

		public async Task<StandingViewModel> Standings(int competitionId)
		{
			var competition = await repo.GetByIdAsync<Competition>(competitionId);
            guard.AgainstNull(competition, string.Format(ExceptionMessages.NotFound, nameof(Competition), competitionId));
            var model = new StandingViewModel()
			{
				CompetitionId = competitionId,
				Competition = competition.Name,
				Competitions = await GetAllAsync(),
				Teams = await teamService.StandingsByCompetitionId(competitionId)
			};

			return model;
		}
	}
}
