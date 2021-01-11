using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Defines the name of the tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Defines the required fee to enter the tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Defines the list of teams that compete in the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Defines list of prizes that can be won in this tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Defines the list of rounds, each with a list of MatchUps in the tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
