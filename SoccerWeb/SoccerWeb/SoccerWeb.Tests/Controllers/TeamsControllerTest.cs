using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoccerWeb.Controllers;
using System.Web.Mvc;

namespace SoccerWeb.Tests.Controllers
{
    [TestClass]
    public class TeamsControllerTest
    {
        [TestMethod]
        public void Index()
        {
            TeamsController controller = new TeamsController();
            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
