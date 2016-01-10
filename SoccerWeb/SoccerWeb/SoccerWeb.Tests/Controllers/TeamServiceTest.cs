using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoccerWeb.ModelServices;
using System.Collections.Generic;
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
            Assert.AreEqual(_teamService.GetTeamList().Count, 5);
        }

        [TestMethod]
        public void TestTeamIdUsingGetTeamById()
        {
            Team team = _teamService.GetTeamById(1);
            Assert.AreEqual(team.TeamID, 1);
        }

        [TestMethod]
        public void TestTeamNameUsingGetTeamById()
        {
            Team team = _teamService.GetTeamById(1);
            Assert.AreEqual(team.TeamName, "Arsenal");
        }
    }
}
