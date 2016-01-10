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
            TeamsController controller = Resolve<TeamsController>();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Details()
        {
            // Arrange
            TeamsController controller = Resolve<TeamsController>();

            // Act
            ViewResult result = controller.Details(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
