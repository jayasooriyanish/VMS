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
    public partial class FormViewAppointmentsToEmployee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");

        public FormViewAppointmentsToEmployee()
        {
            InitializeComponent();
        }

        private void FormViewAppointmentsToEmployee_Load(object sender, EventArgs e)
        {
            comboBoxSelectAppointments.SelectedIndex = 0;

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Appointment";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewAppointmentsToEmployee.DataSource = dt;

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

        private void buttonMoreDetails_Click(object sender, EventArgs e)
        {
            FormMoreAppointmentDetailsToEmployee more = new FormMoreAppointmentDetailsToEmployee(dataGridViewAppointmentsToEmployee.SelectedRows[0].Cells[0].Value.ToString(),
               dataGridViewAppointmentsToEmployee.SelectedRows[0].Cells[5].Value.ToString(),
               dataGridViewAppointmentsToEmployee.SelectedRows[0].Cells[7].Value.ToString(),
               dataGridViewAppointmentsToEmployee.SelectedRows[0].Cells[6].Value.ToString(),
               dataGridViewAppointmentsToEmployee.SelectedRows[0].Cells[8].Value.ToString(),
               dataGridViewAppointmentsToEmployee.SelectedRows[0].Cells[4].Value.ToString(),
               dataGridViewAppointmentsToEmployee.SelectedRows[0].Cells[9].Value.ToString(),
               dataGridViewAppointmentsToEmployee.SelectedRows[0].Cells[10].Value.ToString(),
               dataGridViewAppointmentsToEmployee.SelectedRows[0].Cells[11].Value.ToString(),
               dataGridViewAppointmentsToEmployee.SelectedRows[0].Cells[14].Value.ToString(),
               dataGridViewAppointmentsToEmployee.SelectedRows[0].Cells[15].Value.ToString(),
               dataGridViewAppointmentsToEmployee.SelectedRows[0].Cells[16].Value.ToString(),               
               dataGridViewAppointmentsToEmployee.SelectedRows[0].Cells[1].Value.ToString(),
               dataGridViewAppointmentsToEmployee.SelectedRows[0].Cells[13].Value.ToString(),
               dataGridViewAppointmentsToEmployee.SelectedRows[0].Cells[12].Value.ToString());
            more.Show();
        }

        private void buttonAddNewAppointment_Click(object sender, EventArgs e)
        {

        }


        
        
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
