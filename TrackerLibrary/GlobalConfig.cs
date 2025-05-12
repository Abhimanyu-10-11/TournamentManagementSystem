using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {

        public const string PrizesFile = "PrizeModels.csv";
        public const string TournamentFile = "TournamentModel.csv";
        public const string PersonsFile = "PersonModels.csv";
        public const string TeamsFile = "TeamModels.csv";
        public const string MatchupFile = "MatchupModel.csv";
        public const string MatchupEntryFile = "MatchupEntryModel.csv";

        public static IDataConnection Connection { get; private set; }  

        public static void InitializeConnection(DatabaseType databaseType)
        {
            if (databaseType == DatabaseType.Sql)
            {
                SqlConnector sqlConnector = new SqlConnector();
                Connection = sqlConnector;
            }

            if (databaseType == DatabaseType.TextFile)
            {
                TextFileConnector textFileConnector = new TextFileConnector();
                Connection = textFileConnector;
            }
        }


        public static string GetConnectionString(string name)
        {
           return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }


    }
}
