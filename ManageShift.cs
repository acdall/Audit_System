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
    public partial class manageShiftForm : Form
    {
        public manageShiftForm()
        {
            InitializeComponent();
            //get all factories 
            //get all lines 

        }
        public string ShiftLabel
        {
            set { titleLabel.Text = value; }
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan timeOne = TimeSpan.Parse(startComboBox.Text);
                TimeSpan timeTwo = TimeSpan.Parse(endComboBox.Text);
                if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrWhiteSpace(nameTextBox.Text))
                {
                    MessageBox.Show("Please Enter a Valid Shift Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.Match(nameTextBox.Text, "^[a-zA-Z]*$").Success)
                {
                    MessageBox.Show("Invalid Shift Name: A shift name cannot contain numbers or special characters", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nameTextBox.Focus();
                }
                else if (timeOne.CompareTo(timeTwo) == 1)
                {
                    MessageBox.Show("The Start Time Must be Before the End Time.", "Time Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (timeOne.CompareTo(timeTwo) == 0)
                {
                    MessageBox.Show("The Start Time and End Time Cannot Be the Same.", "Time Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //enter into database
                }
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Your changes have not been submitted. Are you sure you want to leave?", "Warning", MessageBoxButtons.YesNo); //Warning 
                if (answer == DialogResult.Yes) //User answer selection 
                {
                    this.Hide(); //Hides Menu
                    ManageOptions shiftsOption = new ManageOptions(); //Create instance ManageOptions
                    shiftsOption.Name = "Manage Shifts"; //Changes the label in the ManageOptions form
                    shiftsOption.ShowDialog(); // Shows ManageOptions
                }
            }
            catch
            {
                MessageBox.Show("An error has occured, the program will be terminated", "Warning", MessageBoxButtons.OK);
            }
        }
    }
}
