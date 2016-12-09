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
    public partial class PendingRequestsForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");


        public PendingRequestsForm()
        {
            InitializeComponent();
        }

        private void buttonMoreDetails_Click(object sender, EventArgs e)
        {
            FormPendingRequestsMoreDetails more = new FormPendingRequestsMoreDetails(dataGridViewPendingRequests.SelectedRows[0].Cells[0].Value.ToString(),
                dataGridViewPendingRequests.SelectedRows[0].Cells[5].Value.ToString(),
                dataGridViewPendingRequests.SelectedRows[0].Cells[7].Value.ToString(),
                dataGridViewPendingRequests.SelectedRows[0].Cells[6].Value.ToString(),
                dataGridViewPendingRequests.SelectedRows[0].Cells[8].Value.ToString(),
                dataGridViewPendingRequests.SelectedRows[0].Cells[4].Value.ToString(),
                dataGridViewPendingRequests.SelectedRows[0].Cells[9].Value.ToString(),
                dataGridViewPendingRequests.SelectedRows[0].Cells[10].Value.ToString(),
                dataGridViewPendingRequests.SelectedRows[0].Cells[11].Value.ToString(),
                dataGridViewPendingRequests.SelectedRows[0].Cells[14].Value.ToString(),
                dataGridViewPendingRequests.SelectedRows[0].Cells[15].Value.ToString(),
                dataGridViewPendingRequests.SelectedRows[0].Cells[16].Value.ToString(),
                dataGridViewPendingRequests.SelectedRows[0].Cells[1].Value.ToString(),
                dataGridViewPendingRequests.SelectedRows[0].Cells[12].Value.ToString(),
                dataGridViewPendingRequests.SelectedRows[0].Cells[13].Value.ToString());
            more.Show();
        }

        private void PendingRequestsForm_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Appointment where Appointment.Status = 'Pending'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewPendingRequests.DataSource = dt;

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
    }
}
