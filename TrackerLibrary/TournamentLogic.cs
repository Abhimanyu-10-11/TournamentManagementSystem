using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        //order our list randomly of teams
        //Check if it is big enough - if not, add in byes - 2*2*2*2 - 2^4
        //Check out first round of matchups
        //Create every round after that - 8 matchups - 4 matchups - 2 matchups -1 matchups.

        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomizedTeamOrder = RandomizedTeamOrder(model.EnteredTeam);
            int rounds = FindNumberOfRounds(randomizedTeamOrder.Count);
            int byes = NumberOfBuys(rounds,randomizedTeamOrder.Count);
            model.Rounds.Add(CreateFirstRound(byes, randomizedTeamOrder));

            CreateOtherRounds(model,rounds);
        }

        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {
            int round = 2;
            List<MatchupModel> previousRound = model.Rounds[0];
            List<MatchupModel> currRound = new List<MatchupModel>();
            MatchupModel currMatchup= new MatchupModel();

            while (round <= rounds)
            {
                foreach (MatchupModel matchup in previousRound)
                {

                    currMatchup.Entries.Add(new MatchUpEntryModel { ParentMatchUp = matchup });

                    if (currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchUpRound = round;
                        currRound.Add(currMatchup);
                        currMatchup = new MatchupModel();
                    }

                }

                model.Rounds.Add(currRound);
                previousRound = currRound;

                currRound = new List<MatchupModel>();
                round++;


            }
        }

        public static List<MatchupModel> CreateFirstRound(int byes,List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel current = new MatchupModel();

           foreach (TeamModel team in teams)
            {
                current.Entries.Add(new MatchUpEntryModel { TeamCompeting = team });

                if(byes>0 || current.Entries.Count > 1)
                {
                    current.MatchUpRound = 1;
                    output.Add(current);
                    current = new MatchupModel();

                    if(byes > 0)
                    {
                        byes--;
                    }
                }
           }

           return output;
        }

        private static int NumberOfBuys(int rounds, int numberOfTeams)
        {
            int output = 0;
            int totalTeams = 1;

            for(int i =1;i<=rounds;i++)
            {
                totalTeams *= 2;
            }

            output = totalTeams - numberOfTeams;
            return output;
        }

        private static int FindNumberOfRounds(int numberOfTeams)
        {
            int output = 1;
            int val = 2;
            while(val< numberOfTeams)
            {
                output +=1;
                val *= 2;
            }
            return output;
        }

        private static List<TeamModel> RandomizedTeamOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}
