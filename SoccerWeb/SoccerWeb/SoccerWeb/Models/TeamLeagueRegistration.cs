using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoccerWeb.Models
{
    public class TeamLeagueRegistration
    {
        public int TeamLeagueRegistrationID { get; set; }
        public int TeamID { get; set; }
        public int LeagueID { get; set; }

        // Navigation properties holding connections to the player and the team
        public virtual League league { get; set; }
        public virtual Team team { get; set; }
    }
}