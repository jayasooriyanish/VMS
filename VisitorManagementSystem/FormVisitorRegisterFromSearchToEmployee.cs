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

                        textBoxVisitorId.Focus();

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
            dateTimePickerFromDate.Focus();
        }

        private void buttonSaveAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Appointment(AppointmentId,FromDate,FromTime,Purpose,Approved,VisitorId,FirstName,LastName,NeedAccomodation,NeedVehicles,ToDate,ToTime) values('" + textBoxAppointmentId.Text + "','" + dateTimePickerFromDate.Text.ToString() + "','" + dateTimePickerFromTime.Text.ToString() + "','" + textBoxPurpose.Text + "','" + checkBoxApproved.Checked + "','"+textBoxVisitorId.Text+"','" + textBoxEmployeeFirstName.Text + "','" + textBoxEmployeeLastName.Text + "','" + checkBoxNeedAccomodation.Checked + "','" + checkBoxNeedVehicles.Checked + "','" + dateTimePickerToDate.Text.ToString() + "','" + dateTimePickerToTime.Text.ToString() + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Saved!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
