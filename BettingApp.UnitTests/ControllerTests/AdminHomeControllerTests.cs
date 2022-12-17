namespace BettingApp.UnitTests.ControllerTests
{
    [TestFixture]
    public class AdminHomeControllerTests
    {
        [Test]
        public void IndexReturnsCorrectView()
        {
            var homeController = new Areas.Admin.Controllers.HomeController();

            var result = homeController.Index() as ViewResult;

            Assert.That(result, Is.Not.Null);
        }
    }
}
