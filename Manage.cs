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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides Menu
            MainMenu MainMenu = new MainMenu(); //Create instance of Main Menu
            MainMenu.ShowDialog(); // Shows Main Menu
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides Menu
            ManageOptions ManageOptions = new ManageOptions(); //Create instance ManageOptions
            ManageOptions.ShowDialog(); // Shows ManageOptions
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides Menu
            ManageOptions ManageOptions = new ManageOptions(); //Create instance ManageOptions
            ManageOptions.ShowDialog(); // Shows ManageOptions
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides Menu
            ManageOptions ManageOptions = new ManageOptions(); //Create instance ManageOptions
            ManageOptions.ShowDialog(); // Shows ManageOptions
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides Menu
            ManageOptions ManageOptions = new ManageOptions(); //Create instance ManageOptions
            ManageOptions.ShowDialog(); // Shows ManageOptions
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
