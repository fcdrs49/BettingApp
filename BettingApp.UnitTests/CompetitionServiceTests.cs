using BettingApp.Core.Contracts;
using BettingApp.Core.Services;
using BettingApp.Infrastructure.Data;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.UnitTests
{
    [TestFixture]
    public class CompetitionServiceTests
    {
        private IRepository repo { get; set; }
        private ICompetitionService competitionService { get; set; }
        private ITeamService teamService { get; set; }
        private ICountryService countryService { get; set; }
        private IGuard guard { get; set; }
        private BettingAppDbContext bettingAppDbContext { get; set; }

        [SetUp]
        public void SetUp()
        {
            var contextOptions = new DbContextOptionsBuilder<BettingAppDbContext>()
                .UseInMemoryDatabase("BetDb")
                .Options;

            bettingAppDbContext = new BettingAppDbContext(contextOptions);

            bettingAppDbContext.Database.EnsureDeleted();
            bettingAppDbContext.Database.EnsureCreated();
            repo = new Repository(bettingAppDbContext);
            countryService = new CountryService(repo);
            guard = new Guard();
            teamService = new TeamService(repo, countryService, guard);
            competitionService = new CompetitionService(repo, teamService);
        }

        [Test]
        public async Task TestGetAllAsync()
        {
            var competitions = await competitionService.GetAllAsync();

            Assert.IsNotNull(competitions.FirstOrDefault());
            Assert.That(competitions.Count(), Is.EqualTo(10));
            Assert.That(competitions.FirstOrDefault()?.Name, Is.EqualTo("Premier League 2020/2021"));
        }

        [Test]
        public async Task TestGetByIdAsync()
        {
            var competition = new Competition()
            {
                CountryId = 26,
                Description = "First Level Of Bulgarian Football",
                Name = "Parva Liga",
                IsInternational = false,
                ImageUrl = "https://www.flashscore.com/res/image/data/6VTk1W9r-84VqVvfA.png"
            };
            await repo.AddAsync(competition);
            await repo.SaveChangesAsync();
            var competitionToTest = await competitionService.GetByIdAsync(competition.Id);

            Assert.IsNotNull(competitionToTest);
            Assert.That(competitionToTest.Name, Is.EqualTo(competition.Name));
            Assert.That(competitionToTest.ImageUrl, Is.EqualTo(competition.ImageUrl));
            Assert.That(competitionToTest.Id, Is.EqualTo(competition.Id));
        }
    }
}
