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

        // Navigation properties
        //public virtual ICollection<PlayerTeamRegistration> Players { get; set; }
        //[ForeignKey("TeamLeagueRegistrationID")]
        public virtual ICollection<TeamLeagueRegistration> TeamsLeagues { get; set; }
    }
}