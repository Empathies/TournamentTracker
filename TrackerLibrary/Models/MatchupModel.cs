using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// Defines the teams that participate in this Matchup
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        
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
