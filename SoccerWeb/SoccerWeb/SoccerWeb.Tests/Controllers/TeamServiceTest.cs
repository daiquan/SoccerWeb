using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoccerWeb.ModelServices;
using System.Collections.Generic;
using SoccerWeb.Models;

namespace SoccerWeb.Tests.Controllers
{
    [TestClass]
    public class TeamServiceTest
    {
        private ITeamService _teamService = new TeamService();

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
