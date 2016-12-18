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
        //string employeeId;
        String EId = "SILEMP";

        private void GenerateAutoId()
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select Count(EmployeeId) from Employee", con);
            int i = Convert.ToInt32(cmd1.ExecuteScalar());
            con.Close();
            i++;
            textBoxEmployeeId.Text = EId + i.ToString();
        }



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
            GenerateAutoId();
            comboBoxGender.SelectedIndex = 0;
            //try
            //{
            //    con.Open();
            //    SqlCommand cmd = con.CreateCommand();
            //    cmd.CommandType = CommandType.Text;
            //    cmd.CommandText = "select * from Employee";
            //    cmd.ExecuteNonQuery();
            //    //DataTable dt = new DataTable();
            //    //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    //da.Fill(dt);
            //    //dataGridViewEmployee.DataSource = dt;
            //    //textBoxEmployeeId.Focus();

            //}
            //catch(Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    con.Close();
            //}
            textBoxFirstName.Focus();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                    con.Open();
                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "Select * from Employee where NicNumber='" + maskedTextBoxNicNumber.Text + "'";
                    cmd2.ExecuteNonQuery();
                    
                    Object EmployeeExist = cmd2.ExecuteScalar();
                    con.Close();

                    if (EmployeeExist == null)
                    {
                        con.Close();
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "Insert into Employee(EmployeeId,FirstName,LastName,Department,Designation,Address,DateOfBirth,Gender,NicNumber,WorkPhone,Mobile,Other,Email,Photo) values('" + textBoxEmployeeId.Text + "','" + textBoxFirstName.Text + "','" + textBoxLastName.Text + "','" + textBoxDepartment.Text + "','" + textBoxDesignation.Text + "','" + textBoxPersonalAddress.Text + "','" + dateTimePickerDateOfBirth.Text.ToString() + "','" + comboBoxGender.Text + "','" + maskedTextBoxNicNumber.Text + "','" + textBoxWorkPhone.Text.ToString() + "','" + textBoxMobile.Text.ToString() + "','" + textBoxOther.Text.ToString() + "','" + textBoxEmail.Text + "','" + pictureBoxPhoto.Image + "')";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        GenerateAutoId();
                        
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

                        

                        MessageBox.Show("Record Saved!");
                        textBoxFirstName.Focus();
                    }

                    else
                    {

                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select * from Employee where NicNumber='" + maskedTextBoxNicNumber.Text + "'";
                        //cmd.ExecuteNonQuery();

                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            textBoxFirstName.Text = dr["FirstName"].ToString();
                            textBoxLastName.Text = dr["LastName"].ToString();
                            textBoxEmployeeId.Text = dr["EmployeeId"].ToString();
                            dateTimePickerDateOfBirth.Text = dr["DateOfBirth"].ToString();
                            textBoxDesignation.Text = dr["Designation"].ToString();
                            textBoxDepartment.Text = dr["Department"].ToString();
                            comboBoxGender.Text = dr["Gender"].ToString();
                            textBoxPersonalAddress.Text = dr["Address"].ToString();
                            textBoxWorkPhone.Text = dr["WorkPhone"].ToString();
                            textBoxMobile.Text = dr["Mobile"].ToString();
                            textBoxOther.Text = dr["Other"].ToString();
                            textBoxEmail.Text = dr["Email"].ToString();
                            //pictureBoxPhoto.Image =;

                        }
                        dr.Close();
                        con.Close();
                    }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                GenerateAutoId();
                textBoxFirstName.Focus();
            }

            finally
            {
                con.Close();
            }
        }

            public void disp_data()
            {
            //con.Open();
            //    SqlCommand cmd = con.CreateCommand();
            //    cmd.CommandType = CommandType.Text;
            //    cmd.CommandText = "Select * from Employee";
            //    cmd.ExecuteNonQuery();
            //    DataTable dt = new DataTable();
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    da.Fill(dt);
            //    dataGridViewEmployee.DataSource = dt;
            //    con.Close();
            }

            private void buttonAddEmployee_Click(object sender, EventArgs e)
            {
                //try
                //{
                //    GenerateAutoId();
                //    textBoxFirstName.Clear();
                //    textBoxLastName.Clear();
                //    textBoxDepartment.Clear();
                //    textBoxDesignation.Clear();
                //    textBoxPersonalAddress.Clear();
                //    comboBoxGender.SelectedIndex = 0;
                //    maskedTextBoxNicNumber.Clear();
                //    textBoxWorkPhone.Clear();
                //    textBoxMobile.Clear();
                //    textBoxOther.Clear();
                //    textBoxEmail.Clear();
                //    pictureBoxPhoto.Image = null;
                //    textBoxFirstName.Focus();

                //    //disp_data();

                //}
                //catch(Exception ex)
                //{

                //    MessageBox.Show(ex.Message);
                //    GenerateAutoId();
                //    textBoxFirstName.Focus();
                //}
            }

            private void buttonDelete_Click(object sender, EventArgs e)
            {
                //try
                //{
                //    con.Open();
                //    SqlCommand cmd = con.CreateCommand();
                //    cmd.CommandType = CommandType.Text;
                //    cmd.CommandText = "delete from Employee where EmployeeId='" + textBoxEmployeeId.Text + "' OR NicNumber='" + maskedTextBoxNicNumber.Text + "'  OR FirstName='" + textBoxFirstName.Text + "' OR LastName='" + textBoxLastName.Text + "'";
                //    cmd.ExecuteNonQuery();
                //    con.Close();

                //    GenerateAutoId();
                //    textBoxFirstName.Clear();
                //    textBoxLastName.Clear();
                //    textBoxDepartment.Clear();
                //    textBoxDesignation.Clear();
                //    textBoxPersonalAddress.Clear();
                //    comboBoxGender.SelectedIndex = 0;
                //    maskedTextBoxNicNumber.Clear();
                //    textBoxWorkPhone.Clear();
                //    textBoxMobile.Clear();
                //    textBoxOther.Clear();
                //    textBoxEmail.Clear();
                //    pictureBoxPhoto.Image = null;

                //    MessageBox.Show("Record Deleted!");
                //    textBoxFirstName.Focus();

                //    //disp_data();


                //}
                //catch(Exception ex)
                //{

                //    MessageBox.Show(ex.Message);
                //}
                //finally
                //{
                //    con.Close();
                //}
            }

            private void buttonSearch_Click(object sender, EventArgs e)
            {
                //try
                //{
                //    con.Open();
                //    SqlCommand cmd = con.CreateCommand();
                //    cmd.CommandType = CommandType.Text;
                //    cmd.CommandText = "Select * from Employee where FirstName='" + textBoxFirstName.Text + "' OR NicNumber='" + maskedTextBoxNicNumber.Text + "' OR LastName='"+textBoxLastName.Text+"'";
                //    cmd.ExecuteNonQuery();
                //    Object EmployeeExist = cmd.ExecuteScalar();

                //     if (EmployeeExist != null)
                //    {
                //    DataTable dt = new DataTable();
                //    SqlDataAdapter da = new SqlDataAdapter(cmd);
                //    da.Fill(dt);
                //    //dataGridViewEmployee.DataSource = dt;
                //    SqlDataReader dr = cmd.ExecuteReader();
                //    while (dr.Read())
                //    {
                //        textBoxFirstName.Text = dr["FirstName"].ToString();
                //        textBoxLastName.Text = dr["LastName"].ToString();
                //        textBoxEmployeeId.Text = dr["EmployeeId"].ToString();
                //        dateTimePickerDateOfBirth.Text = dr["DateOfBirth"].ToString();
                //        textBoxDesignation.Text = dr["Designation"].ToString();
                //        textBoxDepartment.Text = dr["Department"].ToString();
                //        comboBoxGender.Text = dr["Gender"].ToString();
                //        textBoxPersonalAddress.Text = dr["Address"].ToString();                        
                //        textBoxWorkPhone.Text = dr["WorkPhone"].ToString();
                //        textBoxMobile.Text = dr["Mobile"].ToString();
                //        textBoxOther.Text = dr["Other"].ToString();
                //        textBoxEmail.Text = dr["Email"].ToString();
                //        //pictureBoxPhoto.Image =;

                //    }
                //    dr.Close();
                //    con.Close();
                //    }
                //     else
                //     {
                //         MessageBox.Show("Employee Not Found!Enter Employee Details To Register New Employee.");
                //         con.Close();
                //         maskedTextBoxNicNumber.Clear();
                //         GenerateAutoId();
                //         textBoxFirstName.Focus();
                //     }
                //     con.Close();

                //    textBoxFirstName.Focus();

                //}
                //catch(Exception ex) 
                //{
                //    MessageBox.Show(ex.Message);  
                    
                //}
            }

            private void buttonCancel_Click(object sender, EventArgs e)
            {
                try
                {
                    GenerateAutoId();
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

                    textBoxFirstName.Focus();

                    //disp_data();

                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                    textBoxFirstName.Focus();
                    
                }

            }

            private void buttonViewAll_Click(object sender, EventArgs e)
            {
                
                //try
                //{
                //    //disp_data();

                //    GenerateAutoId();
                //    textBoxFirstName.Clear();
                //    textBoxLastName.Clear();
                //    textBoxDepartment.Clear();
                //    textBoxDesignation.Clear();
                //    textBoxPersonalAddress.Clear();
                //    comboBoxGender.SelectedIndex = 0;
                //    maskedTextBoxNicNumber.Clear();
                //    textBoxWorkPhone.Clear();
                //    textBoxMobile.Clear();
                //    textBoxOther.Clear();
                //    textBoxEmail.Clear();
                //    pictureBoxPhoto.Image = null;

                //    textBoxFirstName.Focus();

                //}
                //catch(Exception ex) 
                //{

                //    MessageBox.Show(ex.Message);
                //}

            }

            private void buttonEdit_Click(object sender, EventArgs e)
            {
                //try
                //{
                    
                //}
                //catch(Exception ex) 
                //{

                //    MessageBox.Show(ex.Message);
                //}

            }

            private void buttonPhoto_Click(object sender, EventArgs e)
            {
                photoOpenFileDialog.FileName = "";
                if (photoOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxPhoto.Image = Image.FromFile(photoOpenFileDialog.FileName);
                }
            }

            private void dataGridViewEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                //try
                //{
                //    con.Open();
                //    employeeId = dataGridViewEmployee.Rows[e.RowIndex].Cells["EmployeeId"].Value.ToString();
                //    SqlCommand cmd = con.CreateCommand();
                //    cmd.CommandType = CommandType.Text;
                //    cmd.CommandText = "Select * from Employee where EmployeeId='" + employeeId + "'";
                //    cmd.ExecuteNonQuery();
                //    DataTable dt = new DataTable();
                //    SqlDataAdapter da = new SqlDataAdapter(cmd);
                //    da.Fill(dt);
                //    foreach (DataRow dr in dt.Rows)
                //    {
                //        textBoxEmployeeId.Text = dr["EmployeeId"].ToString();
                //        textBoxFirstName.Text = dr["FirstName"].ToString();
                //        textBoxLastName.Text = dr["LastName"].ToString();
                //        maskedTextBoxNicNumber.Text = dr["NicNumber"].ToString();
                //        dateTimePickerDateOfBirth.Text = dr["DateOfBirth"].ToString();                        
                //        textBoxDesignation.Text = dr["Designation"].ToString();
                //        textBoxDepartment.Text = dr["Department"].ToString();
                //        comboBoxGender.Text = dr["Gender"].ToString();
                //        textBoxPersonalAddress.Text = dr["Address"].ToString();                        
                //        textBoxWorkPhone.Text = dr["WorkPhone"].ToString();
                //        textBoxMobile.Text = dr["Mobile"].ToString();
                //        textBoxOther.Text = dr["Other"].ToString();
                //        textBoxEmail.Text = dr["Email"].ToString();
                //        //photo

                //    }
                //    con.Close();
                //}
                //catch (Exception ex)
                //{

                //    MessageBox.Show(ex.Message);
                //}
            }
        }
    }


