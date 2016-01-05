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
        ActionResult Index();
        ActionResult Details(int? id);
        ActionResult Create();
        ActionResult Create(Team team);
        ActionResult Edit(int? id);
        ActionResult Edit(Team team);
        ActionResult Delete(int? id);
        ActionResult DeleteConfirmed(int id);
        ActionResult Dispose(bool disposing);
    }

    //public class TeamService : ITeamService
    //{
    //}
}