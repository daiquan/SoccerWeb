using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace SoccerWeb.Models
{
    public class League
    {
        public int ID { get; set; }
        [DisplayName("League")]
        public string LeagueName { get; set; }
    }
}