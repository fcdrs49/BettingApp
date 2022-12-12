namespace BettingApp.UnitTests
{
    [TestFixture]
    public class TeamServiceTests
    {
        private IRepository repo { get; set; }
        private ITeamService teamService { get; set; }
        private ICountryService countryService { get; set; }
        private IGuard guard { get; set; }
        private BettingAppDbContext bettingAppDbContext { get; set; }

        [SetUp]
        public void SetUp()
        {
            guard = new Guard();
            var contextOptions = new DbContextOptionsBuilder<BettingAppDbContext>()
                .UseInMemoryDatabase("BetDb")
                .Options;

            bettingAppDbContext = new BettingAppDbContext(contextOptions);

            bettingAppDbContext.Database.EnsureDeleted();
            bettingAppDbContext.Database.EnsureCreated();
            repo = new Repository(bettingAppDbContext);
            countryService = new CountryService(repo);
            teamService = new TeamService(repo, countryService, guard);
        }

        [Test]
        public async Task TestDetailsByIdAsync()
        {
            Assert.ThrowsAsync<BettingAppException>(async () => await teamService.DetailsByIdAsync(9999));

            var actualModel = await teamService.DetailsByIdAsync(1);

            var expectedModel = new TeamViewModel()
            {
                Id = 1,
                Name = "Arsenal",
                Country = "United Kingdom"
            };

            Assert.Multiple(() =>
            {
                Assert.That(actualModel, Is.Not.Null);
                Assert.That(actualModel.Id, Is.EqualTo(expectedModel.Id));
                Assert.That(actualModel.Name, Is.EqualTo(expectedModel.Name));
                Assert.That(actualModel.Country, Is.EqualTo(expectedModel.Country));
            });
        }

        [Test]
        public async Task TestByIdAsync()
        {
            Assert.ThrowsAsync<BettingAppException>(async () => await teamService.DetailsByIdAsync(9999));

            var actualModel = await teamService.ByIdAsync(1);

            var expectedModel = new TeamFormModel()
            {
                Id = 1,
                Name = "Arsenal",
            };

            Assert.Multiple(() =>
            {
                Assert.That(actualModel.Id, Is.EqualTo(expectedModel.Id));
                Assert.That(actualModel.Name, Is.EqualTo(expectedModel.Name));
                Assert.That(actualModel.Countries.Count(), Is.AtLeast(1));
            });
        }

        [Test]
        public async Task TestEditAsync()
        {
            var team = await repo.GetByIdAsync<Team>(1);

            var model = new TeamFormModel()
            {
                Id = team.Id,
                CountryId = team.CountryId,
                ImageUrl = team.ImageUrl,
                IsInternational = true,
                Name = "testName"
            };
            await teamService.EditAsync(model);

            var actualTeam = await repo.GetByIdAsync<Team>(model.Id);
            Assert.Multiple(() =>
            {
                Assert.That(actualTeam.Id, Is.EqualTo(1));
                Assert.That(actualTeam.Name, Is.EqualTo("testName"));
                Assert.That(actualTeam.IsInternational, Is.EqualTo(true));
            });
        }

        [Test]
        public async Task TestAllAsync()
        {
            var model = await teamService.AllAsync();

            Assert.That(model.Count(), Is.AtLeast(1));
        }

        [Test]
        public async Task TestAddAsync()
        {
            var model = new TeamFormModel()
            {
                CountryId = 1,
                ImageUrl = "",
                IsInternational = false,
                Name = "testTeam"
            };

            await teamService.AddAsync(model);

            var team = await repo.AllReadonly<Team>()
                .Where(t => t.Name == "testTeam")
                .FirstOrDefaultAsync();

            Assert.That(team, Is.Not.Null);
            Assert.That(team.CountryId, Is.EqualTo(1));
        }

        [Test]
        public async Task TestDeleteAsync()
        {
            Assert.ThrowsAsync<InvalidOperationException>(async() => await teamService.DeleteAsync(1));

            var team = new Team()
            {
                CountryId = 1,
                ImageUrl = "",
                Name = "test",
                IsInternational = false
            };
            await repo.AddAsync(team);
            await repo.SaveChangesAsync();
            var id = team.Id;
            await teamService.DeleteAsync(id);

            team = await repo.GetByIdAsync<Team>(id);
            Assert.That(team, Is.Null);
        }
    }
}
