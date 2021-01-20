using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// The unique identifier for the matchup
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Defines the teams that participate in this Matchup
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// The ID from the database that will be used to identify the winner.
        /// </summary>
        public int WinnerId { get; set; }

        /// <summary>
        /// Defines the winner of this Matchup
        /// </summary>
        public TeamModel Winner { get; set; }
        
        /// <summary>
        /// Defines the round in which this Matchup takes place
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
