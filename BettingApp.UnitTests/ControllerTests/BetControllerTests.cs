using BettingApp.Controllers;

namespace BettingApp.UnitTests.ControllerTests
{
    [TestFixture]
    public class BetControllerTests
    {
        public static IRepository repo;

        [SetUp]
        public void Setup()
        {
            repo = DatabaseMock.Instance;
        }

        [Test]
        public async Task GetBetDetailsReturnsCorrectView()
        {
            var betServiceMock = new Mock<IBetService>();
            betServiceMock
                .Setup(b => b.GetGameBets(It.IsAny<int>()))
                .Returns(
                    Task.FromResult(
                        new List<GameBetViewModel>()
                        {
                            new GameBetViewModel()
                            {
                                AwayTeam = "Ludogorets",
                                HomeTeam = "Levski",
                                BetRate = 2,
                                GameId = 1,
                                Prediction = "Home",
                                Won = "X"
                            }
                        } as IEnumerable<GameBetViewModel>
                ));

            var betController = new BetController(null, betServiceMock.Object, repo);

            var result = await betController.GetBetDetails(2) as PartialViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.ViewName, Is.EqualTo("_BetDetailsPartial"));
        }

        [Test]
        public async Task CancelBetRedirectsToCorrectView()
        {
            var betServiceMock = new Mock<IBetService>();
            betServiceMock
                .Setup(b => b.CancelBet(It.IsAny<int>()))
                .Returns(Task.FromResult(0));

            var betController = new BetController(null, betServiceMock.Object, repo);

            var result = await betController.Cancel(2) as RedirectToActionResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.ActionName, Is.EqualTo("UserBets"));
            Assert.That(result.ControllerName, Is.EqualTo("User"));
        }
    }
}
