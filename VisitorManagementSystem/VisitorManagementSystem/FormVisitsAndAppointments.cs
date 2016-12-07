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
    public partial class FormVisitsAndAppointments : Form
    {
        public FormVisitsAndAppointments()
        {
            InitializeComponent();
        }

        private void FormVisitsAndAppointments_Load(object sender, EventArgs e)
        {

        }

        private void buttonAppointments_Click(object sender, EventArgs e)
        {
          FormViewAppointmentsToEmployee appointments = new FormViewAppointmentsToEmployee();
            appointments.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
