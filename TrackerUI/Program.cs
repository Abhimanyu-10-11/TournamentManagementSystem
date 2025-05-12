using System.ComponentModel.Design;
using TrackerLibrary;
using TrackerUI.Forms;

namespace TrackerUI
{ 
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() 
        {

            
            ApplicationConfiguration.Initialize();
            GlobalConfig.InitializeConnection(DatabaseType.TextFile);

            Application.Run(new TournamentDashboardForm());
            //Application.Run(new TournamentDashboardForm());
        }
    }
}