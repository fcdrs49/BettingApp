namespace BettingApp.UnitTests.ControllerTests
{
    [TestFixture]
    public class TeamControllerTests
    {
        private IRepository repo;

        [SetUp]
        public void Setup()
        {
            repo = DatabaseMock.Instance;
        }

        [Test]
        public async Task DetailsReturnsCorrectView()
        {
            var guard = new Guard();
            var countryService = new CountryService(repo, guard);
            var teamService = new TeamService(repo, countryService, guard);
            var competitionService = new CompetitionService(repo, teamService, guard);
            var betService = new BetService(repo, guard);
            var gameService = new GameService(repo, competitionService, teamService, betService, guard);
            var teamController = new Controllers.TeamController(teamService, gameService);

            var result = await teamController.Details(1) as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model as TeamViewModel, Is.Not.Null);
            Assert.That((result.Model as TeamViewModel).Games.Count(), Is.EqualTo(5));
        }
    }
}
