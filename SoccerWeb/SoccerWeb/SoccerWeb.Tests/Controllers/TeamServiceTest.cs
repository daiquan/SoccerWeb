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
        //private ITeamService _teamService = new TeamService();

        private ITeamService _teamService;
        [TestInitialize]
        public void Startup()
        {
            _teamService = Resolve<ITeamService>();
        }

        //[TestMethod]
        //public void GetEmptyTeamList()
        //{
        //    Assert.AreEqual(_teamService.GetTeamList().Count, 0);
        //}

        //[TestMethod]
        //public void GetManuallyInitializedTeamList()
        //{
        //    Assert.AreEqual(_teamService.GetTeamList().Count, 5);
        //}

        [TestMethod]
        public void GetDatabaseTeamList()
        {
            Assert.AreEqual(_teamService.GetTeamList().Count, 5);
        }
    }
}
