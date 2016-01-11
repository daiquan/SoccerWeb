using SoccerWeb.Repositories;
using System.Collections.Generic;
using System.Linq;
using SoccerWeb.DataAccessLayer;
using SoccerWeb.Models;
using System.Data.Entity.Infrastructure;
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
        //ICollection<League> GetLeagueList();
    }

    public class TeamService : ITeamService
    {
        //private TeamLeagueContext db = new TeamLeagueContext();
        private IRepository<Team> _repo;
        public TeamService(IRepository<Team> repo) {
            _repo = repo;
        }


        //private TeamLeagueContext _db;
        //public TeamService(TeamLeagueContext db)
        //{
        //    _db = db;
        //}

        public Team GetTeamById(int id)
        {
            return _repo.GetById(id);
        }

        public ICollection<Team> GetTeamList()
        {

            // Return the Team list from the database
            //return db.Teams.ToList();
            return _repo.Get().ToList();
        }

        public void CreateTeam(Team team)
        {
            _repo.Add(team);
        }

        public void UpdateTeam(Team team)
        {

        }

        public void DeleteTeam(int id)
        {
            _repo.Delete(id);
        }

        //public ICollection<League> GetLeagueList()
        //{
        //    var LeaguesQuery = from d in db.Leagues
        //                           orderby d.LeagueName
        //                           select d;
        //    return LeaguesQuery.ToList<League>();
        //}
    }
}