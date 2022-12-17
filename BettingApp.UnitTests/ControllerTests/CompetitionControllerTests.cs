using BettingApp.Controllers;

namespace BettingApp.UnitTests.ControllerTests
{
    [TestFixture]
    public class CompetitionControllerTests
    {
        [Test]
        public async Task StandingsReturnsCorrectDataType()
        {
            var guard = new Guard();
            var repo = DatabaseMock.Instance;
            var countryService = new CountryService(repo, guard);
            var teamService = new TeamService(repo, countryService, guard);
            var competitionService = new CompetitionService(repo, teamService, guard);
            var competitionController = new CompetitionController(competitionService);

            var result = await competitionController.Standings(1) as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model, Is.Not.Null);
            Assert.That(result.Model as StandingViewModel, Is.Not.Null);
        }
    }
}
