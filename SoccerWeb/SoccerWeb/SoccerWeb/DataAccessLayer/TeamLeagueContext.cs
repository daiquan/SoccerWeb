using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SoccerWeb.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SoccerWeb.DataAccessLayer
{
    public class TeamLeagueContext : DbContext
    {
        public TeamLeagueContext() : base("TeamLeagueContext")
        {
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamLeagueRegistration> TeamRegistrations { get; set; }
        public DbSet<League> Leagues { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}