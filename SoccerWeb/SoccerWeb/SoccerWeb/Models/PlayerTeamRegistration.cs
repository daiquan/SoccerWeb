using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerWeb.Models
{
    public class PlayerTeamRegistration
    {
        public int RegistrationID { get; set; }
        public int PlayerID { get; set; }
        public int TeamID { get; set; }

        // Navigation properties holding connections to the player and the team
        public virtual Player player { get; set; }
        public virtual Team team { get; set; }
    }
}