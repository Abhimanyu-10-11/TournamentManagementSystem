using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// The Unique Id for matchup model.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents/Have the total number of Entry in the following round. 
        /// </summary>
        public List<MatchUpEntryModel> Entries { get; set; } = new List<MatchUpEntryModel>();

        /// <summary>
        /// The Id from the database that will be  used to identify the winner.
        /// </summary>
        public int WinnerId { get; set; }
        /// <summary>
        /// Represents winner of the following matchup.
        /// </summary>
        public TeamModel Winner  { get; set; }
        /// <summary>
        /// Repersents the round of the following matchup.
        /// </summary>
        public int MatchUpRound { get; set; }


        public string DisplayName 
        {

            get
            {
                string output = "";
                foreach (MatchUpEntryModel me in Entries)
                {
                    if (me.TeamCompeting!=null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. {me.TeamCompeting.TeamName}";
                        }
                    }
                    else
                    {
                        output = "Matchup Not Yet Determined";
                        break;
                    }

                }

                return output;
                
            } 
        }



    }
}