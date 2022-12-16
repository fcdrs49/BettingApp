using BettingApp.Core.Constants;
using BettingApp.Core.Contracts;
using BettingApp.Core.Exceptions;
using BettingApp.Core.Models.Employee;
using BettingApp.Core.Models.Team;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Enums;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.Core.Services
{
    public class TeamService : ITeamService
    {
        private readonly IRepository repo;
        private readonly ICountryService countryService;
        private readonly IGuard guard;

        public TeamService(IRepository _repo, ICountryService _countryService, IGuard _guard)
        {
            repo = _repo;
            countryService = _countryService;
            guard = _guard;
        }

        public async Task<TeamViewModel> DetailsByIdAsync(int id)
        {
            var team = await repo.AllReadonly<Team>()
                .Where(t => t.Id == id)
                .Include(t => t.Employees)
                .Select(t => new TeamViewModel
                {
                    Id = t.Id,
                    Name = t.Name,
                    Country = t.Country.Name,
                    ImageUrl = t.ImageUrl,
                    Employees = t.Employees
                        .Select(e => new EmployeeViewModel()
                        {
                            FirstName = e.FirstName,
                            LastName = e.LastName,
                            Country = e.Country.Name,
                            ImageUrl = e.ImageUrl,
                            Position = e.EmployeeType.ToString()
                        })
                        .ToList()
                })
                .FirstOrDefaultAsync();

            guard.AgainstNull(team, string.Format(ExceptionMessages.NotFound, nameof(Team), id));
            return team;
        }

        public async Task<TeamFormModel> ByIdAsync(int id)
        {
            var team = await repo.All<Team>()
                .Where(t => t.Id == id)
                .Select(t => new TeamFormModel
                {
                    Id = t.Id,
                    Name = t.Name,
                    CountryId = t.CountryId,
                    ImageUrl = t.ImageUrl
                })
                .FirstOrDefaultAsync();
            guard.AgainstNull(team, string.Format(ExceptionMessages.NotFound, nameof(Team), id));
            team.Countries = await countryService.AllAsync();

            return team;
        }

        public async Task EditAsync(TeamFormModel model)
        {
            var team = await repo.GetByIdAsync<Team>(model.Id);
            guard.AgainstNull(team, string.Format(ExceptionMessages.NotFound, nameof(Team), model.Id));

            team.Name = model.Name;
            team.CountryId = model.CountryId;
            team.ImageUrl = model.ImageUrl;
            team.CountryId = model.CountryId;
            team.IsInternational = model.IsInternational;

            repo.Update(team);
            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<TeamViewModel>> AllAsync()
        {
            return await repo.AllReadonly<Team>()
                .Select(t => new TeamViewModel()
                {
                    Id = t.Id,
                    Name = t.Name,
                    ImageUrl = t.ImageUrl,
                    Country = t.Country.Name
                })
                .ToListAsync();
        }

        public async Task AddAsync(TeamFormModel model)
        {
            var team = new Team()
            {
                CountryId = model.CountryId,
                Id = model.Id,
                ImageUrl = model.ImageUrl,
                IsInternational = model.IsInternational,
                Name = model.Name
            };

            await repo.AddAsync(team);
            await repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var team = await ByIdAsync(id);

            if(await repo.AllReadonly<Game>()
                .AnyAsync(g => g.HomeTeamId == id || g.AwayTeamId == id))
            {
                throw new InvalidOperationException(
                    string.Format(ExceptionMessages.EntityExistsMessageOnDelete,
                                  nameof(Team),
                                  team.Name,
                                  nameof(Game)));
            }

            await repo.DeleteAsync<Team>(id);
            await repo.SaveChangesAsync();
        }

        public async Task<List<TeamStandingModel>> StandingsByCompetitionId(int competitionId)
        {
            var games = await repo.AllReadonly<Game>()
                .Where(g => g.CompetitionId == competitionId && g.Finished == true)
                .ToListAsync();

            var teams = games.Select(g => g.HomeTeamId).Distinct().ToList();
            teams.AddRange(games.Select(g => g.AwayTeamId).Distinct().ToList());
            teams = teams.Distinct().ToList();

            List<TeamStandingModel> model = new List<TeamStandingModel>();

            foreach (var teamId in teams)
            {
                var team = await repo.GetByIdAsync<Team>(teamId);
                var wins = games
                    .Where(g => g.HomeTeamId == teamId && g.Sign == ScoreSign.Home)
                    .Count();
                wins += games
                    .Where(g => g.AwayTeamId == teamId && g.Sign == ScoreSign.Away)
                    .Count();
                var draws = games
                    .Where(g => (g.HomeTeamId == teamId ||
                                g.AwayTeamId == teamId) &&
                                g.Sign == ScoreSign.Draw)
                    .Count();
                var gamesTotal = games
                    .Where(g => g.HomeTeamId == teamId || g.AwayTeamId == teamId)
                    .Count();
                var goalsFor = games
                    .Where(g => g.HomeTeamId == teamId)
                    .Sum(g => g.HomeTeamGoals);
                goalsFor += games
                    .Where(g => g.AwayTeamId == teamId)
                    .Sum(g => g.AwayTeamGoals);
                var goalsAgainst = games
                    .Where(g => g.HomeTeamId == teamId)
                    .Sum(g => g.AwayTeamGoals);
                goalsAgainst += games
                    .Where(g => g.AwayTeamId == teamId)
                    .Sum(g => g.HomeTeamGoals);

                model.Add(new TeamStandingModel()
                {
                    Id = teamId,
                    Name = team.Name,
                    Wins = wins,
                    Draws = draws,
                    Losses = gamesTotal - wins - draws,
                    GoalsFor = goalsFor,
                    GoalsAgainst = goalsAgainst,
                    Matches = gamesTotal,
                    Points = (wins * 3) + draws,
                    ImageUrl = team.ImageUrl
                });
            }

            model = model
                .OrderByDescending(m => m.Points)
                .ThenByDescending(m => m.GoalsFor - m.GoalsAgainst)
                .ThenByDescending(m => m.GoalsFor)
                .ThenByDescending(m => m.Name)
                .ToList();
            return model;
        }
    }
}
