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
    public partial class FormSearchVisitorToSecurity : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");

        public FormSearchVisitorToSecurity()
        {
            InitializeComponent();
        }

        private void FormSearchVisitotToSecurity_Load(object sender, EventArgs e)
        {
            maskedTextBoxNicNumber.Focus();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Visitor where NicNumber='" + maskedTextBoxNicNumber.Text + "'";

                Object VisitorExist = cmd.ExecuteScalar();

                if (VisitorExist != null)
                {
                    FormVisitorRegisterFromSearchToSecurity newRegForm = new FormVisitorRegisterFromSearchToSecurity();
                    newRegForm.PassValue = maskedTextBoxNicNumber.Text;
                    newRegForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Visitor Not Found! Please Check Your Data.");

                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            maskedTextBoxNicNumber.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            maskedTextBoxNicNumber.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            maskedTextBoxNicNumber.Focus();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
