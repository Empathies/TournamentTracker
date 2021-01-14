using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// Defines the Database ID of the team
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Defines the list of Persons that are in this team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Defines the name of the team
        /// </summary>
        public string TeamName { get; set; }

    }
}
