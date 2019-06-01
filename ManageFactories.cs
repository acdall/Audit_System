using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Audit_System
{
    public partial class ManageFactories : Form
    {
        public ManageFactories()
        {
            InitializeComponent();
        }
        public string FactoryLabel
        {
            set { titleLabel.Text = value; }
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {

                //Validates whitespace or null inputs: 
                if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrWhiteSpace(nameTextBox.Text))
                {
                    MessageBox.Show("Please Enter a Valid Factory Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(addressTextBox.Text) || string.IsNullOrWhiteSpace(addressTextBox.Text))
                {
                    MessageBox.Show("Please Enter an Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(cityTextBox.Text) || string.IsNullOrWhiteSpace(cityTextBox.Text))
                {
                    MessageBox.Show("Please Enter a City.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(stateTextBox.Text) || string.IsNullOrWhiteSpace(stateTextBox.Text))
                {
                    MessageBox.Show("Please Enter a State.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(zipTextBox.Text) || string.IsNullOrWhiteSpace(zipTextBox.Text))
                {
                    MessageBox.Show("Please Enter a Valid Zip Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(countryLabel.Text) || string.IsNullOrWhiteSpace(countryTextBox.Text))
                {
                    MessageBox.Show("Please Enter a Valid Country Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Validates User Input Using Regex: 
                else if (!Regex.Match(nameTextBox.Text, "^[a-zA-Z]*$").Success)
                {
                    MessageBox.Show("Invalid factory name: A factory name cannot contain numbers or special characters", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nameTextBox.Focus();
                }
                else if (!Regex.Match(addressTextBox.Text, @"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
                { 
                    MessageBox.Show("Invalid address", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    addressTextBox.Focus();
                }
                else  if (!Regex.Match(cityTextBox.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
                {
                    MessageBox.Show("Invalid city", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cityTextBox.Focus();
                }
                else if (!Regex.Match(stateTextBox.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
                {
                    MessageBox.Show("Invalid state", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    stateTextBox.Focus();
                }   
                else if (!Regex.Match(zipTextBox.Text, @"^\d{5}$").Success)
                {
                    MessageBox.Show("Invalid zip code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    zipTextBox.Focus();
                }
                else if (!Regex.Match(countryTextBox.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
                {
                    MessageBox.Show("Invalid Country", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    countryTextBox.Focus();
                }
                //Submit new changes to database


            }
            catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);

            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //if -- changes are made, save button needs to be clicked!!

                DialogResult answer = MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo); //Warning 
                if (answer == DialogResult.Yes) //User answer selection 
                {
                    Application.Exit(); //Terminate because user selected yes
                }
            }
            catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);

            }
        }



        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Your changes have not been submitted. Are you sure you want to leave?", "Exit?", MessageBoxButtons.YesNo); //Warning 
                if (answer == DialogResult.Yes) //User answer selection 
                {
                    this.Hide(); //Hides Menu
                    ManageOptions factoryOption = new ManageOptions(); //Create instance ManageOptions
                    factoryOption.Name = "Manage Factories"; //Changes the label in the ManageOptions form
                    factoryOption.ShowDialog(); // Shows ManageOptions           }
                }
            }
            catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);

            }
        }
    }
}
