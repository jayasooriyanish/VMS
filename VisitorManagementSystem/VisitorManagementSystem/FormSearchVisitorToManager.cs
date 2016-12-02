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
    public partial class FormSearchVisitorToManager : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");

        public FormSearchVisitorToManager()
        {
            InitializeComponent();
        }

        private void buttonRegisterNewVisitor_Click(object sender, EventArgs e)
        {
            FormRegisterFromSearchToManager reg = new FormRegisterFromSearchToManager();
            reg.Show();
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            maskedTextBoxNIC.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            maskedTextBoxNIC.Focus();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            maskedTextBoxNIC.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            maskedTextBoxNIC.Focus();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Visitor where NicNumber='" + maskedTextBoxNIC.Text + "'";

                Object VisitorExist = cmd.ExecuteScalar();

                if (VisitorExist != null)
                {
                    FormVisitorRegisterFromSearchToEmployee newRegForm = new FormVisitorRegisterFromSearchToEmployee();
                    newRegForm.PassValue = maskedTextBoxNIC.Text;
                    newRegForm.ShowDialog();
                }
                else
                {
                    DialogResult answer;
                    answer = MessageBox.Show("Visitor Not Found!Do You Want To Register New", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        VisitorRegisterForm newfrm = new VisitorRegisterForm();
                        newfrm.Show();

                    }

                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormSearchVisitorToManager_Load(object sender, EventArgs e)
        {
            maskedTextBoxNIC.Focus();
        }

        private void maskedTesxtBoxNic_TextChanged(object sender, EventArgs e)
        {
            //if (((MaskedTextBox)sender).TextLength > 5)
            //    SendKeys.Send("{Tab}");
        }
    }
}
