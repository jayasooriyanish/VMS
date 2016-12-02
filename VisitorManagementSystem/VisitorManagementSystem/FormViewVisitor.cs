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
    public partial class FormViewVisitor : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");

        public FormViewVisitor()
        {
            InitializeComponent();
        }

        private void FormViewVisitor_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from  Visitor";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewViewVisitor.DataSource = dt;
                
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonViewHistory_Click(object sender, EventArgs e)
        {
            FormVisitorHistory newfrm = new FormVisitorHistory();
            newfrm.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMoreDetails_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewViewVisitor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
