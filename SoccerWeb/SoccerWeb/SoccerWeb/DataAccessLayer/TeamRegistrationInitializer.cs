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
            var teams = new List<Team>
            {
            new Team{TeamName="Arsenal"},
            new Team{TeamName="Chelsea"},
            new Team{TeamName="Guoan"},
            new Team{TeamName="Real Madrid"},
            new Team{TeamName="Barca"}
            };

            teams.ForEach(s => context.Teams.Add(s));
            context.SaveChanges();
            var leagues = new List<League>
            {
            new League{LeagueName="Pro League"},
            new League{LeagueName="Happy League"}
            };
            leagues.ForEach(s => context.Leagues.Add(s));
            context.SaveChanges();
            var teamLeagueRegistrations = new List<TeamLeagueRegistration>
            {
            new TeamLeagueRegistration{TeamID=1,LeagueID=1},
            new TeamLeagueRegistration{TeamID=1,LeagueID=2},
            new TeamLeagueRegistration{TeamID=1,LeagueID=3},
            new TeamLeagueRegistration{TeamID=2,LeagueID=4},
            new TeamLeagueRegistration{TeamID=2,LeagueID=5}
            };
            teamLeagueRegistrations.ForEach(s => context.TeamRegistrations.Add(s));
            context.SaveChanges();
        }
    }
}