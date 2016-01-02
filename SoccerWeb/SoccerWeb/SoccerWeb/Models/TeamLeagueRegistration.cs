using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerWeb.Models
{
    public class TeamLeagueRegistration
    {
        public int RegistrationID { get; set; }
        public int TeamID { get; set; }
        public int LeagueaID { get; set; }

        // Navigation properties holding connections to the player and the team
        public virtual League league { get; set; }
        public virtual Team team { get; set; }
    }
}