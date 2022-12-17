namespace BettingApp.UnitTests.ControllerTests
{
    [TestFixture]
    public class EmployeeControllerTests
    {
        private Mock<ICountryService> countryServiceMock;
        private Mock<ITeamService> teamServiceMock;

        public static IRepository repo;

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
            teamServiceMock = new Mock<ITeamService>();
            teamServiceMock
                .Setup(c => c.AllAsync())
                .Returns(
                    Task.FromResult(
                        new List<TeamViewModel>()
                        {
                            new TeamViewModel()
                            {
                                Id = 1,
                                Name = "Levski"
                            },
                            new TeamViewModel()
                            {
                                Id = 1,
                                Name = "Ludogorets"
                            }
                        } as IEnumerable<TeamViewModel>
                ));
        }

        [Test]
        public async Task TestEmployeesAll()
        {
            var memoryCache = MemoryCacheMock.Instance;
            var employeeServiceMock = new Mock<IEmployeeService>();
            employeeServiceMock
                .Setup(c => c.AllAsync())
                .Returns(
                    Task.FromResult(new List<EmployeeViewModel>()
                    {
                        new EmployeeViewModel()
                        {
                            Id = 1,
                            FirstName = "test",
                            LastName = "test",
                            Country = "Bulgaria",
                            Position = "Forward",
                            Team = "test"
                        },
                        new EmployeeViewModel()
                        {
                            Id = 2,
                            FirstName = "test",
                            LastName = "test",
                            Country = "Bulgaria",
                            Position = "Forward",
                            Team = "test"
                        }
                    } as IEnumerable<EmployeeViewModel>
                ));
            var employeeController = 
                new EmployeeController(employeeServiceMock.Object, null, null, memoryCache);

            var result = await employeeController.All() as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model as List<EmployeeViewModel>, Is.Not.Null);
            Assert.That((result.Model as List<EmployeeViewModel>).Count, Is.EqualTo(2));
        }

        [Test]
        public async Task TestCountryAddReturnsView()
        {

            var employeeController = 
                new EmployeeController(null, countryServiceMock.Object, teamServiceMock.Object, null);
            var result = await employeeController.Add() as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model, Is.TypeOf<EmployeeFormModel>());
        }

        [Test]
        public async Task TestAddWithErrorModel()
        {
            var employeeServiceMock = new Mock<IEmployeeService>();
            var memoryCache = MemoryCacheMock.Instance;
            var employeeController = new EmployeeController(employeeServiceMock.Object, null, null, memoryCache);

            var model = new EmployeeFormModel();
            employeeController.ModelState.AddModelError("", "test");
            var result = await employeeController.Add(model) as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model, Is.Not.Null);
        }

        [Test]
        public async Task TestAddWithoutError()
        {
            var employeeServiceMock = new Mock<IEmployeeService>();
            var memoryCache = MemoryCacheMock.Instance;
            var employeeController = new EmployeeController(employeeServiceMock.Object, null, null, memoryCache);

            var model = new EmployeeFormModel();
            var result = await employeeController.Add(model) as RedirectToActionResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.ActionName, Is.EqualTo("All"));
        }

        [Test]
        public async Task TestDeleteRedirectsToAll()
        {
            var employeeServiceMock = new Mock<IEmployeeService>();
            var memoryCache = MemoryCacheMock.Instance;
            var employeeController = new EmployeeController(employeeServiceMock.Object, null, null, memoryCache);
            var result = await employeeController.Delete(1) as RedirectToActionResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.ActionName, Is.EqualTo("All"));
        }

        [Test]
        public async Task TestEditWithModelError()
        {
            var employeeServiceMock = new Mock<IEmployeeService>();
            var memoryCache = MemoryCacheMock.Instance;
            var employeeController = 
                new EmployeeController(employeeServiceMock.Object, countryServiceMock.Object, teamServiceMock.Object, memoryCache);

            var model = new EmployeeFormModel();
            employeeController.ModelState.AddModelError("", "test");
            var result = await employeeController.Edit(model) as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model, Is.TypeOf<EmployeeFormModel>());
        }
        [Test]
        public async Task TestEditWithoutModelError()
        {
            var employeeServiceMock = new Mock<IEmployeeService>();
            var memoryCache = MemoryCacheMock.Instance;
            var employeeController = new EmployeeController(employeeServiceMock.Object, null, null, memoryCache);

            var model = new EmployeeFormModel();
            var result = await employeeController.Edit(model) as RedirectToActionResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.ActionName, Is.EqualTo("All"));
        }

        [Test]
        public async Task TestEditReturnsView()
        {
            var employeeService = new Mock<IEmployeeService>();
            employeeService
                .Setup(e => e.ByIdAsync(It.IsAny<int>()))
                .Returns(
                    Task.FromResult(
                        new EmployeeFormModel()
                        {
                            Id = 1,
                            BirthDate = DateTime.Now.AddYears(-20),
                            CountryId = 2,
                            EmployeeType = EmployeeType.Player,
                            FirstName = "test",
                            LastName = "test",
                            TeamId = 1
                        }
                    )
                );
            var employeeController = 
                new EmployeeController(employeeService.Object, countryServiceMock.Object, teamServiceMock.Object, MemoryCacheMock.Instance);

            var result = await employeeController.Edit(1) as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model, Is.Not.Null);
        }
    }
}
