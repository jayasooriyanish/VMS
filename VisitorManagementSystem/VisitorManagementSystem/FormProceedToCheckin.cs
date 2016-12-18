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
    public partial class FormProceedToCheckin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");
        private string id;
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


        public string PassValue
        {
            get { return id; }
            set { id = value; }
        }

        public FormProceedToCheckin()
        {
            InitializeComponent();
        }

        private void FormProceedToCheckin_Load(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrDrawer = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            
            try
            {
                textBoxVisitorId.Text = id;
                GenerateAutoId();
                groupBoxResponsibleEmployee.Enabled = false;
                textBoxPurpose.Enabled = false;
                groupBoxVisitorPass.Enabled = false;
                textBoxAppointmentId.Enabled = false;
                textBoxVisitorId.Enabled = false;
                textBoxVisitId.Enabled = false;
                


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
                    textBoxOrganization.Text = dr["Organization"].ToString();
                    textBoxDesignation.Text = dr["Designation"].ToString();
                    //pictureBoxBarCode.Image = qrDrawer.Draw(dr["Barcode"].ToString(), pictureBoxBarCode.Height);
                }
                dr.Close();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                con.Open();
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select * from Appointment where VisitorId='" + textBoxVisitorId.Text + "'";
                //cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd2.ExecuteReader();
                while (dr.Read())
                {
                    textBoxAppointmentId.Text = dr["AppointmentId"].ToString();
                    textBoxEmployeeId.Text = dr["EmployeeId"].ToString();
                    textBoxEmployeeFirstName.Text = dr["FirstName"].ToString();
                    textBoxEmployeeLastName.Text = dr["LastName"].ToString();
                    textBoxPurpose.Text = dr["Purpose"].ToString(); 
                   
                }
                dr.Close();

                con.Close();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }

            dateTimePickerInDate.Focus();


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                cmd.CommandText = "Insert into Visit(VisitId,AppointmentId,VisitorId,FirstName,LastName,NicNumber,Purpose,EmployeeId,EmployeeFirstName,EmployeeLastName,FromDate,InTime,Todate,OutTime,NoOfDaysStayed,PlaceStayed,CheckedIn,CheckedOut) values('" + textBoxVisitId.Text + "','" + textBoxAppointmentId.Text + "','" + textBoxVisitorId.Text + "','" + textBoxFirstName.Text + "','" + textBoxLastName.Text + "','" + textBoxNicNumber.Text + "','" + textBoxPurpose.Text + "','" + textBoxEmployeeId.Text + "','" + textBoxEmployeeFirstName.Text + "','" + textBoxEmployeeLastName.Text + "','" + dateTimePickerInDate.Text.ToString() + "','" + dateTimePickerInTime.Text.ToString() + "','" + dateTimePickerOutDate.Text.ToString() + "','" + dateTimePickerOutTime.Text.ToString() + "','" + textBoxDaysStayed.Text + "','" + textBoxPlaceStayed.Text + "','" + checkBoxCheckedIn.Checked + "','" + checkBoxheckedOut.Checked + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                // MessageBox.Show("Record Saved!");



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
    }
}
