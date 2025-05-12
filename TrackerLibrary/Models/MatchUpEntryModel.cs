using System;

namespace TrackerLibrary.Models
{
    public class MatchUpEntryModel
    {


        /// <summary>
        /// The Unique Id for matchupEntry model.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// teamcompeting id from database to find TeamModel TeamCompeting
        /// </summary>
        public int TeamCompetingId { get; set; }
        /// <summary>
        /// Represents one team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score for this particular team.
        /// </summary>
        public double Score { get; set; }


        public int ParentMatchupId { get; set; }
        /// <summary>
        /// Represents the matchup that this team come 
        /// form as the winner
        /// </summary>
        /// </summary>
        public MatchupModel ParentMatchUp { get; set; }

     
    }
}