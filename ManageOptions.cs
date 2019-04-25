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
    public partial class ManageOptions : Form
    {
        public ManageOptions()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides Login Menu
            Manage Manage = new Manage(); //Create instance of Manage
            Manage.ShowDialog(); // Shows Manage
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides Login Menu
            Manage Manage = new Manage(); //Create instance of Manage
            Manage.ShowDialog(); // Shows Manage
        }
    }
}
