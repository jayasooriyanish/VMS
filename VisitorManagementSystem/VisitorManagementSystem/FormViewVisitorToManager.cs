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
    public partial class FormViewVisitorToManager : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");
        public FormViewVisitorToManager()
        {
            InitializeComponent();
        }

        private void FormViewVisitorToManager_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Visitor";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewViewVisitorToManager.DataSource = dt;

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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMoreDetails_Click(object sender, EventArgs e)
        {
            try
            {
                FormViewVisitorMoreDetailsToManager more = new FormViewVisitorMoreDetailsToManager(dataGridViewViewVisitorToManager.SelectedRows[0].Cells[0].Value.ToString());
                more.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void buttonViewHistory_Click(object sender, EventArgs e)
        {                      
            object cell=dataGridViewViewVisitorToManager.SelectedRows[0].Cells[0].Value;

            try
            {
                if (cell != null)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Visit where VisitorId = '" + cell.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    Object VisitExist = cmd.ExecuteScalar();

                    if (VisitExist != null)
                    {

                        FormViewHistoryFromViewVisitorToManager more = new FormViewHistoryFromViewVisitorToManager(dataGridViewViewVisitorToManager.SelectedRows[0].Cells[0].Value.ToString());
                        more.Show();
                    }
                    else
                    {
                        MessageBox.Show("No previous visits found for the visitor");
                        con.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Please select visitor!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
