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
    public partial class FormMoreVisitDetailsToManager : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");

        public FormMoreVisitDetailsToManager(string id, string appId,string visitorId, string fn,string ln, string nic,string purpose,string eId, string efn,string eln, string fromdate,string inTime,string todate, string outtime,string numOfDays,string place,string checkedin,string checkedout)
        {
            InitializeComponent();
            textBoxVisitId.Text = id;
            textBoxAppointmentId.Text = appId;
            textBoxVisitorId.Text = visitorId;
            textBoxFirstName.Text = fn;
            textBoxLastName.Text = ln;
            textBoxNicNumber.Text = nic;
            textBoxPurpose.Text = purpose;
            textBoxEmployeeId.Text = eId;
            textBoxEmployeeFirstName.Text = efn;
            textBoxEmployeeLastName.Text = eln;
            dateTimePickerFromDate.Text = fromdate;
            dateTimePickerFromTime.Text = inTime;
            dateTimePickerToDate.Text = todate;
            dateTimePickerToTime.Text = outtime;
            textBoxDaysStayed.Text = numOfDays;
            textBoxPlaceStayed.Text = place;
            checkBoxCheckedIn.Checked = Convert.ToBoolean(checkedin);
            checkBoxCheckedOut.Checked=Convert.ToBoolean(checkedout);
        }

        private void FormMoreVisitDetailsToManager_Load(object sender, EventArgs e)
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
