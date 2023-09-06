using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {   
        /// <summary>
        /// Represents one team in the Matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents score of the particular team in the matchup
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents that his team came from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

    }
}
