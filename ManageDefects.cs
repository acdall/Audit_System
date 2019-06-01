using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Audit_System
{
    public partial class ManageDefects : Form
    {
        public ManageDefects()
        {
            InitializeComponent();
        }
        public string DefectLabel
        {
            set { titleLabel.Text = value; }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //verification/validation

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
    }
}
