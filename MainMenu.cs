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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides Login Menu
            ViewReports Audits = new ViewReports(); //Create instance of Audits
            Audits.ShowDialog(); // Shows Audits
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides Login Menu
            NewAudit NewAudit = new NewAudit(); //Create instance of New Audit
            NewAudit.ShowDialog(); // Shows New Audit
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides Login Menu
            Manage Manage = new Manage(); //Create instance of Manage
            Manage.ShowDialog(); // Shows Manage
        }
    }
}
