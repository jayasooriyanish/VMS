using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VisitorManagementSystem
{
    public partial class FormAddNewAppointmentToManager : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");
        private string id;



        public string PassValue
        {
            get { return id; }
            set { id = value; }
        }

        public FormAddNewAppointmentToManager()
        {
            InitializeComponent();
        }

        private void FormAddNewAppointmentToManager_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            checkBoxApproved.Checked = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            dateTimePickerFromDate.Value = DateTime.Now;
            dateTimePickerToDate.Value = DateTime.Now;
            dateTimePickerFromTime.Value = DateTime.Now;
            dateTimePickerToTime.Value = DateTime.Now;
            textBoxPurpose.Clear();
            textBoxEmployeeId.Clear();
            textBoxEmployeeFirstName.Clear();
            textBoxEmployeeLastName.Clear();
            checkBoxNeedAccomodation.Checked = false;
            checkBoxNeedVehicles.Checked = false;
            checkBoxCheckedIn.Checked = false;
            checkBoxCheckedOut.Checked = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonArrangeFacilities_Click(object sender, EventArgs e)
        {
            FormFacilitiesArrangementToManager arr = new FormFacilitiesArrangementToManager();
            arr.Show();
        }

        private void buttonConfirmVisit_Click(object sender, EventArgs e)
        {
            FormVisitConfirmationToManager confirm = new FormVisitConfirmationToManager();
            confirm.Show();
        }
    }
}
