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
    public partial class FormAppointmentsToManager : Form
    {
        public FormAppointmentsToManager()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormAppointmentsToManager_Load(object sender, EventArgs e)
        {
            comboBoxSelectAppointments.SelectedIndex = 0;
        }

        private void buttonAddNewAppointment_Click(object sender, EventArgs e)
        {
            FormAddNewAppointmentToManager newAdd = new FormAddNewAppointmentToManager();
            newAdd.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMoreDetails_Click(object sender, EventArgs e)
        {
            FormMoreAppointmentDetailsToManager more = new FormMoreAppointmentDetailsToManager();
            more.Show();
        }
    }
}
