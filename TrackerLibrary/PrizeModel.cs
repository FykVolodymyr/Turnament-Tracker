using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the place that the team needs to score to win this prize
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the title earned for scooring for this place in the tournament
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the amount of funds won within this place in the tournament
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the percentage of the overal prize pool earned by the team in this place
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
