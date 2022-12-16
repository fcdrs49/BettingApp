using BettingApp.Core.Models.Employee;

namespace BettingApp.UnitTests
{
    [TestFixture]
    public class EmployeeServiceTests
    {
        private IRepository repo { get; set; }
        private IEmployeeService employeeService { get; set; }
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
            employeeService = new EmployeeService(repo, guard);
        }

        [Test]
        public async Task TestCRUD()
        {
            var employees = await repo.AllReadonly<Employee>().ToListAsync();
            repo.DeleteRange(employees);
            await repo.SaveChangesAsync();

            var team = repo.AllReadonly<Team>().First();
            var country = repo.AllReadonly<Country>().First();

            var employee = new EmployeeFormModel()
            {
                BirthDate = DateTime.Now.AddYears(-20),
                CountryId = country.Id,
                EmployeeType = EmployeeType.Player,
                FirstName = "testName",
                LastName = "testLastName",
                TeamId = team.Id
            };
            await employeeService.CreateAsync(employee);

            var employeeModels = await employeeService.AllAsync();
            Assert.Multiple(() =>
            {
                Assert.That(employeeModels.Count(), Is.EqualTo(1));
                Assert.That(employeeModels.First().Team, Is.EqualTo(team.Name));
                Assert.That(employeeModels.First().Country, Is.EqualTo(country.Name));
                Assert.That(employeeModels.First().FirstName, Is.EqualTo(employee.FirstName));
            });
            employee = await employeeService.ByIdAsync(employeeModels.First().Id);
            Assert.Multiple(() =>
            {
                Assert.That(employee.CountryId, Is.EqualTo(country.Id));
                Assert.That(employee.TeamId, Is.EqualTo(team.Id));
                Assert.That(employee.FirstName, Is.EqualTo(employeeModels.First().FirstName));
            });

            employee.FirstName = "FNtest";
            employee.LastName = "LNtest";
            await employeeService.EditAsync(employee);

            var empDetails = await employeeService.DetailsByIdAsync(employee.Id);
            Assert.Multiple(() =>
            {
                Assert.That(empDetails.Country, Is.EqualTo(country.Name));
                Assert.That(empDetails.Team, Is.EqualTo(team.Name));
                Assert.That(empDetails.Id, Is.EqualTo(employee.Id));
                Assert.That(empDetails.FirstName, Is.EqualTo(employee.FirstName));
                Assert.That(empDetails.LastName, Is.EqualTo(employee.LastName));
            });

            await employeeService.DeleteAsync(employee.Id);
            employeeModels = await employeeService.AllAsync();
            Assert.That(employeeModels.Count(), Is.EqualTo(0));
        }
    }
}