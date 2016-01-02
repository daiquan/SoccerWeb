using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SoccerWeb.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SoccerWeb.DataAccessLayer
{
    public class TeamPlayerContext : DbContext
    {
        public TeamPlayerContext() : base("TeamPlayerContext")
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerTeamRegistration> PlayerRegistrations { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}