using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoccerWeb.Controllers;
using System.Web.Mvc;

namespace SoccerWeb.Tests.Controllers
{
    [TestClass]
    public class TeamsControllerTest
    {
        [TestMethod]
        public void Create()
        {
            var tc = new TeamsController();

            var result = (ViewResult)tc.Create();

            Assert.AreEqual("Create", result.ViewName);
        }
    }
}
