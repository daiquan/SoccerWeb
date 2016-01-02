using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace SoccerWeb.Models
{
    public class Team
    {
        public int ID { get; set; }
        [DisplayName("Team Name")]
        public string TeamName { get; set; }
        [DisplayName("Registered League")]
        public string LeagueName { get; set; }
    }
}