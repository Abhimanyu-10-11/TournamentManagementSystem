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
using TrackerUI.Forms;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> avilableteams = GlobalConfig.Connection.GetAllTeams();
        List<TeamModel> teamsAddedToTournament = new List<TeamModel>();

        List<PrizeModel> prizes = GlobalConfig.Connection.GetAllPrize();

        ITournamentRequester calling;
        public CreateTournamentForm(ITournamentRequester caller)
        {
            InitializeComponent();


            calling = caller;
            WireUpTeamsList();

            WireUpPrizesList();

        }

        private void WireUpPrizesList()
        {
            PrizesListBox.DataSource = null;
            PrizesListBox.DataSource = prizes;
            PrizesListBox.DisplayMember = "PlaceName";

        }

        private void WireUpTeamsList()
        {
            SelectTeamComboBox.DataSource = null;

            SelectTeamComboBox.DataSource = avilableteams;
            SelectTeamComboBox.DisplayMember = "TeamName";


            TournamentPlayersListBox.DataSource = null;

            TournamentPlayersListBox.DataSource = teamsAddedToTournament;
            TournamentPlayersListBox.DisplayMember = "TeamName";


        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            if (SelectTeamComboBox.SelectedItem == null)
            {
                return;

            }
            TeamModel model = (TeamModel)SelectTeamComboBox.SelectedItem;

            avilableteams.Remove(model);
            teamsAddedToTournament.Add(model);

            WireUpTeamsList();

        }



        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            //Call the CreatePrizeForm.
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();


        }

        public void PrizeComplete(PrizeModel prizeModel)
        {
            prizes.Add(prizeModel);
            WireUpPrizesList();
        }

        private void CreateNewTeamLableLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        public void TeamComplete(TeamModel team)
        {
            teamsAddedToTournament.Add(team);
            WireUpTeamsList();
        }

        private void RemoveSelectedTeamsPlayersButton_Click(object sender, EventArgs e)
        {
            if (TournamentPlayersListBox.SelectedItem == null)
            {
                return;
            }

            TeamModel team = (TeamModel)TournamentPlayersListBox.SelectedItem;
            teamsAddedToTournament.Remove(team);
            avilableteams.Add(team);

            WireUpTeamsList();

        }

        private void RemoveSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            if (PrizesListBox.SelectedItem == null)
            { return; }

            PrizeModel p = (PrizeModel)PrizesListBox.SelectedItem;
            prizes.Remove(p);
            WireUpPrizesList();

        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            //validate data
            decimal fee = 0;

            bool feeAcceptable = decimal.TryParse(EntryFeeTextBox.Text,out fee);

            if(!feeAcceptable)
            {
                MessageBox.Show("Entry Valid Entry Fee","Invalid Fee.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            //create our tournament model
            TournamentModel tm = new TournamentModel();
            tm.TournamentName = TournamentNameTextBox.Text;
            tm.EntryFee = fee;

            tm.Prizes = prizes;
            tm.EnteredTeam = teamsAddedToTournament;

            //wire our matchup 
            TournamentLogic.CreateRounds(tm);


            //create tournament entry
            //create all of the prize entries
            //create all of team entries
            GlobalConfig.Connection.CreateTournament(tm);

            calling.UpdateCompleteTournament(tm);
        }
    }
}
