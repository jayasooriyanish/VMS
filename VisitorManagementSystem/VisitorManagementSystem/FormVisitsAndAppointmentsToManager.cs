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
    public partial class FormVisitsAndAppointmentsToManager : Form
    {
        public FormVisitsAndAppointmentsToManager()
        {
            InitializeComponent();
        }

        private void buttonAppointments_Click(object sender, EventArgs e)
        {
            FormAppointmentsToManager newApp = new FormAppointmentsToManager();
            newApp.Show();
        }

        private void buttonVisitList_Click(object sender, EventArgs e)
        {
            FormVisitListToManager visitList = new FormVisitListToManager();
            visitList.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
