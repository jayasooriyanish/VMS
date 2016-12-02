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
    public partial class FormMoreAppointmentDetailsToManager : Form
    {
        public FormMoreAppointmentDetailsToManager()
        {
            InitializeComponent();
        }

        private void buttonAddNewAppointment_Click(object sender, EventArgs e)
        {
            //Auto increment Appointment Id by 1
            dateTimePickerFromDate.Value = DateTime.Now;
            dateTimePickerToDate.Value = DateTime.Now;
            dateTimePickerFromTime.Value = DateTime.Now;
            dateTimePickerToTime.Value = DateTime.Now;
            textBoxPurpose.Clear();
            textBoxEmployeeId.Clear();
            textBoxEmployeeName.Clear();
            dateTimePickerFromDate.Focus();

        }
    }
}
