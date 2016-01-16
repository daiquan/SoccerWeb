using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SoccerWeb.Models;
using SoccerWeb.DataAccessLayer;

namespace SoccerWeb.DataAccessLayer
{
    public class TeamRegistrationInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TeamLeagueContext>
    {
        protected override void Seed(TeamLeagueContext context)
        {
            var leagues = new List<League>
            {
            new League{LeagueName="Pro League"},
            new League{LeagueName="Happy League"}
            };
            leagues.ForEach(s => context.Leagues.Add(s));
            context.SaveChanges();

            var teams = new List<Team>
            {
            new Team{TeamName="Arsenal", LeagueID=leagues.Single(s => s.LeagueName == "Pro League").LeagueID},
            new Team{TeamName="Chelsea", LeagueID=leagues.Single(s => s.LeagueName == "Pro League").LeagueID},
            new Team{TeamName="Guoan", LeagueID=leagues.Single(s => s.LeagueName == "Pro League").LeagueID},
            new Team{TeamName="Real Madrid", LeagueID=leagues.Single(s => s.LeagueName == "Happy League").LeagueID},
            new Team{TeamName="Barca", LeagueID=leagues.Single(s => s.LeagueName == "Happy League").LeagueID}
            };
            teams.ForEach(s => context.Teams.Add(s));
            context.SaveChanges();

            var teamLeagueRegistrations = new List<TeamLeagueRegistration>
            {
            new TeamLeagueRegistration{TeamID=1,LeagueID=1},
            new TeamLeagueRegistration{TeamID=2,LeagueID=1},
            new TeamLeagueRegistration{TeamID=3,LeagueID=1},
            new TeamLeagueRegistration{TeamID=4,LeagueID=2},
            new TeamLeagueRegistration{TeamID=5,LeagueID=2}
            };
            teamLeagueRegistrations.ForEach(s => context.TeamRegistrations.Add(s));
            context.SaveChanges();
        }
    }
}