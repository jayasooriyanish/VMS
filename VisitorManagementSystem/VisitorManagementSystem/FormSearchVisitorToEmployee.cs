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
    public partial class FormSearchVisitorToEmployee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");
        //String VisitorId = "VI";
    
        public FormSearchVisitorToEmployee()
        {
            InitializeComponent();
            
        }

        private void buttonRegisterNewVisitor_Click(object sender, EventArgs e)
        {
            //FormRegister1 register = new FormRegister1();
            //register.ShowDialog();
            VisitorRegisterForm objVisitorRegisterForm = new VisitorRegisterForm();
            objVisitorRegisterForm.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            maskedTextBoxNIC.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
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

        public void maskedTextBoxNIC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FormSearchVisitorToEmployee_Load(object sender, EventArgs e)
        {
            maskedTextBoxNIC.Focus();
        }
    }
}
