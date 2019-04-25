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
    public partial class ScoreCard : Form
    {
        public ScoreCard()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides Login Menu
            NewAudit NewAudit = new NewAudit(); //Create instance of New Audit
            NewAudit.ShowDialog(); // Shows New Audit
        }
    }
}
