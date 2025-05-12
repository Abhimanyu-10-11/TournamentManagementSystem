using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {

        private List<PersonModel> avilableTeamMember = GlobalConfig.Connection.GetAllPersons();
        private List<PersonModel> selectedTeamMemeber = new List<PersonModel>();

        ITeamRequester calling;

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();

            // CreateSample();
            calling = caller;
            WireUpLists();

        }



        private void CreateSample()
        {
            avilableTeamMember.Add(new PersonModel { FirstName = "abhi", LastName = "chaudhary" });
            avilableTeamMember.Add(new PersonModel { FirstName = "ambikesh", LastName = "chaudhary" });

            selectedTeamMemeber.Add(new PersonModel { FirstName = "abhimanyu", LastName = "Kumar" });

        }

        private void WireUpLists()
        {
            SelectTeamMemberComboBox.DataSource = null;

            SelectTeamMemberComboBox.DataSource = avilableTeamMember;
            SelectTeamMemberComboBox.DisplayMember = "FullName";

            TeamMemberListBox.DataSource = null;

            TeamMemberListBox.DataSource = selectedTeamMemeber;
            TeamMemberListBox.DisplayMember = "FullName";
        }

        private void CreateMemberBotton_Click(object sender, EventArgs e)
        {
            if (IsCreateMemberValid())
            {
                PersonModel person = new PersonModel();
                person.FirstName = FirstNameTextBox.Text;
                person.LastName = LastNameTextBox.Text;
                person.EmailAddress = EmailTextbox.Text;
                person.CellphoneNumber = CellPhoneNumberTextbox.Text;

                person = GlobalConfig.Connection.CreatePerson(person);

                selectedTeamMemeber.Add(person);
                WireUpLists();


                FirstNameTextBox.Text = "";
                LastNameTextBox.Text = "";
                EmailTextbox.Text = "";
                CellPhoneNumberTextbox.Text = "";
            }
            else
            {
                MessageBox.Show("Fill in all the boxs.");
            }

        }


        private bool IsCreateMemberValid()
        {
            if (FirstNameTextBox.Text.Length == 0) { return false; }
            if (LastNameTextBox.Text.Length == 0) { return false; }
            if (EmailTextbox.Text.Length == 0) { return false; }
            if (CellPhoneNumberTextbox.Text.Length == 0) { return false; }

            return true;
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel model = (PersonModel)SelectTeamMemberComboBox.SelectedItem;

            if (model != null)
            {
                avilableTeamMember.Remove(model);
                selectedTeamMemeber.Add(model);

                WireUpLists();
            }

        }

        private void RemoveSelectedTeamMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel model = (PersonModel)TeamMemberListBox.SelectedItem;

            if (model != null)
            {
                selectedTeamMemeber.Remove(model);
                avilableTeamMember.Add(model);

                WireUpLists();
            }
        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {

            //TODO ---- Make message popup when name is only space.
            if(TeamNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter Team Name");
                return;
            }

            if(selectedTeamMemeber.Count == 0)
            {
                MessageBox.Show("Selected at least one Team member");
                return;
            }

            TeamModel team = new TeamModel();
            team.TeamName = TeamNameTextBox.Text;
            team.TeamMembers = selectedTeamMemeber;

            GlobalConfig.Connection.CreateTeam(team);
            calling.TeamComplete(team);
            this.Close();

        
            

        }
    }
}
