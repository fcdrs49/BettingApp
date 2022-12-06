﻿using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Country;
using BettingApp.Core.Models.Employee;
using BettingApp.Core.Models.Team;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.Core.Services
{
    public class TeamService : ITeamService
    {
        private readonly IRepository repo;
        private readonly ICountryService countryService;


        public TeamService(IRepository _repo, ICountryService _countryService)
        {
            repo = _repo;
            countryService = _countryService;
        }



        public async Task<TeamViewModel> GetDetailsByIdAsync(int id)
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
                            ImageUrl = e.ImageUrl
                        })
                        .ToList()
                })
                .FirstOrDefaultAsync();

            return team;
        }

        public async Task<TeamFormModel> GetByIdAsync(int id)
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

            team.Countries = await countryService.GetAllAsync();

            return team;
        }

        public async Task EditAsync(TeamFormModel model)
        {
            var team = await repo.All<Team>()
                .Where(t => t.Id == model.Id)
                .FirstOrDefaultAsync();

            if(team != null)
            {
                team.Name = model.Name;
                team.CountryId = model.CountryId;
                team.ImageUrl = model.ImageUrl;
                team.CountryId = model.CountryId;
                team.IsInternational = model.IsInternational;

                repo.Update(team);
                await repo.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<TeamViewModel>> GetAllAsync()
        {
            return await repo.AllReadonly<Team>()
                .Select(t => new TeamViewModel()
                {
                    Id = t.Id,
                    Name = t.Name,
                    ImageUrl = t.ImageUrl
                })
                .ToListAsync();
        }
    }
}
