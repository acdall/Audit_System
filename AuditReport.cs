﻿using System;
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
    public partial class AuditReport : Form
    {
        public AuditReport()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides Menu
            NewAudit NewAudit = new NewAudit(); //Create instance of New Audit
            NewAudit.ShowDialog(); // Shows New Audit
        }
    }
}
