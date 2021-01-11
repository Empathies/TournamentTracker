using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Defines the PlaceNumber that wins this prize
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Defines the PlaceName that wins this prize
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Defines the amount of prizemoney in a cash value
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Defines the amount of prizemoney in a percentage
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
