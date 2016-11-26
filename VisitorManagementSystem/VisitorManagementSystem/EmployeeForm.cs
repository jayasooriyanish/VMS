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
    public partial class EmployeeForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            
            comboBoxGender.SelectedIndex = 0;
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Employee";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewEmployee.DataSource = dt;
                //textBoxEmployeeId.Focus();

            }
            catch
            {

                MessageBox.Show("There was an error!");
            }
            finally
            {
                con.Close();
            }
            textBoxEmployeeId.Focus();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Employee(EmployeeId,FirstName,LastName,Department,Designation,Address,DateOfBirth,Gender,NicNumber,WorkPhone,Mobile,Other,Email,Photo) values('" + textBoxEmployeeId.Text + "','" + textBoxFirstName.Text + "','" + textBoxLastName.Text + "','" + textBoxDepartment.Text + "','" + textBoxDesignation.Text + "','" + textBoxPersonalAddress.Text + "','" + dateTimePickerDateOfBirth.Text.ToString() + "','" + comboBoxGender.Text + "','" + maskedTextBoxNicNumber.Text + "','" + textBoxWorkPhone.Text.ToString() + "','" + textBoxMobile.Text.ToString() + "','" + textBoxOther.Text.ToString() + "','" + textBoxEmail.Text + "','" + pictureBoxPhoto.Image + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                textBoxEmployeeId.Clear();
                textBoxFirstName.Clear();
                textBoxLastName.Clear();
                textBoxDepartment.Clear();
                textBoxDesignation.Clear();
                textBoxPersonalAddress.Clear();
                comboBoxGender.SelectedIndex = 0;
                maskedTextBoxNicNumber.Clear();
                textBoxWorkPhone.Clear();
                textBoxMobile.Clear();
                textBoxOther.Clear();
                textBoxEmail.Clear();
                pictureBoxPhoto.Image = null;

                disp_data();

                MessageBox.Show("Record Saved!");
                textBoxEmployeeId.Focus();



            }
            catch
            {
                MessageBox.Show("There was an Error! Please re-enter the data");
                textBoxEmployeeId.Focus();
            }

            finally
            {
                con.Close();
            }
        }

            public void disp_data()
            {
            con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Employee";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewEmployee.DataSource = dt;
                con.Close();
            }

            private void buttonAddEmployee_Click(object sender, EventArgs e)
            {
                try
                {
                    textBoxEmployeeId.Clear();
                    textBoxFirstName.Clear();
                    textBoxLastName.Clear();
                    textBoxDepartment.Clear();
                    textBoxDesignation.Clear();
                    textBoxPersonalAddress.Clear();
                    comboBoxGender.SelectedIndex = 0;
                    maskedTextBoxNicNumber.Clear();
                    textBoxWorkPhone.Clear();
                    textBoxMobile.Clear();
                    textBoxOther.Clear();
                    textBoxEmail.Clear();
                    pictureBoxPhoto.Image = null;
                    textBoxEmployeeId.Focus();

                    disp_data();

                }
                catch 
                {

                    MessageBox.Show("There was an error! Please Re-enter data!");
                    textBoxEmployeeId.Focus();
                }
            }

            private void buttonDelete_Click(object sender, EventArgs e)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Employee where EmployeeId='" + textBoxEmployeeId.Text + "' OR NicNumber='" + maskedTextBoxNicNumber.Text + "'  OR FirstName='" + textBoxFirstName.Text + "' OR LastName='" + textBoxLastName.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    textBoxEmployeeId.Clear();
                    textBoxFirstName.Clear();
                    textBoxLastName.Clear();
                    textBoxDepartment.Clear();
                    textBoxDesignation.Clear();
                    textBoxPersonalAddress.Clear();
                    comboBoxGender.SelectedIndex = 0;
                    maskedTextBoxNicNumber.Clear();
                    textBoxWorkPhone.Clear();
                    textBoxMobile.Clear();
                    textBoxOther.Clear();
                    textBoxEmail.Clear();
                    pictureBoxPhoto.Image = null;

                    MessageBox.Show("Record Deleted!");
                    textBoxEmployeeId.Focus();

                    disp_data();


                }
                catch
                {

                    MessageBox.Show("An Error Occured!");
                }
                finally
                {
                    con.Close();
                }
            }

            private void buttonSearch_Click(object sender, EventArgs e)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from Employee where FirstName='" + textBoxFirstName.Text + "' OR NicNumber='" + maskedTextBoxNicNumber.Text + "' OR LastName='"+textBoxLastName.Text+"'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridViewEmployee.DataSource = dt;
                    con.Close();

                    textBoxEmployeeId.Focus();

                }
                catch 
                {
                    MessageBox.Show("Employee you searched not found.Please check the data and enter again!");  
                    
                }
            }

            private void buttonCancel_Click(object sender, EventArgs e)
            {
                try
                {
                    textBoxEmployeeId.Clear();
                    textBoxFirstName.Clear();
                    textBoxLastName.Clear();
                    textBoxDepartment.Clear();
                    textBoxDesignation.Clear();
                    textBoxPersonalAddress.Clear();
                    comboBoxGender.SelectedIndex = 0;
                    maskedTextBoxNicNumber.Clear();
                    textBoxWorkPhone.Clear();
                    textBoxMobile.Clear();
                    textBoxOther.Clear();
                    textBoxEmail.Clear();
                    pictureBoxPhoto.Image = null;

                    textBoxEmployeeId.Focus();

                    disp_data();

                }
                catch 
                {
                    MessageBox.Show("There was an error!");
                    textBoxEmployeeId.Focus();
                    
                }

            }

            private void buttonViewAll_Click(object sender, EventArgs e)
            {
                
                try
                {
                    disp_data();

                    textBoxEmployeeId.Clear();
                    textBoxFirstName.Clear();
                    textBoxLastName.Clear();
                    textBoxDepartment.Clear();
                    textBoxDesignation.Clear();
                    textBoxPersonalAddress.Clear();
                    comboBoxGender.SelectedIndex = 0;
                    maskedTextBoxNicNumber.Clear();
                    textBoxWorkPhone.Clear();
                    textBoxMobile.Clear();
                    textBoxOther.Clear();
                    textBoxEmail.Clear();
                    pictureBoxPhoto.Image = null;

                    textBoxEmployeeId.Focus();

                }
                catch 
                {

                    MessageBox.Show("Error!");
                }

            }

            private void buttonEdit_Click(object sender, EventArgs e)
            {
                try
                {
                    //con.Open();
                    //SqlCommand cmd = con.CreateCommand();
                    //cmd.CommandType = CommandType.Text;
                    //cmd.CommandText = "edit from Employee where EmployeeId='" + textBoxEmployeeId.Text + "' OR NicNumber='"+maskedTextBoxNicNumber.Text+"'";
                    //cmd.ExecuteNonQuery();
                    //con.Close();
                }
                catch 
                {

                    MessageBox.Show("Error!");
                }

            }

            private void buttonPhoto_Click(object sender, EventArgs e)
            {
                photoOpenFileDialog.FileName = "";
                if (photoOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxPhoto.Image = Image.FromFile(photoOpenFileDialog.FileName);
                }
            }
        }
    }


