using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SoccerWeb.DataAccessLayer;
using SoccerWeb.Models;
using System.Web.Mvc;

namespace SoccerWeb.ModelServices
{
    public interface ITeamService
    {
        Team GetTeamById(int id);
        IEnumerable<Team> GetTeamList();
        void CreateTeam(Team team);
        void UpdateTeam(Team team);
        void DeleteTeam(int id);
        void DisposeDb(bool diposing);
    }


}