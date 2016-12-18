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
    public partial class FormVisitListToManager : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");
        public FormVisitListToManager()
        {
            InitializeComponent();
        }

        private void FormVisitListToManager_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Visit";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewVisitList.DataSource = dt;

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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMoreDetails_Click(object sender, EventArgs e)
        {
            Console.Write(this.dataGridViewVisitList.RowCount);
            if (this.dataGridViewVisitList.RowCount > 1)
            {

                FormMoreVisitDetailsToManager more = new FormMoreVisitDetailsToManager(dataGridViewVisitList.SelectedRows[0].Cells[0].Value.ToString(),
                    dataGridViewVisitList.SelectedRows[0].Cells[1].Value.ToString(),
                    dataGridViewVisitList.SelectedRows[0].Cells[2].Value.ToString(),
                    dataGridViewVisitList.SelectedRows[0].Cells[3].Value.ToString(),
                    dataGridViewVisitList.SelectedRows[0].Cells[4].Value.ToString(),
                    dataGridViewVisitList.SelectedRows[0].Cells[5].Value.ToString(),
                    dataGridViewVisitList.SelectedRows[0].Cells[6].Value.ToString(),
                    dataGridViewVisitList.SelectedRows[0].Cells[7].Value.ToString(),
                    dataGridViewVisitList.SelectedRows[0].Cells[8].Value.ToString(),
                    dataGridViewVisitList.SelectedRows[0].Cells[9].Value.ToString(),
                    dataGridViewVisitList.SelectedRows[0].Cells[10].Value.ToString(),
                    dataGridViewVisitList.SelectedRows[0].Cells[11].Value.ToString(),
                    dataGridViewVisitList.SelectedRows[0].Cells[12].Value.ToString(),
                    dataGridViewVisitList.SelectedRows[0].Cells[13].Value.ToString(),
                    dataGridViewVisitList.SelectedRows[0].Cells[14].Value.ToString(),
                    dataGridViewVisitList.SelectedRows[0].Cells[15].Value.ToString(),
                    dataGridViewVisitList.SelectedRows[0].Cells[16].Value.ToString(),
                    dataGridViewVisitList.SelectedRows[0].Cells[17].Value.ToString());
                more.Show();
            }
            else
            {
                MessageBox.Show("No records found!");
            }
        }

        private void dataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        { 
            if(e.StateChanged == DataGridViewElementStates.Selected )
            {
                this.buttonMoreDetails.Enabled = true;
            }
        }
    }
}
