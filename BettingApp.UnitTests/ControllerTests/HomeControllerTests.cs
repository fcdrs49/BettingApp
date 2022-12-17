
namespace BettingApp.UnitTests.ControllerTests
{
    [TestFixture]
    public class HomeControllerTests
    {
        private IRepository repo;

        [SetUp]
        public void Setup()
        {
            repo = DatabaseMock.Instance;
        }

        [Test]
        public async Task IndexReturnsCorrectView()
        {
            var guard = new Guard();
            var countryService = new CountryService(repo, guard);
            var teamService = new TeamService(repo, countryService, guard);
            var competitionService = new CompetitionService(repo, teamService, guard);
            var betService = new BetService(repo, guard);
            var gameService = new GameService(repo, competitionService, teamService, betService, guard);
            var controller = new Controllers.HomeController(gameService);

            var result = await controller.Index() as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model as IEnumerable<GameViewModel>, Is.Not.Null);
            Assert.That((result.Model as IEnumerable<GameViewModel>).Count(), Is.EqualTo(10));
        }

        [Test]
        public void ErrorReturnsCorrectView()
        {
            var homeController = new Controllers.HomeController(null);

            var result = homeController.Error() as ViewResult;

            Assert.That(result, Is.Not.Null);
        }
    }
}
