using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//test1234
namespace Audit_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close(); //Exit Program
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides Login Menu
            MainMenu MainMenu = new MainMenu(); //Create instance of Main Menu
            MainMenu.ShowDialog(); // Shows Main Menu
        }
    }
}
