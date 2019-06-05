﻿using System;
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
    public partial class ManageLines : Form
    {
        public ManageLines()
        {
            InitializeComponent();
        }
        public string LineLabel
        {
            set { titleLabel.Text = value; }
        }
        //******GET FACTORY INFO FROM DATABASE



        private void BackButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Your changes have not been submitted. Are you sure you want to leave?", "Warning", MessageBoxButtons.YesNo); //Warning 
                if (answer == DialogResult.Yes) //User answer selection 
                {
                    this.Hide(); //Hides Menu
                    ManageOptions linesOption = new ManageOptions(); //Create instance ManageOptions
                    linesOption.Name = "Manage Lines"; //Changes the label in the ManageOptions form
                    linesOption.ShowDialog(); // Shows ManageOptions
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

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrWhiteSpace(nameTextBox.Text))
                {
                    MessageBox.Show("Please Enter a Valid Line Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.Match(nameTextBox.Text, "^[a-zA-Z]*$").Success)
                {
                    MessageBox.Show("Invalid Line Name: A line name cannot contain numbers or special characters", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nameTextBox.Focus();
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
    }
}
