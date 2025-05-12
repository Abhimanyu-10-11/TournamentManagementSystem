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
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI.Forms
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester calling;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();
            calling = caller;
        }
         

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {

            if(IsCreatePrizeValid())
            {
                PrizeModel prizeModel = new 
                    ( PlaceNumberTextBox.Text,
                    PlaceNameTextbox.Text,
                    PrizeAmountTextBox.Text,
                    PrizePercentageValueTextBox.Text);


               
                GlobalConfig.Connection.CreatePrize(prizeModel);

                calling.PrizeComplete(prizeModel);
                this.Close();


                //PlaceNumberTextBox.Text = "";
                //PlaceNameTextbox.Text = "";
                //PrizeAmountTextBox.Text = "0";
                //PrizePercentageValueTextBox.Text = "0";

            }
            else
            {
                MessageBox.Show("Invalid inputs for creating Prize");
            }

        }


        private bool IsCreatePrizeValid()
        {
            bool validity = true;

            int placeNumber = 0;
            bool isPlaceNumberValid = int.TryParse(PlaceNumberTextBox.Text, out placeNumber);

            if (!isPlaceNumberValid)
            {
                validity = false;
            }

            if (placeNumber <= 0)
            {
                validity = false;
            }

            if(PlaceNameTextbox.Text.Length == 0)
            {
                validity = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool validPrizeAmount = decimal.TryParse(PrizeAmountTextBox.Text,
                out prizeAmount);

            bool validPrizePercentage = double.TryParse(PrizePercentageValueTextBox.Text,
                out prizePercentage);

            if (!validPrizeAmount || !validPrizePercentage)
            {
                validity = false;
            }

            if(prizeAmount<1 && prizePercentage<1)
            {
                validity = false;
            }

            

            if(prizePercentage<0 || prizePercentage > 100)
            {
                validity = false;
            }

            return validity;

        }
    }
}
