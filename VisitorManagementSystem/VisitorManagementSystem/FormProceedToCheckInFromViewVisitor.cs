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
    public partial class FormProceedToCheckInFromViewVisitor : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");
        String VId = "VI0";

        private void GenerateAutoId()
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select Count(visitId) from Visit", con);
            int i = Convert.ToInt32(cmd1.ExecuteScalar());
            con.Close();
            i++;
            textBoxVisitId.Text = VId + i.ToString();
        }


        public FormProceedToCheckInFromViewVisitor(string appId, string visitorId, string empId, string empFName, string empLName, string purpose)
        {
            InitializeComponent();
            textBoxAppointmentId.Text = appId;
            textBoxVisitorId.Text = visitorId;
            textBoxEmployeeId.Text = empId;
            textBoxEmployeeFirstName.Text = empFName;
            textBoxEmployeeLastName.Text = empLName;
            textBoxPurpose.Text = purpose;
        }

        private void FormProceedToCheckInFromViewVisitor_Load(object sender, EventArgs e)
        {
            GenerateAutoId();
            groupBoxResponsibleEmployee.Enabled = false;
            textBoxPurpose.Enabled = false;
            groupBoxVisitorPass.Enabled = false;
            textBoxAppointmentId.Enabled = false;
            textBoxVisitorId.Enabled = false;
            textBoxVisitId.Enabled = false;
            

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
                    textBoxOrganization.Text = dr["Organization"].ToString();
                    textBoxDesignation.Text = dr["Designation"].ToString();
                    textBoxNicNumber.Text = dr["NicNumber"].ToString();
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

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            dateTimePickerInTime.Value = DateTime.Now;            
            dateTimePickerInDate.Value = DateTime.Now;
            checkBoxCheckedIn.Checked = true;

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Visit(VisitId,AppointmentId,VisitorId,FirstName,LastName,NicNumber,Purpose,EmployeeId,EmployeeFirstName,EmployeeLastName,FromDate,InTime,Todate,OutTime,NoOfDaysStayed,PlaceStayed,CheckedIn,CheckedOut) values('"+textBoxVisitId.Text+"','"+textBoxAppointmentId.Text+"','"+textBoxVisitorId.Text+"','"+textBoxFirstName.Text+"','"+textBoxLastName.Text+"','"+textBoxNicNumber.Text+"','"+textBoxPurpose.Text+"','"+textBoxEmployeeId.Text+"','"+textBoxEmployeeFirstName.Text+"','"+textBoxEmployeeLastName.Text+"','"+dateTimePickerInDate.Text.ToString()+"','"+dateTimePickerInTime.Text.ToString()+"','"+dateTimePickerOutDate.Text.ToString()+"','"+dateTimePickerOutTime.Text.ToString()+"','"+textBoxDaysStayed.Text+"','"+textBoxPlaceStayed.Text+"','"+checkBoxCheckedIn.Checked+"','"+checkBoxcheckedOut.Checked+"')";
                cmd.ExecuteNonQuery();
                con.Close();

               // MessageBox.Show("Record Saved!");

                //code to print


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void checkBoxheckedOut_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerOutDate.Value = DateTime.Now;
            dateTimePickerOutTime.Value = DateTime.Now;

            TimeSpan tspan = dateTimePickerOutDate.Value - dateTimePickerOutTime.Value;

            int differenceInDays = tspan.Days;

            string differenceAsString = differenceInDays.ToString();

            textBoxDaysStayed.Text = differenceAsString;

            textBoxDaysStayed.Enabled = false;
            textBoxPlaceStayed.Enabled = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
