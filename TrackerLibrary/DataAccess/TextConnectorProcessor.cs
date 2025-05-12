using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextConnector
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["FilePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if(!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();

        }

        public static List<PrizeModel> ConvertTextToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> prizeModels = new List<PrizeModel>();

            foreach (string line in lines)
            {
                 string[] cols = line.Split(',');

                PrizeModel prizeModel = new PrizeModel();
                prizeModel.Id = int.Parse(cols[0]);
                prizeModel.PlaceNumber = int.Parse(cols[1]);
                prizeModel.PlaceName = cols[2];
                prizeModel.PrizeAmount = decimal.Parse(cols[3]);
                prizeModel.PrizePercentage = double.Parse(cols[4]);
                prizeModels.Add(prizeModel);
            }

            return prizeModels;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> prizeModels, string fileName)
        {
            List<string> lines = new List<string>();
            
            foreach(PrizeModel p in prizeModels)
            {
                lines.Add($"{ p.Id },{  p.PlaceNumber },{ p.PlaceName },{ p.PrizeAmount },{ p.PrizePercentage }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
            
        }

        public static List<PersonModel> ConvertTextToPersonModels(this List<string> lines)
        {
            List<PersonModel> personModels = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PersonModel personModel = new PersonModel();
                personModel.Id = int.Parse( cols[0]);
                personModel.FirstName = cols[1];
                personModel.LastName = cols[2];
                personModel.EmailAddress = cols[3];
                personModel.CellphoneNumber = cols[4];
                personModels.Add(personModel);

            }

            return personModels;
        }


        public static void SaveToPersonFile(this List <PersonModel> personModels, string fileName)
        {

            List<string> lines = new List<string>();

            foreach (PersonModel p in personModels)
            {
                lines.Add($"{ p.Id },{ p.FirstName },{ p.LastName },{ p.EmailAddress },{ p.CellphoneNumber }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);

        }


        public static List<TeamModel> ConvertTextToTeamModels(this List<string> lines,string personFileName)
        {

            //teamid,teamName,1|3|4|5-->personIds

            List<TeamModel> teamModels = new List<TeamModel>();

            List<PersonModel> persons = personFileName.FullFilePath().LoadFile().ConvertTextToPersonModels();


            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TeamModel teamModel = new TeamModel();
                teamModel.Id = int.Parse( cols[0]);
                teamModel.TeamName = cols[1];
                string[] personIds = cols[2].Split('|');

                foreach(string s in personIds)
                {
                    teamModel.TeamMembers.Add(persons.Where(x=>x.Id == int.Parse(s)).First());
                }
                teamModels.Add(teamModel);

            }

            return teamModels;


        }

        public static void SaveToTeamsFile(this List<TeamModel> teamModels, string fileName)
        {


            List<string> lines = new List<string>();

            foreach (TeamModel t in teamModels)
            {
                lines.Add($"{t.Id},{t.TeamName},{ConvertPeopleListToStringOfIds(t.TeamMembers)}");
                

            }

            File.WriteAllLines(fileName.FullFilePath(), lines);



        }

        private static string ConvertPeopleListToStringOfIds(List<PersonModel> persons)
        {

            string output = "";

            if(persons.Count == 0)
            {
                return output;
            }

            foreach (PersonModel p in persons)
            {
                output += $"{p.Id}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }



        public static List<TournamentModel> ConvertTextToTournamentModles(this List<string> lines,string teamsFile,string prizeFile,string personFile)
        {
            //id,TournamentName,EntryFee,(id|id|id| - EnteredTeams),(id|id|id| - Prizes),(Rounds - id^id^id|id^id^id|id^id^id)

            List<TournamentModel> outputTM = new List<TournamentModel>();
            List<TeamModel> teams = teamsFile.FullFilePath().LoadFile().ConvertTextToTeamModels(personFile);

            List<PrizeModel> prizes = prizeFile.FullFilePath().LoadFile().ConvertTextToPrizeModels();
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = int.Parse(cols[2]);

                string[] enterTeamIds = cols[3].Split('|');
                
               

                foreach (string id in enterTeamIds)
                {
     

                    tm.EnteredTeam.Add(teams.Where(x=>x.Id == int.Parse(id)).First());

                }


                if (cols[4] != "")
                {

                    string[] prizesIds = cols[4].Split('|');
                    foreach (string id in prizesIds)
                    {
                        tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                    }

                }
                string[] rounds = cols[5].Split('|');
                foreach (string round in rounds)
                {
                    string[] ids = round.Split('^');


                    List<MatchupModel> mm = new List<MatchupModel>();
                    foreach (string matchupModeId in ids)
                    {
                        mm.Add(matchups.Where(x => x.Id == int.Parse(matchupModeId)).First());
                    }
                    tm.Rounds.Add(mm);
                }
                outputTM.Add(tm);

            }


            return outputTM;
        }


        public static void SaveToTorunamentFile(this List<TournamentModel> tournamentModels,string fileName)
        {



            List<string> lines = new List<string>();

            foreach(TournamentModel tm in tournamentModels)
            {
                lines.Add($"{tm.Id},{tm.TournamentName},{tm.EntryFee},{ConvertTeamsToListOfString(tm.EnteredTeam)},{ConvertPrizesToListOfString(tm.Prizes)},{ConvertRoundsToListOfString(tm.Rounds)}");
            }

            
            File.WriteAllLines(fileName.FullFilePath(), lines);




        }

        public static void SaveRoundToFile(this TournamentModel model)
        {
            foreach(List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel mm in round)
                {
                    mm.SaveMatchupToFile();
                }
            }
        }

        public static List<MatchUpEntryModel> ConvertToMatchupEntryModels(this List<string> lines)
        {
            //id,TeamCompeting,Score,ParentMatchup
            List<MatchUpEntryModel> output = new List<MatchUpEntryModel>();
            foreach(string line in lines)
            {
                string[] cols = line.Split(',');

                MatchUpEntryModel me = new MatchUpEntryModel();

                me.Id= int.Parse(cols[0]);
                if (cols[1].Length == 0)
                {
                    me.TeamCompeting = null;
                }
                else
                {
                    me.TeamCompeting = LookupTeamById(int.Parse(cols[1]));

                }
                me.Score = double.Parse(cols[2]);
                int parentId = 0;
                if (int.TryParse(cols[3],out parentId))
                {
                    me.ParentMatchUp = LookupMatchupById(parentId);

                }
                else
                {
                    me.ParentMatchUp = null;
                }
                output.Add(me);
            }
            return output;
            
        }

        private static List<MatchUpEntryModel> ConvertStringToMatchupEntryModel(string input)
        {
            string[] ids = input.Split('|');
            List<MatchUpEntryModel> output = new List<MatchUpEntryModel>();
            List<string> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile();
            List<string> matchingEntries = new List<string>();

            foreach (string id in ids)
            {
                foreach (string entry in entries)
                {
                    string[] cols = entry.Split(',');

                    if (cols[0] == id)
                    {
                        matchingEntries.Add(entry);
                    }
                }
            }

            output = matchingEntries.ConvertToMatchupEntryModels();
            return output;
        }

        private static TeamModel LookupTeamById(int id)
        {
            List<string> teams = GlobalConfig.TeamsFile.FullFilePath().LoadFile();


            foreach (string team in teams)
            {
                string[] cols = team.Split(',');
                if (cols[0] == id.ToString())
                {
                    List<string> matchingTeams = new List<string>();
                    matchingTeams.Add(team);
                    return matchingTeams.ConvertTextToTeamModels(GlobalConfig.PersonsFile).First();
                }
            }

            return null;
            
        }

        private static MatchupModel LookupMatchupById(int id)
        {
            List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();

            foreach(string matchup in matchups)
            {
                string[] cols = matchup.Split(',');
                if(cols[0] == id.ToString())
                {
                    List<string> matchingMatchups = new List<string>();
                    matchingMatchups.Add(matchup);
                    return matchingMatchups.ConvertToMatchupModels().First();
                }
            }


            return null;
        }


        public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
        {
            //id,entries(pipe delimited by id),winner,matchupRound;
            List<MatchupModel> output = new List<MatchupModel>();

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');
                
                MatchupModel p = new MatchupModel();
                p.Id = int.Parse(cols[0]);
                p.Entries = ConvertStringToMatchupEntryModel(cols[1]);
                if (cols[2] == "")
                {
                    p.Winner = null;
                }
                else
                {
                    p.Winner = LookupTeamById(int.Parse(cols[2]));

                }
                p.MatchUpRound = int.Parse(cols[3]);
                output.Add(p);

            }
            return output;
        }
         
        public static void SaveMatchupToFile(this MatchupModel matchup)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            int currentId = 1;
            if(matchups.Count > 0)
            {
                currentId = matchups.OrderByDescending(x => x.Id).First().Id + 1;
            }

            matchup.Id = currentId;
            matchups.Add(matchup);


 

            foreach (MatchUpEntryModel entry in matchup.Entries)
            {
                entry.SaveEntryToFile();
            }


            List<string> lines = new List<string>(); 

            foreach(MatchupModel mm in matchups)
            {
                string winner = "";
                if(mm.Winner != null)
                {
                    winner = mm.Winner.Id.ToString();
                }

                lines.Add($"{mm.Id},{ConvertMatchupEntryToListOfString(mm.Entries)},{winner},{mm.MatchUpRound}"); 
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);


        }


        public static void UpdateMatchupToFile(this MatchupModel matchup)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            MatchupModel oldMatchup = new MatchupModel();
            foreach (MatchupModel m in matchups)
            {
                if(m.Id == matchup.Id)
                    oldMatchup = m;

            }

            matchups.Remove(oldMatchup);

            matchups.Add(matchup);




            foreach (MatchUpEntryModel entry in matchup.Entries)
            {
                entry.UpdateEntryToFile();
            }


            List<string> lines = new List<string>();

            foreach (MatchupModel mm in matchups)
            {
                string winner = "";
                if (mm.Winner != null)
                {
                    winner = mm.Winner.Id.ToString();
                }

                lines.Add($"{mm.Id},{ConvertMatchupEntryToListOfString(mm.Entries)},{winner},{mm.MatchUpRound}");
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);


        }

        public static void UpdateEntryToFile(this MatchUpEntryModel entry)
        {

            List<MatchUpEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

            MatchUpEntryModel oldEntry  = new MatchUpEntryModel();

            foreach(MatchUpEntryModel m in entries) 
            { 
                if(m.Id == entry.Id) 
                    oldEntry = m; 
            }


            entries.Remove(oldEntry);

            entries.Add(entry);

            //save the file
            List<string> lines = new List<string>();

            foreach (MatchUpEntryModel e in entries)
            {

                string parent = "";
                if (e.ParentMatchUp != null)
                {

                    parent = e.ParentMatchUp.Id.ToString();
                }
                string teamcompeting = "";
                if (e.TeamCompeting != null)
                {
                    teamcompeting = e.TeamCompeting.Id.ToString();
                }
                lines.Add($"{e.Id},{teamcompeting},{e.Score},{parent}");
            }

            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }





        private static string ConvertMatchupEntryToListOfString(List<MatchUpEntryModel> entries)
        {

            string output = "";

            if (entries.Count == 0)
            {
                return output;
            }

            foreach (MatchUpEntryModel e in entries)
            {
                output += $"{e.Id}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }

        public static void SaveEntryToFile(this MatchUpEntryModel entry)
        {
            List<MatchUpEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

            int currentId = 1;

            if(entries.Count > 0)
            {
                currentId = entries.OrderByDescending(x => x.Id).First().Id + 1;
            }
            entry.Id = currentId;  
            entries.Add(entry);
            
            //save the file
            List<string> lines = new List<string>();

            foreach (MatchUpEntryModel e in entries)
            {

                string parent = "";
                if(e.ParentMatchUp != null)
                {

                    parent =e.ParentMatchUp.Id.ToString();
                }
                string teamcompeting = "";
                if(e.TeamCompeting != null)
                {
                    teamcompeting = e.TeamCompeting.Id.ToString();
                }
                lines.Add($"{e.Id},{teamcompeting},{e.Score},{parent}");
            }

            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);

        }


        private static string ConvertRoundsToListOfString(List<List<MatchupModel>> rounds)
        {
            //(Rounds - id^id^id|id^id^id|id^id^id)

            string output = "";

            if(rounds.Count == 0)
            {
                return output;
            }

            foreach(List<MatchupModel> r in rounds)
            {
                output += $"{ConvertMatchModelToString(r)}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;


        }

        private static string ConvertMatchModelToString(List<MatchupModel> mm)
        {
            string output = "";

            if (mm.Count == 0)
            {
                return output;
            }

            foreach (MatchupModel m in mm)
            {
                output += $"{m.Id}^";
            }
            output = output.Substring(0, output.Length - 1);
            return output;


        }

        private static string ConvertPrizesToListOfString(List<PrizeModel> prizes)
        {
            string output = "";

            if (prizes.Count == 0)
            {
                return output;
            }

            foreach (PrizeModel p in prizes)
            {
                output += $"{p.Id}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertTeamsToListOfString(List<TeamModel> enteredTeam)
        {

            string output = "";

            if (enteredTeam.Count == 0)
            {
                return output;
            }

            foreach (TeamModel t in enteredTeam)
            {
                output += $"{t.Id}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }
    }
}
