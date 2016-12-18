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
    public partial class UserRegistrationForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");
        String EId = "SILEMP";

        private string GenerateAutoId()
        {
            SqlCommand cmd1 = new SqlCommand("Select Count(EmployeeId) from Employee", con);
            int i = Convert.ToInt32(cmd1.ExecuteScalar());
            i++;
            return EId + i.ToString();
        }

        public UserRegistrationForm()
        {
            InitializeComponent();
        }

        private void UserRegistrationForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = this.textBoxUserName.Text;
            string password = this.textBoxPassword.Text;
            string confirmPassword = this.textBoxConfirmPassword.Text;
            string userType = this.comboBoxUserType.Text;

            if (username != null && !username.Equals(""))
            {
                if (password != null && !password.Equals(""))
                {
                    if (confirmPassword != null && !confirmPassword.Equals(""))
                    {
                        if (confirmPassword.Equals(password))
                        {
                            if (userType != null && !userType.Equals(""))
                            {
                                try
                                { 
                                    con.Close();
                                    con.Open();
                                    String id = GenerateAutoId();
                                    SqlCommand cmd = con.CreateCommand();
                                    cmd.CommandType = CommandType.Text;
                                    cmd.CommandText = "Insert into Employee(EmployeeId,UserName,Password,Type) values('" + id + "','" + textBoxUserName.Text + "','" + textBoxPassword.Text + "','" + comboBoxUserType.Text + "')";
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                    Utils.setEmployeeId(id);

                                    EmployeeForm empfrm = new EmployeeForm();
                                    empfrm.Show();

                                    this.Close();
                                    
                                }
                                catch (Exception ex)
                                {
                                    if(ex.Message.Contains("duplicate"))
                                    {
                                        MessageBox.Show("This username is used by another user, please try using another username");
                                        textBoxUserName.Clear();
                                        textBoxUserName.Focus();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please select user type!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Passwords are not matching!");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the password again!");
                    }
                }
                else
                {
                    MessageBox.Show("Password is empty");
                }
            }
            else
            {
                MessageBox.Show("Username is empty");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Close();
            login.Show();
            
        }
    }
}
