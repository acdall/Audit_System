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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides Login Menu
            MainMenu MainMenu = new MainMenu(); //Create instance of Main Menu
            MainMenu.ShowDialog(); // Shows Main Menu
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides Login Menu
            MainMenu MainMenu = new MainMenu(); //Create instance of Main Menu
            MainMenu.ShowDialog(); // Shows Main Menu
        }
    }
}
