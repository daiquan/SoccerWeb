using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoccerWeb.Models
{
    public class Team
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TeamID { get; set; }
        [DisplayName("Team Name")]
        public string TeamName { get; set; }
        public int LeagueID { get; set; }

        // Navigation properties
        //public virtual ICollection<PlayerTeamRegistration> Players { get; set; }
        [DisplayName("Registered League")]
        public virtual TeamLeagueRegistration TeamsLeague { get; set; }
    }
}