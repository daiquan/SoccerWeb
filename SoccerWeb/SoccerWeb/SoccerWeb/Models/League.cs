using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoccerWeb.Models
{
    public class League
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TeamID { get; set; }
        [DisplayName("League")]
        public string LeagueName { get; set; }

        // Navigation property connecting the team with a league
        public virtual ICollection<TeamLeagueRegistration> Teams { get; set; }
    }
}