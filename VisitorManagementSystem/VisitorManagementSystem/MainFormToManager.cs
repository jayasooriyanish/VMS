using System;
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
    public partial class MainFormToManager : Form
    {
        public MainFormToManager()
        {
            InitializeComponent();
        }

        private void buttonVisitor_Click(object sender, EventArgs e)
        {
            VisitorFormToManager newfrm = new VisitorFormToManager();
            newfrm.Show();
        }

        private void buttonVisits_Click(object sender, EventArgs e)
        {
            FormVisitsAndAppointmentsToManager newfrmvisit = new FormVisitsAndAppointmentsToManager();
            newfrmvisit.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do You Want to Exit?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
