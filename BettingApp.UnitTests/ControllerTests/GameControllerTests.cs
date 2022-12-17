using BettingApp.Controllers;
using System.Security.Cryptography.Xml;

namespace BettingApp.UnitTests.ControllerTests
{
    [TestFixture]
    public class GameControllerTests
    {
        public static IRepository repo;

        [SetUp]
        public void Setup()
        {
            repo = DatabaseMock.Instance;
        }

        [Test]
        public async Task AddReturnsCorrectView()
        {
            var guard = new Guard();
            var countryService = new CountryService(repo, guard);
            var teamService = new TeamService(repo, countryService, guard);
            var competitionService = new CompetitionService(repo, teamService, guard);
            var gameService = new GameService(repo, competitionService, teamService, null, guard);

            var gameController = new GameController(gameService, teamService, competitionService);

            var result = await gameController.Add() as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model, Is.Not.Null);
            Assert.That((result.Model as GameFormModel), Is.Not.Null);
        }

        [Test]
        public async Task AddReturnsModelWithError()
        {
            var gameController = new GameController(null, null, null);
            var model = new GameFormModel();
            gameController.ModelState.AddModelError("", "test");

            var result = await gameController.Add(model) as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model, Is.Not.Null);
            Assert.That((result.Model as GameFormModel), Is.Not.Null);
        }

        [Test]
        public async Task AddRedirectsCorrectly()
        {
            var gameServiceMock = new Mock<IGameService>();
            gameServiceMock
                .Setup(g => g.CreateAsync(It.IsAny<GameFormModel>()))
                .Returns(Task.FromResult(0));
            var gameController = new GameController(gameServiceMock.Object, null, null);
            var model = new GameFormModel();

            var result = await gameController.Add(model) as RedirectToActionResult;
            Assert.That(result, Is.Not.Null);
            Assert.That(result.ControllerName, Is.EqualTo("Admin"));
            Assert.That(result.ActionName, Is.EqualTo("Games"));
        }

        [Test]
        public async Task DetailsReturnsCorrectView()
        {
            var gameService = new GameService(repo, null, null, null, new Guard());
            var gameController = new GameController(gameService, null, null);

            var result = await gameController.Details(1) as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model as GameDetailsModel, Is.Not.Null);
            Assert.That((result.Model as GameDetailsModel).LastFiveHome.Count(), Is.EqualTo(5));
            Assert.That((result.Model as GameDetailsModel).LastFiveAway.Count(), Is.EqualTo(5));
        }

        [Test]
        public async Task EditReturnsCorrectView()
        {
            var countryService = new CountryService(repo, new Guard());
            var teamService = new TeamService(repo, countryService, new Guard());
            var competitionService = new CompetitionService(repo, teamService, new Guard());
            var gameService = new GameService(repo, competitionService, teamService, null, new Guard());
            var gameController = new GameController(gameService, teamService, competitionService);

            var result = await gameController.Edit(1) as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model as GameFormModel, Is.Not.Null);
        }

        [Test]
        public async Task EditReturnsViewOnInvalidModel()
        {
            var model = new GameFormModel();
            var gameController = new GameController(null, null, null);
            gameController.ModelState.AddModelError("", "error");

            var result = await gameController.Edit(model) as ViewResult;
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model as GameFormModel, Is.Not.Null);
        }

        [Test]
        public async Task EditRedirectsCorrectly()
        {
            var gameServiceMock = new Mock<IGameService>();
            gameServiceMock
                .Setup(g => g.EditAsync(It.IsAny<GameFormModel>()))
                .Returns(Task.FromResult(0));
            var gameController = new GameController(gameServiceMock.Object, null, null);
            var model = new GameFormModel();

            var result = await gameController.Edit(model) as RedirectToActionResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.ActionName, Is.EqualTo("List"));
        }

        [Test]
        public async Task DeleteRedirectsCorrectly()
        {
            var gameService = new Mock<IGameService>();
            gameService
                .Setup(g => g.DeleteAsync(It.IsAny<int>()))
                .Returns(Task.FromResult(0));
            var gameController = new GameController(gameService.Object, null, null);

            var result = await gameController.Delete(1) as RedirectToActionResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.ActionName, Is.EqualTo("List"));
        }

        [Test]
        public async Task AllReturnsCorrectView()
        {
            var competitionService = new CompetitionService(repo, null, new Guard());
            var gameServiceMock = new Mock<IGameService>();
            gameServiceMock
                .Setup(g => g.All(It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>()))
                .Returns(Task.FromResult(
                    new GameQueryServiceModel()
                    {
                        GamesCount = 5,
                        Games = new List<GameViewModel>()
                        {
                            new GameViewModel(),
                            new GameViewModel(),
                            new GameViewModel(),
                            new GameViewModel(),
                            new GameViewModel()
                        }
                    }));
            var gameController = new GameController(gameServiceMock.Object, null, competitionService);
            var gameQueryModel = new GameQueryModel()
            {
                Upcoming = true,
                Results = true,
                Competition = "test",
                CurrentPage = 1,
                TeamTerm = "test",
                TotalGamesCount = 5
            };
            var result = await gameController.All(gameQueryModel) as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model as GameQueryModel, Is.Not.Null);
            Assert.That((result.Model as GameQueryModel).Games.Count, Is.EqualTo(5));
        }


        [Test]
        public async Task ListReturnsCorrectView()
        {
            var competitionService = new CompetitionService(repo, null, new Guard());
            var gameServiceMock = new Mock<IGameService>();
            gameServiceMock
                .Setup(g => g.All(It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>()))
                .Returns(Task.FromResult(
                    new GameQueryServiceModel()
                    {
                        GamesCount = 5,
                        Games = new List<GameViewModel>()
                        {
                            new GameViewModel(),
                            new GameViewModel(),
                            new GameViewModel(),
                            new GameViewModel(),
                            new GameViewModel()
                        }
                    }));
            var gameController = new GameController(gameServiceMock.Object, null, competitionService);
            var gameQueryModel = new GameQueryModel()
            {
                Upcoming = true,
                Results = true,
                Competition = "test",
                CurrentPage = 1,
                TeamTerm = "test",
                TotalGamesCount = 5
            };
            var result = await gameController.List(gameQueryModel) as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model as GameQueryModel, Is.Not.Null);
            Assert.That((result.Model as GameQueryModel).Games.Count, Is.EqualTo(5));
        }
    }
}
