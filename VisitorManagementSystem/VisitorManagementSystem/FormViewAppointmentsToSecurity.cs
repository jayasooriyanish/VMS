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
    public partial class FormViewAppointmentsToSecurity : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");

        public FormViewAppointmentsToSecurity()
        {
            InitializeComponent();
        }

        private void FormViewAppointmentsToSecurity_Load(object sender, EventArgs e)
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
                dataGridViewViewAppointments.DataSource = dt;

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

        private void buttonProceedToCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                FormProceedToCheckInFromViewVisitor more = new FormProceedToCheckInFromViewVisitor(dataGridViewViewAppointments.SelectedRows[0].Cells[0].Value.ToString(),
                    dataGridViewViewAppointments.SelectedRows[0].Cells[1].Value.ToString(),
                    dataGridViewViewAppointments.SelectedRows[0].Cells[9].Value.ToString(),
                    dataGridViewViewAppointments.SelectedRows[0].Cells[10].Value.ToString(),
                    dataGridViewViewAppointments.SelectedRows[0].Cells[11].Value.ToString(),
                    dataGridViewViewAppointments.SelectedRows[0].Cells[4].Value.ToString());
                more.Show();
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
