using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the teams that entered the match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents the team that won the match
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the round within which the match is held
        /// </summary>
        public int MatchupRoundl { get; set; }
        
    }
}
