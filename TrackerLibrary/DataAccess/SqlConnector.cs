using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {

        private const string databaseName = "Tournaments";

        /// <summary>
        /// Save/Create new Person to database.
        /// </summary>
        /// <param name="personModel">Provide person info. </param>
        /// <return>The personModel with id form database.</return>
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnectionString(databaseName)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@CellphoneNumber", model.CellphoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;

            }
        }
        /// <summary>
        /// Save/Create new prize to database.
        /// </summary>
        /// <param name="prizeModel">Provide prize info. </param>
        /// <return>The prizeModel with id form database.</return>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnectionString(databaseName)))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;

            }
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnectionString(databaseName)))
            {
                var p = new DynamicParameters();
                p.Add("@TeamName", model.TeamName);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                foreach (PersonModel personModel in model.TeamMembers)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamId", model.Id);
                    p.Add("@PersonId", personModel.Id);

                    connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);


                }

                return model;

            }
        }

        public void CreateTournament(TournamentModel tournamentModel)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnectionString(databaseName)))
            {
                SaveTournamentEntries(tournamentModel, connection);

                SaveTournamentPrizes(tournamentModel, connection);

                SaveEnteredTeam(tournamentModel, connection);

                SaveTournamentRounds(tournamentModel, connection);
            }


        }

        private void SaveTournamentRounds(TournamentModel model, IDbConnection connection)
        {
            //loop through the rounds
            //loop through the matchups
            //save the matchup
            //loop through the entries and save them

            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {

                    var p = new DynamicParameters();
                    p.Add("@TournamentId", model.Id);
                    p.Add("@MatchupRound", matchup.MatchUpRound);
                    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spMatchups_Insert", p, commandType: CommandType.StoredProcedure);

                    matchup.Id = p.Get<int>("@id");

                    foreach (MatchUpEntryModel entry in matchup.Entries)
                    {
                        p = new DynamicParameters();
                        p.Add("@MatchupId", matchup.Id);
                        if (entry.ParentMatchUp == null)
                        {
                            p.Add("@ParentMatchupId", null);
                        }
                        else
                        {
                            p.Add("@ParentMatchupId", entry.ParentMatchUp.Id);

                        }
                        if (entry.TeamCompeting == null)
                        {
                            p.Add("@TeamCompetingId", null);

                        }
                        else
                        {
                            p.Add("@TeamCompetingId", entry.TeamCompeting.Id);
                        }

                        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                        connection.Execute("dbo.spMatchupEntries_Insert", p, commandType: CommandType.StoredProcedure);

                    }
                }
            }
        }

        private void SaveEnteredTeam(TournamentModel tournamentModel, IDbConnection connection)
        {
            foreach (TeamModel teamModel in tournamentModel.EnteredTeam)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentId", tournamentModel.Id);
                p.Add("@TeamId", teamModel.Id);

                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.TournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);

            }
        }

        private void SaveTournamentPrizes(TournamentModel tournamentModel, IDbConnection connection)
        {

            foreach (PrizeModel pz in tournamentModel.Prizes)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentId", tournamentModel.Id);
                p.Add("@PrizeId", pz.Id);

                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
            }

        }

        private void SaveTournamentEntries(TournamentModel tournamentModel, IDbConnection connection)
        {
            var p = new DynamicParameters();
            p.Add("@TournamentName", tournamentModel.TournamentName);
            p.Add("@EntryFee", tournamentModel.EntryFee);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTournaments_Insert", p, commandType: CommandType.StoredProcedure);

            tournamentModel.Id = p.Get<int>("@id");
        }

        public List<PersonModel> GetAllPersons()
        {
            List<PersonModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnectionString(databaseName)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }

            return output;
        }

        public List<PrizeModel> GetAllPrize()
        {
            List<PrizeModel> output = new List<PrizeModel>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnectionString(databaseName)))
            {
                output = connection.Query<PrizeModel>("dbo.spPrizes_GetAll").ToList();
            }

            return output;


        }

        public List<TeamModel> GetAllTeams()
        {
            List<TeamModel> output = new List<TeamModel>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnectionString(databaseName)))
            {
                output = connection.Query<TeamModel>("dbo.spTeams_GetAll").ToList();

                foreach (TeamModel team in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@TeamId", team.Id);

                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();

                }


            }

            return output;
        }

        public List<TournamentModel> GetAllTournament()
        {

            List<TournamentModel> output = new List<TournamentModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnectionString(databaseName)))
            {

                output = connection.Query<TournamentModel>("dbo.spTournament_GetAll").ToList();

                var p = new DynamicParameters();
                foreach (TournamentModel t in output)
                {


                    p = new DynamicParameters();
                    p.Add("@TournamentId", t.Id);


                    t.Prizes = connection.Query<PrizeModel>("dbo.spPrizes_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    t.EnteredTeam = connection.Query<TeamModel>("dbo.spTeam_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach (TeamModel team in t.EnteredTeam)
                    {
                        p = new DynamicParameters();
                        p.Add("@TeamId", team.Id);

                        team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();

                    }

                    p = new DynamicParameters();
                    p.Add("@TournamentId", t.Id);
                    List<MatchupModel> matchups = connection.Query<MatchupModel>("dbo.spMatchups_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach (MatchupModel m in matchups)
                    {
                        p = new DynamicParameters();

                        p.Add("@MatchupId", m.Id);

                        m.Entries = connection.Query<MatchUpEntryModel>("dbo.spMatchupEntries_GetByMatchup", p, commandType: CommandType.StoredProcedure).ToList();


                        List<TeamModel> allTeam = GetAllTeams();

                        if (m.WinnerId > 0)
                        {
                            m.Winner = allTeam.Where(x => x.Id == m.WinnerId).First();
                        }

                        foreach (MatchUpEntryModel me in m.Entries)
                        {
                            if (me.TeamCompetingId > 0)
                            {
                                me.TeamCompeting = allTeam.Where(x => x.Id == me.TeamCompetingId).First();
                            }


                            if (me.ParentMatchupId > 0)
                            {
                                me.ParentMatchUp = matchups.Where(x => x.Id == me.ParentMatchupId).First();
                            }


                        }


                    }

                    List<MatchupModel> currRow = new List<MatchupModel>();
                    int currRound = 1;

                    foreach (MatchupModel m in matchups)
                    {

                        if (m.MatchUpRound > currRound)
                        {
                            t.Rounds.Add(currRow);
                            currRow = new List<MatchupModel>();
                            currRound++;
                        }


                        currRow.Add(m);

                    }

                    t.Rounds.Add(currRow);

                }


            }

            return output;
        }

        public void UpdateMatchup(MatchupModel m)
        {
            //dbo.spMatchupEntries_Update


            List<TournamentModel> output = new List<TournamentModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnectionString(databaseName)))
            { 


                var p = new DynamicParameters();
                p.Add("@id", m.Id);
                p.Add("@WinnerId", m.Winner.Id);

                connection.Execute("dbo.spMatchups_Update", p, commandType: CommandType.StoredProcedure);

                foreach (MatchUpEntryModel me in m.Entries)
                {

                    p = new DynamicParameters(); 
                    p.Add("@id", me.Id);
                    p.Add("@TeamCompetingId", me.TeamCompeting.Id);
                    p.Add("@Score", me.Score);

                    connection.Execute("dbo.spMatchupEntries_Update", p, commandType: CommandType.StoredProcedure);

                }

            }

        }
    }
}
