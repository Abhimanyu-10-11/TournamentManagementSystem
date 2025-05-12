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

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {

        private TournamentModel tournament;
        List<int> rounds = new List<int>();

        List<MatchupModel> currentRoundMatchups = new List<MatchupModel>();


        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            LoadFormData();
            LoadRounds();

        }

        private void WireUpRoundList()
        {
            RoundNumberComboBox.DataSource = null;
            RoundNumberComboBox.DataSource = rounds;

        }

        private void WireUpMatchupList()
        {

            MatchUpListBox.DataSource = null;
            MatchUpListBox.DataSource = currentRoundMatchups;
            MatchUpListBox.DisplayMember = "DisplayName";
        }



        private void LoadFormData()
        {
            tournamentName.Text = tournament.TournamentName;
        }


        private void LoadRounds()
        {
            rounds.Add(1);
            int currRound = 1;
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchUpRound > currRound)
                {
                    currRound = matchups.First().MatchUpRound;
                    rounds.Add(currRound);

                }
            }

            WireUpRoundList();
        }

        private void RoundNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            LoadMatchups();
        }

        private void LoadMatchups()
        {
            currentRoundMatchups.Clear();
            if (RoundNumberComboBox.SelectedItem == null)
            {
                MessageBox.Show("No Round Selected");
                return;
            }

            int round = (int)RoundNumberComboBox.SelectedItem;



            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchUpRound == round)
                {

                    foreach (MatchupModel matchup in matchups)
                    {


                        if (matchup.Winner == null || !UnplayedOnlyCheckBox.Checked)
                            currentRoundMatchups.Add(matchup);

                    }

                }
            }

            WireUpMatchupList();
            DisplayMatchupInfo();
        }

        private void DisplayMatchupInfo()
        {
            bool isVisable = (MatchUpListBox.Items.Count > 0);

            TeamOneLable.Visible = isVisable;
            TeamTwoLabel.Visible = isVisable;
            TeamOneScoreTextBox.Visible = isVisable;
            TeamTwoScoreTextBox.Visible = isVisable;
            ScoreSaveButton.Visible = isVisable;
            VSLable.Visible = isVisable;
            ScoreTeamOneLable.Visible = isVisable;
            ScoreTeamTwoLable.Visible = isVisable;
            

        }

        private void LoadMatchup()
        {

            if (MatchUpListBox.SelectedItem == null)
            {
                return;
            }

            MatchupModel m = (MatchupModel)MatchUpListBox.SelectedItem;


            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        TeamOneLable.Text = m.Entries[0].TeamCompeting.TeamName;
                        TeamOneScoreTextBox.Text = m.Entries[0].Score.ToString();

                        TeamTwoLabel.Text = "<byes>";
                        TeamTwoScoreTextBox.Text = "0";

                    }
                    else
                    {
                        TeamOneLable.Text = "Not Yet Set";
                        TeamOneScoreTextBox.Text = "";
                    }
                }

                if (i == 1)
                {

                    if (m.Entries[1].TeamCompeting != null)
                    {
                        TeamTwoLabel.Text = m.Entries[1].TeamCompeting.TeamName;
                        TeamTwoScoreTextBox.Text = m.Entries[1].Score.ToString();

                    }
                    else
                    {
                        TeamTwoLabel.Text = "Not Yet Set";
                        TeamTwoScoreTextBox.Text = "";
                    }
                }
            }

        }

        private void MatchUpListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup();
        }

        private void UnplayedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }

        private void ScoreSaveButton_Click(object sender, EventArgs e)
        {

            double teamOneScore = 0;
            double teamTwoScore = 0;


            if(MatchUpListBox.Items.Count == 0)
            {
                return;
            }

            MatchupModel m = (MatchupModel)MatchUpListBox.SelectedItem;


            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        
                        bool scoreValid = double.TryParse(TeamOneScoreTextBox.Text, out teamOneScore);

                        if (scoreValid) 
                            m.Entries[0].Score = teamOneScore;


                    }
                    else
                    {
                        MessageBox.Show("Enter a valid score for team 1");
                        return;
                    }
                }

                if (i == 1)
                {

                    if (m.Entries[1].TeamCompeting != null)
                    {

                      
                        bool scoreValid = double.TryParse(TeamTwoScoreTextBox.Text, out teamTwoScore);

                        if (scoreValid)
                            m.Entries[1].Score = teamTwoScore;



                    }
                    else
                    {

                        MessageBox.Show("Enter a valid score for team 2");
                        return;
                    }
                }
            }


            if(teamOneScore>teamTwoScore)
            {
                m.Winner = m.Entries[0].TeamCompeting;
            }
            else if (teamTwoScore>teamOneScore)
            {
                m.Winner = m.Entries[1].TeamCompeting;
            }
            else
            {
                MessageBox.Show("Don't handle tie games.");
            }

            LoadMatchups();

            GlobalConfig.Connection.UpdateMatchup(m);
            

        }
    }
}
