using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SoccerWeb.DataAccessLayer;
using SoccerWeb.Models;
using SoccerWeb.ModelServices;
using System.Data.Entity.Infrastructure;

namespace SoccerWeb.Controllers
{
    public class TeamsController : Controller
    {
        private TeamLeagueContext db = new TeamLeagueContext();

        private ITeamService _teamservice;


        public TeamsController(ITeamService teamservice)
        {
            _teamservice = teamservice;
        }

        // GET: Teams
        public ActionResult Index()
        {
            ICollection<Team> teams = _teamservice.GetTeamList();
            return View(teams.ToList());
        }

        // GET: Teams/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Team team = _teamservice.GetTeamById(id.GetValueOrDefault());
            if (team == null)
            {
                return HttpNotFound();
            }
            return View(team);
        }

        // GET: Teams/Create
        public ActionResult Create()
        {
            PopulateLeaguesDropDownList();
            return View("Create");
        }

        // POST: Teams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TeamID,TeamName,LeagueID")] Team team)
        {
            if (ModelState.IsValid)
            {
                _teamservice.CreateTeam(team);
                return RedirectToAction("Index");
            }
            PopulateLeaguesDropDownList(team.LeagueID);
            return View(team);
        }

        // GET: Teams/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Team team = _teamservice.GetTeamById(id.GetValueOrDefault());
            if (team == null)
            {
                return HttpNotFound();
            }
            return View(team);
        }

        // POST: Teams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TeamID,TeamName,LeagueID")] Team team)
        {
            if (ModelState.IsValid)
            {
                _teamservice.UpdateTeam(team);
                return RedirectToAction("Index");
            }
            return View(team);
        }

        // GET: Teams/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Team team = _teamservice.GetTeamById(id.GetValueOrDefault());
            if (team == null)
            {
                return HttpNotFound();
            }
            return View(team);
        }

        // POST: Teams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _teamservice.DeleteTeam(id);
            return RedirectToAction("Index");
        }

        private void PopulateLeaguesDropDownList(object selectedLeague = null)
        {
            var leaguesQuery = from d in db.Leagues
                                   orderby d.LeagueName
                                   select d;
            ViewBag.LeagueID = new SelectList(leaguesQuery, "LeagueID", "LeagueName", selectedLeague);
        }
    }
}
