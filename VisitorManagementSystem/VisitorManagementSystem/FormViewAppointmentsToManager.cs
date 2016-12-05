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
    public partial class FormViewAppointmentsToManager : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");

        public FormViewAppointmentsToManager()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //DataTable dt = new DataTable();
        private void comboBoxSelectAppointments_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataView dv = dt.DefaultView;
            //dv.RowFilter = string.Format("");
 
        }

        private void FormAppointmentsToManager_Load(object sender, EventArgs e)
        {
            comboBoxSelectAppointments.SelectedIndex = 0;

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from  Appointment";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewAppointmentsToManager.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void buttonAddNewAppointment_Click(object sender, EventArgs e)
        {
            FormAddNewAppointmentToManager newAdd = new FormAddNewAppointmentToManager();
            newAdd.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMoreDetails_Click(object sender, EventArgs e)
        {
            FormMoreAppointmentDetailsToManager more = new FormMoreAppointmentDetailsToManager();
            more.Show();
        }
    }
}
