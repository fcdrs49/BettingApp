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
            guard = new Guard();
            countryService = new CountryService(repo, guard);
            teamService = new TeamService(repo, countryService, guard);
            competitionService = new CompetitionService(repo, teamService, guard);
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

        [Test]
        public async Task TestStandings()
        {
            var country = await repo.AllReadonly<Country>()
                .Where(c => c.Name == "Bulgaria")
                .FirstAsync();

            var competition = new Competition()
            {
                CountryId = country.Id,
                Description = "test competition 2022",
                Name = "test competition"
            };

            await repo.AddAsync(competition);
            await repo.SaveChangesAsync();

            var games = new List<Game>();

            var teams = await repo.AllReadonly<Team>()
                .Where(t => t.CountryId == country.Id)
                .Take(4)
                .ToArrayAsync();

            games.Add(createGame(teams[0].Id, teams[1].Id, 0, 2, competition.Id));
            games.Add(createGame(teams[0].Id, teams[2].Id, 0, 1, competition.Id));
            games.Add(createGame(teams[0].Id, teams[3].Id, 0, 1, competition.Id));
            games.Add(createGame(teams[1].Id, teams[2].Id, 1, 3, competition.Id));
            games.Add(createGame(teams[1].Id, teams[3].Id, 2, 2, competition.Id));
            games.Add(createGame(teams[2].Id, teams[3].Id, 2, 0, competition.Id));

            await repo.AddRangeAsync(games);
            await repo.SaveChangesAsync();

            var standingViewModel = await competitionService.Standings(competition.Id);
            var competitions = await competitionService.GetAllAsync();

            Assert.Multiple(() =>
            {
                Assert.That(standingViewModel.Teams.Count(), Is.EqualTo(4));
                Assert.That(standingViewModel.Competitions.Count(), Is.EqualTo(competitions.Count()));
                Assert.That(standingViewModel.Teams.Count, Is.EqualTo(4));
                Assert.That(standingViewModel.Teams.First().Wins, Is.EqualTo(3));
                Assert.That(standingViewModel.Teams.First().Draws, Is.EqualTo(0));
                Assert.That(standingViewModel.Teams.First().Losses, Is.EqualTo(0));
                Assert.That(standingViewModel.Teams.First().Points, Is.EqualTo(9));
                Assert.That(standingViewModel.Teams.First().GoalsFor, Is.EqualTo(6));
                Assert.That(standingViewModel.Teams.First().GoalsAgainst, Is.EqualTo(1));
                Assert.That(standingViewModel.Teams.First().Name, Is.EqualTo(teams[2].Name));
                Assert.That(standingViewModel.Teams.Skip(1).First().Wins, Is.EqualTo(1));
                Assert.That(standingViewModel.Teams.Skip(1).First().Draws, Is.EqualTo(1));
                Assert.That(standingViewModel.Teams.Skip(1).First().Losses, Is.EqualTo(1));
                Assert.That(standingViewModel.Teams.Skip(1).First().Points, Is.EqualTo(4));
                Assert.That(standingViewModel.Teams.Skip(1).First().GoalsFor, Is.EqualTo(5));
                Assert.That(standingViewModel.Teams.Skip(1).First().GoalsAgainst, Is.EqualTo(5));
                Assert.That(standingViewModel.Teams.Skip(1).First().Name, Is.EqualTo(teams[1].Name));
                Assert.That(standingViewModel.Teams.Skip(2).First().Wins, Is.EqualTo(1));
                Assert.That(standingViewModel.Teams.Skip(2).First().Draws, Is.EqualTo(1));
                Assert.That(standingViewModel.Teams.Skip(2).First().Losses, Is.EqualTo(1));
                Assert.That(standingViewModel.Teams.Skip(2).First().Points, Is.EqualTo(4));
                Assert.That(standingViewModel.Teams.Skip(2).First().GoalsFor, Is.EqualTo(3));
                Assert.That(standingViewModel.Teams.Skip(2).First().GoalsAgainst, Is.EqualTo(4));
                Assert.That(standingViewModel.Teams.Skip(2).First().Name, Is.EqualTo(teams[3].Name));
                Assert.That(standingViewModel.Teams.Skip(3).First().Wins, Is.EqualTo(0));
                Assert.That(standingViewModel.Teams.Skip(3).First().Draws, Is.EqualTo(0));
                Assert.That(standingViewModel.Teams.Skip(3).First().Losses, Is.EqualTo(3));
                Assert.That(standingViewModel.Teams.Skip(3).First().Points, Is.EqualTo(0));
                Assert.That(standingViewModel.Teams.Skip(3).First().GoalsFor, Is.EqualTo(0));
                Assert.That(standingViewModel.Teams.Skip(3).First().GoalsAgainst, Is.EqualTo(4));
                Assert.That(standingViewModel.Teams.Skip(3).First().Name, Is.EqualTo(teams[0].Name));
            });

            Assert.ThrowsAsync<BettingAppException>(async () => await competitionService.Standings(-1));
        }

        private Game createGame(int homeTeamId, int awayTeamId, int homeTeamGoals, int awayTeamGoals, int competitionId)
        {
            return new Game()
            {
                AwayRate = 1,
                DrawRate = 1,
                HomeRate = 1,
                AwayTeamGoals = awayTeamGoals,
                HomeTeamGoals = homeTeamGoals,
                AwayTeamId = awayTeamId,
                HomeTeamId = homeTeamId,
                CompetitionId = competitionId,
                DateTime = DateTime.Now.AddHours(-3),
                Finished = true,
                Sign = homeTeamGoals > awayTeamGoals ?
                        ScoreSign.Home :
                        homeTeamGoals == awayTeamGoals ?
                        ScoreSign.Draw :
                        ScoreSign.Away
            };
        }
    }

}
