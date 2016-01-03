using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoccerWeb.Models
{
    public class Player
    {
        public int ID { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Gender")]
        public string Gender { get; set; }
        [DisplayName("Team")]
        public String TeamName { get; set; }
        [DisplayName("League")]
        public String LeagueName { get; set; }

        // Navigation property holding the connection to the player's registered team
        //[ForeignKey("PlayerTeamRegistrationID")]
        public virtual PlayerTeamRegistration PlayersTeam { get; set; }
    }
}