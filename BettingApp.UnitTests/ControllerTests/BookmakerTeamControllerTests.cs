namespace BettingApp.UnitTests.ControllerTests
{
    [TestFixture]
    public class BookmakerTeamControllerTests
    {
        public static IRepository repo;
        private Mock<ICountryService> countryServiceMock;

        [SetUp]
        public void SetUp()
        {
            repo = DatabaseMock.Instance;
            countryServiceMock = new Mock<ICountryService>();
            countryServiceMock
                .Setup(c => c.AllAsync())
                .Returns(
                    Task.FromResult(
                        new List<CountryModel>()
                        {
                            new CountryModel()
                            {
                                Id = 1,
                                Name = "Bulgaria"
                            },
                            new CountryModel()
                            {
                                Id = 2,
                                Name = "Germany"
                            }
                        } as IEnumerable<CountryModel>
                ));
        }

        [Test]
        public async Task TestTeamsAll()
        {
            var memoryCache = MemoryCacheMock.Instance;
            var teamServiceMock = new Mock<ITeamService>();
            teamServiceMock
                .Setup(c => c.AllAsync())
                .Returns(
                    Task.FromResult(new List<TeamViewModel>()
                    {
                        new TeamViewModel()
                        {
                            Id = 1,
                            Name = "Levski",
                            Country = "Bulgaria"
                        },
                        new TeamViewModel()
                        {
                            Id = 1,
                            Name = "Ludogorets",
                            Country = "Bulgaria"
                        }
                    } as IEnumerable<TeamViewModel>
                ));
            var teamController = new TeamController(teamServiceMock.Object, null, memoryCache);

            var result = await teamController.All() as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model as List<TeamViewModel>, Is.Not.Null);
            Assert.That((result.Model as List<TeamViewModel>).Count, Is.EqualTo(2));
        }

        [Test]
        public async Task TestTeamAddReturnsView()
        {
            var teamsController = new TeamController(null, countryServiceMock.Object, null);
            var result = await teamsController.Add() as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model, Is.TypeOf<TeamFormModel>());
        }

        [Test]
        public async Task TestAddWithErrorModel()
        {
            var teamServiceMock = new Mock<ITeamService>();
            var memoryCache = MemoryCacheMock.Instance;
            var teamController = new TeamController(teamServiceMock.Object, countryServiceMock.Object, memoryCache);

            var model = new TeamFormModel();
            teamController.ModelState.AddModelError("", "test");
            var result = await teamController.Add(model) as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model, Is.Not.Null);
        }

        [Test]
        public async Task TestAddWithoutError()
        {
            var teamServiceMock = new Mock<ITeamService>();
            var memoryCache = MemoryCacheMock.Instance;
            var teamController = new TeamController(teamServiceMock.Object, countryServiceMock.Object, memoryCache);

            var model = new TeamFormModel();
            var result = await teamController.Add(model) as RedirectToActionResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.ActionName, Is.EqualTo("All"));
        }

        [Test]
        public async Task TestDeleteRedirectsToAll()
        {
            var teamServiceMock = new Mock<ITeamService>();
            var memoryCache = MemoryCacheMock.Instance;
            var teamController = new TeamController(teamServiceMock.Object, countryServiceMock.Object, memoryCache);
            var result = await teamController.Delete(1) as RedirectToActionResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.ActionName, Is.EqualTo("All"));
        }

        [Test]
        public async Task TestEditWithModelError()
        {
            var teamServiceMock = new Mock<ITeamService>();
            var memoryCache = MemoryCacheMock.Instance;
            var teamController = new TeamController(teamServiceMock.Object, countryServiceMock.Object, memoryCache);

            var model = new TeamFormModel();
            teamController.ModelState.AddModelError("", "test");
            var result = await teamController.Edit(model) as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model, Is.TypeOf<TeamFormModel>());
        }
        [Test]
        public async Task TestEditWithoutModelError()
        {
            var teamServiceMock = new Mock<ITeamService>();
            var memoryCache = MemoryCacheMock.Instance;
            var teamController = new TeamController(teamServiceMock.Object, countryServiceMock.Object, memoryCache);

            var model = new TeamFormModel();
            var result = await teamController.Edit(model) as RedirectToActionResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.ActionName, Is.EqualTo("All"));
        }

        [Test]
        public async Task TestEditReturnsView()
        {
            var teamService = new TeamService(repo, countryServiceMock.Object, new Guard());
            var teamController = new TeamController(teamService, countryServiceMock.Object, MemoryCacheMock.Instance);

            var result = await teamController.Edit(1) as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model, Is.Not.Null);
        }
    }
}
