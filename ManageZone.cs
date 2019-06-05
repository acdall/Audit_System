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
    public partial class ManageZone : Form
    {
        public ManageZone()
        {
            InitializeComponent();
        }
        public string ZoneLabel
        {
            set { titleLabel.Text = value; }
        }
        private void ManageZone_Load(object sender, EventArgs e)
        {
            //get model + Product info from database
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrWhiteSpace(nameTextBox.Text))
                {
                    MessageBox.Show("Please Enter a Valid Zone Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.Match(nameTextBox.Text, "^[a-zA-Z]*$").Success)
                {
                    MessageBox.Show("Invalid Zone Name: A Zone name cannot contain numbers or special characters", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nameTextBox.Focus();
                }
            }
            catch
            {

            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //if -- changes are made, save button needs to be clicked!!.Yes) //User answer selection 
                {

                DialogResult answer = MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo); //Warning 
                if (answer == DialogResult)
                    Application.Exit(); //Terminate because user selected yes
                }
            }
            catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);

            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Your changes have not been submitted. Are you sure you want to leave?", "Warning", MessageBoxButtons.YesNo); //Warning 
                if (answer == DialogResult.Yes) //User answer selection 
                {
                    this.Hide(); //Hides Menu
                    ManageOptions zoneOption = new ManageOptions(); //Create instance ManageOptions
                    zoneOption.Name = "Manage Zones"; //Changes the label in the ManageOptions form
                    zoneOption.ShowDialog(); // Shows ManageOptions
                }
            }
            catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);
            }
        }
    }
}
