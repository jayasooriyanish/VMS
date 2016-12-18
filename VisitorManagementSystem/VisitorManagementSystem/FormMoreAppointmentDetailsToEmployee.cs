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
    public partial class FormMoreAppointmentDetailsToEmployee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");
        String AId = "SILAPP0";

        private void GenerateAutoId()
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select Count(appointmentId) from Appointment", con);
            int i = Convert.ToInt32(cmd1.ExecuteScalar());
            con.Close();
            i++;
            textBoxAppointmentId.Text = AId + i.ToString();
        }


        public FormMoreAppointmentDetailsToEmployee(string appId, string fromDate, string toDate, string fromTime, string toTime, string purpose, string eId, string eFName, string eLName, string status, string checkedIn, string checkedOut, string visitorId, string vehicles, string accomodation)
        {
            InitializeComponent();

            textBoxAppointmentId.Text = appId;
            dateTimePickerFromDate.Text = fromDate;
            dateTimePickerToDate.Text = toDate;
            dateTimePickerFromTime.Text = fromTime;
            dateTimePickerToTime.Text = toTime;
            textBoxPurpose.Text = purpose;
            textBoxEmployeeId.Text = eId;
            textBoxEmployeeFirstName.Text = eFName;
            textBoxEmployeeLastName.Text = eLName;            
            comboBoxStatus.Text = status;
            if (accomodation == null || accomodation.Equals(""))
            {
                checkBoxNeedAccomodation.Checked = false;
            }
            else
            {
                checkBoxNeedAccomodation.Checked = Convert.ToBoolean(accomodation);
            }

            if (vehicles == null || vehicles.Equals(""))
            {
                checkBoxNeedVehicles.Checked = false;
            }
            else
            {
                checkBoxNeedVehicles.Checked = Convert.ToBoolean(vehicles);
            }
            if (checkedIn == null || checkedIn.Equals(""))
            {
                checkBoxCheckedIn.Checked = false;
            }
            else
            {
                checkBoxCheckedIn.Checked = Convert.ToBoolean(checkedIn);
            }
            if (checkedOut == null || checkedOut.Equals(""))
            {
                checkBoxCheckedOut.Checked = false;
            }
            else
            {
                checkBoxCheckedOut.Checked = Convert.ToBoolean(checkedOut);
            }

            
            textBoxVisitorId.Text = visitorId;
            
        }

        private void FormMoreAppointmentDetailsToEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Visitor where VisitorId='" + textBoxVisitorId.Text + "'";
                //cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBoxFirstName.Text = dr["FirstName"].ToString();
                    textBoxLastName.Text = dr["LastName"].ToString();
                    textBoxNicNumber.Text = dr["NicNumber"].ToString();
                    dateTimePickerDateOfBirth.Text = dr["DateOfBirth"].ToString();
                    textBoxOrganization.Text = dr["Organization"].ToString();
                    textBoxDesignation.Text = dr["Designation"].ToString();
                    textBoxGender.Text = dr["Gender"].ToString();
                    textBoxPersonalAddress.Text = dr["PersonalAddress"].ToString();
                    textBoxCompanyAddress.Text = dr["CompanyAddress"].ToString();
                    textBoxWorkPhone.Text = dr["WorkPhone"].ToString();
                    textBoxMobile.Text = dr["Mobile"].ToString();
                    textBoxOther.Text = dr["Other"].ToString();
                    textBoxEmail.Text = dr["Email"].ToString();
                    //pictureBoxPhoto.Image =;

                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();

            }

        }

        private void buttonAddNewAppointment_Click(object sender, EventArgs e)
        {
            GenerateAutoId();
            dateTimePickerFromDate.Value = DateTime.Now;
            dateTimePickerToDate.Value = DateTime.Now;
            dateTimePickerFromTime.Value = DateTime.Now;
            dateTimePickerToTime.Value = DateTime.Now;
            textBoxPurpose.Clear();
            textBoxEmployeeId.Clear();
            textBoxEmployeeFirstName.Clear();
            textBoxEmployeeLastName.Clear();
            dateTimePickerFromDate.Focus();
            comboBoxStatus.SelectedIndex = 1;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Appointment(AppointmentId,FromDate,FromTime,Purpose,VisitorId,VisitorFirstName,VisitorLastName,EmployeeId,FirstName,LastName,NeedAccomodation,NeedVehicles,ToDate,ToTime,Status) values('" + textBoxAppointmentId.Text + "','" + dateTimePickerFromDate.Text.ToString() + "','" + dateTimePickerFromTime.Text.ToString() + "','" + textBoxPurpose.Text + "','" + textBoxVisitorId.Text + "','" + textBoxFirstName.Text + "','" + textBoxLastName.Text + "','" + textBoxEmployeeId.Text + "','" + textBoxEmployeeFirstName.Text + "','" + textBoxEmployeeLastName.Text + "','" + checkBoxNeedAccomodation.Checked + "','" + checkBoxNeedVehicles.Checked + "','" + dateTimePickerToDate.Text.ToString() + "','" + dateTimePickerToTime.Text.ToString() + "','" + comboBoxStatus.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Saved!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxEmployeeId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Employee where EmployeeId='" + textBoxEmployeeId.Text + "'";
                //cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBoxEmployeeFirstName.Text = dr["FirstName"].ToString();
                    textBoxEmployeeLastName.Text = dr["LastName"].ToString();
                }
                dr.Close();

                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
