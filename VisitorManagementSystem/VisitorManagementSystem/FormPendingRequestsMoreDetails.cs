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
    public partial class FormPendingRequestsMoreDetails : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");
        
        int[] barCode;

               
        public FormPendingRequestsMoreDetails(string appId, string fromDate, string toDate, string fromTime, string toTime, string purpose, string eId, string eFName, string eLName, string status, string checkedIn, string checkedOut, string visitorId, string accomodation, string vehicles)
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
            textBoxVisitorId.Text = visitorId;
            comboBoxStatus.Text = status;
            //checkBoxNeedAccomodation.Text = accomodation;
            //checkBoxNeedVehicles.Text = vehicles;
            //checkBoxCheckedIn.Text = checkedIn;
            //checkBoxCheckedOut.Text = checkedOut;
        }

        private void FormPendingRequestsForApproval_Load(object sender, EventArgs e)
        {
            barCode = new int[5]{0,0,0,0,0};

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
                    textBoxCategory.Text = dr["Category"].ToString();
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

        private void checkBoxArea1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == true)
            {
                barCode[0] = 1;
            }
            else
            {
                barCode[0] = 0;
            }
        }

        private void checkBoxArea2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == true)
            {
                barCode[1] = 1;
            }
            else
            {
                barCode[1] = 0;
            }

        }

        private void checkBoxArea3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == true)
            {
                barCode[2] = 1;
            }
            else
            {
                barCode[2] = 0;
            }

        }

        private void checkBoxArea4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == true)
            {
                barCode[3] = 1;
            }
            else
            {
                barCode[3] = 0;
            }
        }

        private void checkBoxArea5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == true)
            {
                barCode[4] = 1;
            }
            else
            {
                barCode[4] = 0;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string barCodeString = string.Join("", barCode); ;
            Console.Write(barCodeString);
        }

        private void buttonApproveAppointment_Click(object sender, EventArgs e)
        {
            comboBoxStatus.SelectedIndex = 1;
            //update status in db as approved
        }

        private void buttonBlockAppointment_Click(object sender, EventArgs e)
        {
            comboBoxStatus.SelectedIndex = 2;
        }
    }
}
