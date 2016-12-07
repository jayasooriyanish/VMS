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
    public partial class AppointmentsForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");
        private string id;
        //string appointmentId;
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

        public AppointmentsForm()
        {
            InitializeComponent();
        }

        private void AppointmentsForm_Load(object sender, EventArgs e)
        {
            GenerateAutoId();
            groupBoxAppointmentDetails.Enabled = false;
            //buttonConfirmVisit.Enabled = false;
            buttonArrangeFacilities.Enabled = false;
            buttonRequestApproval.Enabled = false;

            textBoxVisitorId.Text = id;
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText ="select * from Visitor where VisitorId='"+textBoxVisitorId.Text+"'";
                //cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBoxFirstName.Text = dr["FirstName"].ToString();
                    textBoxLastName.Text = dr["LastName"].ToString();
                    maskedTextBoxNicNumber.Text = dr["NicNumber"].ToString();
                    dateTimePickerDateOfBirth.Text = dr["DateOfBirth"].ToString();
                    textBoxCategory.Text = dr["Category"].ToString();
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
                dateTimePickerFromDate.Focus();

            }
            catch(Exception ex) 
            {
                
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonArrangeFacilities_Click(object sender, EventArgs e)
        {
            FormFacilitiesArrangement newfacilitiesform = new FormFacilitiesArrangement();
            newfacilitiesform.ShowDialog();
        }

        private void buttonConfirmVisit_Click(object sender, EventArgs e)
        {
            FormVisitConfirmation newConfirmationForm = new FormVisitConfirmation();
            newConfirmationForm.PassEmail = textBoxEmail.Text;
            newConfirmationForm.Show();
        }

        private void buttonCAncelVisit_Click(object sender, EventArgs e)
        {
            FormVisitConfirmation newConfirmationForm = new FormVisitConfirmation();
            newConfirmationForm.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Appointment(AppointmentId,FromDate,FromTime,Purpose,VisitorId,VisitorFirstName,VisitorLastName,EmployeeId,FirstName,LastName,NeedAccomodation,NeedVehicles,ToDate,ToTime,Status) values('" + textBoxAppointmentId.Text + "','" + dateTimePickerFromDate.Text.ToString() + "','" + dateTimePickerFromTime.Text.ToString() + "','" + textBoxPurpose.Text + "','" + textBoxVisitorId.Text + "','"+textBoxFirstName.Text+"','"+textBoxLastName.Text+"','"+textBoxEmployeeId.Text+"','" + textBoxEmployeeFirstName.Text + "','" + textBoxEmployeeLastName.Text + "','" + checkBoxNeedAccomodation.Checked + "','" + checkBoxNeedVehicles.Checked + "','" + dateTimePickerToDate.Text.ToString() + "','" + dateTimePickerToTime.Text.ToString() + "','"+comboBoxStatus.Text+"')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Saved!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddAppointments_Click(object sender, EventArgs e)
        {
            groupBoxAppointmentDetails.Enabled = true;
            GenerateAutoId();
            buttonRequestApproval.Enabled = true;
            dateTimePickerFromDate.Focus();
            comboBoxStatus.SelectedIndex = 1;
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxPurpose.Clear();
            textBoxEmployeeId.Clear();
            textBoxEmployeeFirstName.Clear();
            textBoxEmployeeLastName.Clear();
            dateTimePickerFromDate.Value = DateTime.Now;
            dateTimePickerToDate.Value = DateTime.Now;
            dateTimePickerFromTime.Value = DateTime.Now;
            dateTimePickerToTime.Value = DateTime.Now;
            checkBoxNeedVehicles.Checked = false;
            checkBoxNeedAccomodation.Checked = false;
            checkBoxCheckedIn.Checked = false;
            checkBoxCheckedOut.Checked = false;
            

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxEmployeeId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText ="select * from Employee where EmployeeId='"+textBoxEmployeeId.Text+"'";
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

        //public string ImageToBase64(Image image,
        //                    System.Drawing.Imaging.ImageFormat format)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        // Convert Image to byte[]
        //        image.Save(ms, format);
        //        byte[] imageBytes = ms.ToArray();

        //        // Convert byte[] to Base64 String
        //        string base64String = Convert.ToBase64String(imageBytes);
        //        return base64String;
        //    }
        //}
    }
}
