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
    public partial class FormVisitorRegisterFromSearchToEmployee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");
        private string id;
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


        public string PassValue
        {
            get { return id; }
            set { id = value; }
        }
    
        public FormVisitorRegisterFromSearchToEmployee()
        {
            InitializeComponent();
        }

        private void FormVisitorRegisterFromSearchToEmployee_Load(object sender, EventArgs e)
        {
            groupBoxAppointments.Enabled = false;
            maskedTextBoxNicNumber.Text = id;
            comboBoxStatus.SelectedIndex = 1;
            

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Visitor where NicNumber='" + maskedTextBoxNicNumber.Text + "'";

                Object VisitorExist = cmd.ExecuteScalar();
                SqlDataReader dr = cmd.ExecuteReader();

                if (VisitorExist != null)
                {                 
                    
                    while (dr.Read())
                    {
                        textBoxVisitorId.Text = dr["VisitorId"].ToString();
                        textBoxFirstName.Text = dr["FirstName"].ToString();
                        textBoxLastName.Text = dr["LastName"].ToString();
                        dateTimePickerDateOfBirth.Text = dr["DateOfBirth"].ToString();
                        comboBoxCategory.Text = dr["Category"].ToString();
                        textBoxOrganization.Text = dr["Organization"].ToString();
                        textBoxDesignation.Text = dr["Designation"].ToString();
                        comboBoxGender.Text = dr["Gender"].ToString();
                        textBoxPersonalAddress.Text = dr["PersonalAddress"].ToString();
                        textBoxCompanyAddress.Text = dr["CompanyAddress"].ToString();
                        textBoxWorkPhone.Text = dr["WorkPhone"].ToString();
                        textBoxMobile.Text = dr["Mobile"].ToString();
                        textBoxOther.Text = dr["Other"].ToString();
                        textBoxEmail.Text = dr["Email"].ToString();
                        //pictureBoxPhoto.Image = dr["Photo"].ToString();

                        
                    }
                }

                else
                {
                    MessageBox.Show("Visitor Not Found!");
                }
                    dr.Close();
                    

                    con.Close();
                
                //dateTimePickerFromDate.Focus();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            groupBoxAppointments.Enabled = true;
            GenerateAutoId();
            dateTimePickerFromDate.Focus();
        }

        private void buttonSaveAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Appointment(AppointmentId,FromDate,FromTime,Purpose,Approved,VisitorId,FirstName,LastName,NeedAccomodation,NeedVehicles,ToDate,ToTime) values('" + textBoxAppointmentId.Text + "','" + dateTimePickerFromDate.Text.ToString() + "','" + dateTimePickerFromTime.Text.ToString() + "','" + textBoxPurpose.Text + "','" + checkBoxCheckedIn.Checked + "','"+textBoxVisitorId.Text+"','" + textBoxEmployeeFirstName.Text + "','" + textBoxEmployeeLastName.Text + "','" + checkBoxNeedAccomodation.Checked + "','" + checkBoxNeedVehicles.Checked + "','" + dateTimePickerToDate.Text.ToString() + "','" + dateTimePickerToTime.Text.ToString() + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Saved!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRequestApproval_Click(object sender, EventArgs e)
        {
            try
            {
                //con.Open();
                //SqlCommand cmd = con.CreateCommand();
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "Insert into Appointment(AppointmentId,FromDate,FromTime,Purpose,Approved,VisitorId,FirstName,LastName,NeedAccomodation,NeedVehicles,ToDate,ToTime) values('" + textBoxAppointmentId.Text + "','" + dateTimePickerFromDate.Text.ToString() + "','" + dateTimePickerFromTime.Text.ToString() + "','" + textBoxPurpose.Text + "','" + checkBoxCheckedIn.Checked + "','" + textBoxVisitorId.Text + "','" + textBoxEmployeeFirstName.Text + "','" + textBoxEmployeeLastName.Text + "','" + checkBoxNeedAccomodation.Checked + "','" + checkBoxNeedVehicles.Checked + "','" + dateTimePickerToDate.Text.ToString() + "','" + dateTimePickerToTime.Text.ToString() + "')";
                //cmd.ExecuteNonQuery();
                //con.Close();

                //MessageBox.Show("Record Saved!");

                //below code for sending notification for mngmnt approval

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonConfirmVisit_Click(object sender, EventArgs e)
        {
            FormVisitConfirmation newconfirm = new FormVisitConfirmation();            
            newconfirm.Show();
        }

        private void buttonArrangeFacilities_Click(object sender, EventArgs e)
        {
            FormFacilitiesArrangement newfrm = new FormFacilitiesArrangement();
            newfrm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FormSearchVisitorToEmployee newSearch = new FormSearchVisitorToEmployee();
            newSearch.Close();
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

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
            checkBoxNeedVehicles.Checked = false;
            checkBoxNeedAccomodation.Checked = false;
            checkBoxCheckedIn.Checked = false;
            checkBoxCheckedOut.Checked = false;

            GenerateAutoId();
        }
    }
}
