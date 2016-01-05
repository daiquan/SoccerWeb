using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SoccerWeb.DataAccessLayer;
using SoccerWeb.Models;
using System.Data.Entity;
using System.Web.Mvc;

namespace SoccerWeb.ModelServices
{
    public interface ITeamService
    {
        Team GetTeamById(int id);
        ICollection<Team> GetTeamList();
        void CreateTeam(Team team);
        void UpdateTeam(Team team);
        void DeleteTeam(int id);
        void DisposeDb(bool diposing);
    }

    public class TeamService : ITeamService
    {
        private TeamLeagueContext db = new TeamLeagueContext();

        public Team GetTeamById(int id)
        {
            return new Team();
        }

        public ICollection<Team> GetTeamList()
        {
            // Return an empty Team list
            //ICollection<Team> tmp = new List<Team>();
            //return tmp;

            // Return a manually initialized list
            //var teams = new List<Team>
            //{
            //new Team{TeamName="Arsenal"},
            //new Team{TeamName="Chelsea"},
            //new Team{TeamName="Guoan"},
            //new Team{TeamName="Real Madrid"},
            //new Team{TeamName="Barca"}
            //};
            //return teams;

            // Return the Team list from the database
            return db.Teams.ToList();
        }

        public void CreateTeam(Team team)
        {

        }

        public void UpdateTeam(Team team)
        {

        }

        public void DeleteTeam(int id)
        {

        }

        public void DisposeDb(bool diposing)
        {

        }
    }
}