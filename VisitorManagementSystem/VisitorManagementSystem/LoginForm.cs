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
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");

        public LoginForm()
        {
            InitializeComponent();
            postInit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonForgotPassword_Click(object sender, EventArgs e)
        {

        }

        private void postInit()
        {
            this.buttonForgotPassword.TabStop = false;
            this.buttonForgotPassword.FlatStyle = FlatStyle.Flat;
            this.buttonForgotPassword.FlatAppearance.BorderSize = 0;
            this.buttonForgotPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username=this.textBoxUserName.Text;
            string password=this.textBoxPassword.Text;

            if (username != null && !username.Equals(""))
            {
                if (password != null && !password.Equals(""))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "Select Type from Employee where UserName='" + textBoxUserName.Text + "' AND Password='"+textBoxPassword.Text+"'";
                        cmd.ExecuteNonQuery();
                        Object UserExist = cmd.ExecuteScalar();

                        if (UserExist != null)
                        {
                            SqlDataReader dr = cmd.ExecuteReader();
                            string type = "";
                             while (dr.Read())
                             {
                                 type = dr["Type"].ToString();
                            
                             }
                             Utils.setUsername(username);
                             Utils.setType(type);
                            this.Hide();
                            if(!type.Equals("") && type.Equals("Manager"))
                            {
                                MainFormToManager mnger = new MainFormToManager();
                                mnger.ShowDialog();
                            }
                            else if (!type.Equals("") && type.Equals("Employee"))
                            {
                                MainForm emp = new MainForm();
                                emp.ShowDialog();
                            }
                            else if (!type.Equals("") && type.Equals("Security"))
                            {
                                MainFormToSecurityAdmin sec = new MainFormToSecurityAdmin();
                                sec.ShowDialog();
                            }

                            
                            
 
                        }
                    

                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Password is empty");
                }
            }
            else
            {
                MessageBox.Show("UserName is empty");
            }
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserRegistrationForm reg = new UserRegistrationForm();
            reg.Show();
        }
    }
}
