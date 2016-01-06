using SoccerWeb.Repositories;
using System.Collections.Generic;
using System.Linq;
using SoccerWeb.DataAccessLayer;
using SoccerWeb.Models;


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
            return new Team();
        }

        public ICollection<Team> GetTeamList()
        {

            // Return the Team list from the database
            //return db.Teams.ToList();
            return _repo.Get().ToList();
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