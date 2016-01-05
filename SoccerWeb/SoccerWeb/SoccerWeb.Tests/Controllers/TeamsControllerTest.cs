using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoccerWeb.Controllers;
using System.Web.Mvc;

namespace SoccerWeb.Tests.Controllers
{
    [TestClass]
    public class TeamsControllerTest : TestBase
    {

        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = Resolve<HomeController>();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
