using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoccerWeb.ModelServices;
using SoccerWeb.Models;

namespace SoccerWeb.Tests.Controllers
{
    [TestClass]
    public class TeamServiceTest : TestBase
    {
        private ITeamService _teamService;
        [TestInitialize]
        public void Startup()
        {
            _teamService = Resolve<ITeamService>();
        }

        [TestMethod]
        public void GetDatabaseTeamList()
        {
            Assert.AreEqual(_teamService.GetTeamList().Count, 1);
        }

        [TestMethod]
        public void TestGetTeamById_NotNull()
        {
            Team team = _teamService.GetTeamById(1);
            Assert.IsNotNull(team.TeamID);
        }
    }
}
