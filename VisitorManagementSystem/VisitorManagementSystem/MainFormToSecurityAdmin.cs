﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisitorManagementSystem
{
    public partial class MainFormToSecurityAdmin : Form
    {
        public MainFormToSecurityAdmin()
        {
            InitializeComponent();
        }

        private void buttonVisitor_Click(object sender, EventArgs e)
        {
            VisitorFormToSecurity newfrm = new VisitorFormToSecurity();
            newfrm.ShowDialog();
        }

        private void buttonVisits_Click(object sender, EventArgs e)
        {
            FormVisitsAndAppointmentsToSecurity frm = new FormVisitsAndAppointmentsToSecurity();
            frm.Show();
        }
    }
}
