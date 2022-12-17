using BettingApp.Areas.Admin.Controllers;
using BettingApp.Core.Models.User;

namespace BettingApp.UnitTests.ControllerTests
{
    [TestFixture]
    public class AdminUserControllerTests
    {
        [Test]
        public async Task IndexReturnsCorrectView()
        {
            var userServiceMock = new Mock<IUserService>();
            userServiceMock
                .Setup(u => u.All())
                .Returns(
                    Task.FromResult(
                        new List<UserServiceModel>()
                        {
                            new UserServiceModel()
                            {
                                Balance = 100,
                                EMail = "a@a.a",
                                FullName = "test test",
                                PhoneNumber = "12312313"
                            },
                            new UserServiceModel()
                            {
                                Balance = 200,
                                EMail = "b@a.a",
                                FullName = "test2 test2",
                                PhoneNumber = "321321321"
                            },
                        } as IEnumerable<UserServiceModel>
                ));
            var userController = new UsersController(userServiceMock.Object, MemoryCacheMock.Instance);

            var result = await userController.Index() as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That((result.Model as List<UserServiceModel>).Count, Is.EqualTo(2));
        }
    }
}
