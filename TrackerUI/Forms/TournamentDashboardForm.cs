using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI.Forms
{
    public partial class TournamentDashboardForm : Form, ITournamentRequester
    {

        List<TournamentModel> tournamentModels = GlobalConfig.Connection.GetAllTournament();
        public TournamentDashboardForm()
        {
            InitializeComponent();

            WireUpExistingTournament();
        }



        private void WireUpExistingTournament()
        {
            LoadExistingTournamentDropDown.DataSource = null;

            LoadExistingTournamentDropDown.DataSource = tournamentModels;
            LoadExistingTournamentDropDown.DisplayMember = "TournamentName";
        }

        private void CreateTournamentLabel_Click(object sender, EventArgs e)
        {
            CreateTournamentForm tournamentForm = new CreateTournamentForm(this);
            tournamentForm.Show();
            //CreateTournamentBotton.Visible = false;
        }

        public void UpdateCompleteTournament(TournamentModel tournament)
        {
            tournamentModels.Add(tournament);
            WireUpExistingTournament();
            // CreateTournamentBotton.Visible = true;
        }

        private void LoadTournamentButton_Click(object sender, EventArgs e)
        {
            if(LoadExistingTournamentDropDown.SelectedItem == null)
            {
                MessageBox.Show("Select The Tournament.");
                return;
            }

            TournamentModel tm = (TournamentModel)LoadExistingTournamentDropDown.SelectedItem;

            TournamentViewerForm tournamentViewerForm = new TournamentViewerForm(tm);
            tournamentViewerForm.Show();
        }
    }
}
