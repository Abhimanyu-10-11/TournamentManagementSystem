using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextConnector;

namespace TrackerLibrary.DataAccess 
{
    public class TextFileConnector : IDataConnection
    {

        private const string PrizesFile = "PrizeModels.csv";
        private const string PersonsFile = "PersonModels.csv";
        private const string TeamsFile = "TeamModels.csv";
        private const string TournamentFile = "TournamentModel.csv";



        /// <summary>
        /// Save/Create new Person to Textfile.
        /// </summary>
        /// <param name="pesonModel">Provide Person info. </param>
        /// <return>The prizeModel with id form Textfile.</return>
        public PersonModel CreatePerson(PersonModel personModel)
        {
            List<PersonModel> persons = PersonsFile.FullFilePath().LoadFile().ConvertTextToPersonModels();

            int currentId = 1;
            if(persons.Count > 0)
            {
                currentId = persons.OrderByDescending(x => x.Id).First().Id + 1;
            }

            personModel.Id = currentId;

            persons.Add(personModel);

            persons.SaveToPersonFile(PersonsFile);

            return personModel;

        }

     
        /// <summary>
        /// Save/Create new prize to database.
        /// </summary>
        /// <param name="prizeModel">Provide prize info. </param>
        /// <return>The prizeModel with id form database.</return>
        public PrizeModel CreatePrize(PrizeModel prizeModel)
        {

            List<PrizeModel> prizes =  PrizesFile.FullFilePath().LoadFile().ConvertTextToPrizeModels();


            int currentId = 1;

            if(prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            prizeModel.Id = currentId;

            prizes.Add(prizeModel); 

            prizes.SaveToPrizeFile(PrizesFile);

            return prizeModel;
            
        }

        public TeamModel CreateTeam(TeamModel teamModel)
        {
            List<TeamModel> teamModels = TeamsFile.FullFilePath().LoadFile().ConvertTextToTeamModels(PersonsFile);

            int currentId = 1;
            if(teamModels.Count > 0)
            {
                currentId = teamModels.OrderByDescending(x => x.Id).First().Id + 1;
            }

            teamModel.Id = currentId;
            teamModels.Add(teamModel);

            teamModels.SaveToTeamsFile(TeamsFile);

            return teamModel;
            



        }

        public void CreateTournament(TournamentModel tm)
        {
            List<TournamentModel> tournamentModels = TournamentFile.FullFilePath().LoadFile().ConvertTextToTournamentModles(TeamsFile,PrizesFile,PersonsFile);


            int currentId = 1;
            if (tournamentModels.Count > 0)
            {
                currentId = tournamentModels.OrderByDescending(x => x.Id).First().Id + 1;
            }

            tm.Id = currentId;

            tm.SaveRoundToFile();
            tournamentModels.Add(tm);

            tournamentModels.SaveToTorunamentFile(TournamentFile);

        }

        //TODO --- There is space in txt file before email.don't know why? find out.
        public List<PersonModel> GetAllPersons()
        {
            return PersonsFile.FullFilePath().LoadFile().ConvertTextToPersonModels();
        }

        public List<PrizeModel> GetAllPrize()
        {
            return PrizesFile.FullFilePath().LoadFile().ConvertTextToPrizeModels();
        }

        public List<TeamModel> GetAllTeams()
        {
            return TeamsFile.FullFilePath().LoadFile().ConvertTextToTeamModels(PersonsFile);
        }

        public List<TournamentModel> GetAllTournament()
        {
           return TournamentFile.FullFilePath().LoadFile().ConvertTextToTournamentModles(TeamsFile, PrizesFile, PersonsFile);
        }

        public void UpdateMatchup(MatchupModel model)
        {
            model.UpdateMatchupToFile();
        }
    }
}
