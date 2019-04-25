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
    public partial class NewAudit : Form
    {
        public NewAudit()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides Menu
            MainMenu MainMenu = new MainMenu(); //Create instance of Main Menu
            MainMenu.ShowDialog(); // Shows Main Menu
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides Menu
            AuditReport AuditReport = new AuditReport(); //Create instance of AuditReport
            AuditReport.ShowDialog(); // Shows AuditReport
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides Menu
            ScoreCard ScoreCard = new ScoreCard(); //Create instance of ScoreCard
            ScoreCard.ShowDialog(); // Shows ScoreCard
        }
    }
}
