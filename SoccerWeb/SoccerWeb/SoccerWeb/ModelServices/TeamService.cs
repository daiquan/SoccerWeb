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
    }

    public class TeamService : ITeamService
    {
        private IRepository<Team> _repo;
        private IRepository<TeamLeagueRegistration> _repoRegistration;
        public TeamService(IRepository<Team> repo, IRepository<TeamLeagueRegistration> repoRegistration) {
            _repo = repo;
            _repoRegistration = repoRegistration;
        }

        public Team GetTeamById(int id)
        {
            return _repo.GetById(id);
        }

        public ICollection<Team> GetTeamList()
        {
            return _repo.Get().ToList();
        }

        public void CreateTeam(Team team)
        {
            _repo.Add(team);
            _repo.Update();
            _repoRegistration.Add(new TeamLeagueRegistration { TeamID = team.TeamID, LeagueID = team.LeagueID });
            _repoRegistration.Update();
        }

        public void UpdateTeam(Team team)
        {

        }

        public void DeleteTeam(int id)
        {
            _repo.Delete(id);
        }
    }
}