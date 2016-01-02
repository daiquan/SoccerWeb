using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerWeb.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int TeamID { get; set; }
    }
}