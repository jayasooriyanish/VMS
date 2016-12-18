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
    public partial class FormVisitsAndAppointmentsToSecurity : Form
    {
        public FormVisitsAndAppointmentsToSecurity()
        {
            InitializeComponent();
        }

        private void buttonAppointments_Click(object sender, EventArgs e)
        {
            FormViewAppointmentsToSecurity view = new FormViewAppointmentsToSecurity();
            view.Show();
        }
    }
}
