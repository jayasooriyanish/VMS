﻿using System;
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
    public partial class VisitorRegisterForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");
        string visitorId;

        String VisitorId = "VI";

        public VisitorRegisterForm()
        {
            InitializeComponent();
        }
       
        
        
        private void VisitorRegisterForm_Load(object sender, EventArgs e)
        {

            comboBoxCategory.SelectedIndex = 0;
            comboBoxGender.SelectedIndex = 0;

            //GenerateAutoId();

            

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
            dataGridView1.DataSource = dt;
            textBoxVisitorId.Focus();

            


            }
            catch 
            {

                MessageBox.Show("There was an Error!");
            }
            finally
            {
                con.Close();
            }
            
        }

        private void GenerateAutoId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(visitorId) from Visitor", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            i++;
            textBoxVisitorId.Text = VisitorId + i.ToString();
        }



        private void buttonSave_Click(object sender, EventArgs e)
        {

            
            try
            {
                    con.Open();
                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "Select * from Visitor where NicNumber='" + maskedTextBoxNicNumber.Text + "'";
                    cmd2.ExecuteNonQuery();
                    
                    Object VisitorExist = cmd2.ExecuteScalar();
                    con.Close();

                    if (VisitorExist == null)
                    {
                        con.Close();
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "Insert into Visitor(VisitorId,FirstName,LastName,NicNumber,Organization,Designation,Category,DateOfBirth,Gender,PersonalAddress,CompanyAddress,WorkPhone,Mobile,Other,Email,Photo) values('" + textBoxVisitorId.Text + "','" + textBoxFirstName.Text + "','" + textBoxLastName.Text + "','" + maskedTextBoxNicNumber.Text + "','" + textBoxOrganization.Text + "','" + textBoxDesignation.Text + "','" + comboBoxCategory.Text + "','" + dateTimePickerDateOfBirth.Value.ToString() + "','" + comboBoxGender.Text + "','" + textBoxPersonalAddress.Text + "','" + textBoxCompanyAddress.Text + "','" + textBoxWorkPhone.Text.ToString() + "','" + textBoxMobile.Text.ToString() + "','" + textBoxOther.Text.ToString() + "','" + textBoxEmail.Text + "','" + pictureBoxPhoto.Image.ToString() + "')";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        
                        //GenerateAutoId();  

                        comboBoxCategory.SelectedIndex = 0;
                        comboBoxGender.SelectedIndex = 0;
                        textBoxVisitorId.Text = "";
                        textBoxFirstName.Text = "";
                        textBoxLastName.Text = "";
                        textBoxOrganization.Text = "";
                        textBoxDesignation.Text = "";
                        //comboBoxCategory.Text = "";
                        maskedTextBoxNicNumber.Text = "";
                        //comboBoxGender.Text = "";
                        textBoxPersonalAddress.Text = "";
                        textBoxCompanyAddress.Text = "";
                        textBoxEmail.Text = "";
                        textBoxWorkPhone.Text = "";
                        textBoxMobile.Text = "";
                        textBoxOther.Text = "";
                        pictureBoxPhoto.Image = null;


                        MessageBox.Show("Record Saved!");
                        textBoxVisitorId.Focus();

                        disp_data();
                        con.Close();
                    }
                        
                    else
                    {

                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select * from Visitor where NicNumber='" + maskedTextBoxNicNumber.Text + "'";
                        //cmd.ExecuteNonQuery();
                        
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            textBoxFirstName.Text = dr["FirstName"].ToString();
                            textBoxLastName.Text = dr["LastName"].ToString();
                            textBoxVisitorId.Text = dr["VisitorId"].ToString();
                            dateTimePickerDateOfBirth.Text = dr["DateOfBirth"].ToString();
                            comboBoxCategory.Text = dr["Category"].ToString();
                            textBoxOrganization.Text = dr["Organization"].ToString();
                            textBoxDesignation.Text = dr["Designation"].ToString();
                            comboBoxGender.Text = dr["Gender"].ToString();
                            textBoxPersonalAddress.Text = dr["PersonalAddress"].ToString();
                            textBoxCompanyAddress.Text = dr["CompanyAddress"].ToString();
                            textBoxWorkPhone.Text = dr["WorkPhone"].ToString();
                            textBoxMobile.Text = dr["Mobile"].ToString();
                            textBoxOther.Text = dr["Other"].ToString();
                            textBoxEmail.Text = dr["Email"].ToString();
                            //pictureBoxPhoto.Image =;

                        }
                        dr.Close();
                        con.Close();

                        DialogResult answer;
                        answer = MessageBox.Show("Visitor Already Registered!Do You Want To Make New Appointment?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (answer == DialogResult.Yes)
                        {
                            AppointmentsForm appForm = new AppointmentsForm();
                            appForm.PassValue = textBoxVisitorId.Text;
                            appForm.ShowDialog();
                            con.Close();
                        }
                    }
                    con.Close();

            }


            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBoxVisitorId.Focus();
            }
            finally
            {
                con.Close();
            }
            
            //try
            //{
                //con.Open();
                //SqlCommand cmd = con.CreateCommand();
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "Insert into visitor values('" + textBoxVisitorId.Text + "','" + textBoxFirstName.Text + "','" + textBoxLastName.Text + "','" + maskedTextBoxNicNumber.Text + "','" + comboBoxCategory.Text + "','" + comboBoxGender.Text + "','" + textBoxOrganization.Text + "','" + textBoxDesignation.Text + "','" + dateTimePickerDateOfBirth.Text + "','" + listBoxPersonalAddress.Text + "','" + listBoxCompanyAddress.Text + "','" + textBoxEmail.Text + "','" + textBoxWorkPhone.Text + "','" + textBoxMobile.Text + "','" + textBoxOther.Text + "','" + pictureBoxPhoto.Image + "')";
                ////cmd.ExecuteNonQuery();
                //con.Close();
                //disp_data();
                //MessageBox.Show("Record Saved Successfully!");
            //}
            //catch (Exception ex)
            //{

            //    //throw ex;
            //}
            //finally
            //{
            //    con.Close();
            //}
        }

            public void disp_data()
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Visitor";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }

            private void pictureBoxPhoto_Click(object sender, EventArgs e)
            {

            }

            private void buttonPhoto_Click(object sender, EventArgs e)
            {
                photoOpenFileDialog.FileName = "";
                if (photoOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxPhoto.Image = Image.FromFile(photoOpenFileDialog.FileName);
                }
            }

            private void buttonExit_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void buttonCancel_Click(object sender, EventArgs e)
            {              
                
                try
                {
                    comboBoxCategory.SelectedIndex = 0;
                    comboBoxGender.SelectedIndex = 0;
                    textBoxVisitorId.Text = "";
                    textBoxFirstName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxOrganization.Text = "";
                    textBoxDesignation.Text = "";
                    //comboBoxCategory.Text = "";
                    maskedTextBoxNicNumber.Text = "";
                    //comboBoxGender.Text = "";
                    textBoxPersonalAddress.Text = "";
                    textBoxCompanyAddress.Text = "";
                    textBoxEmail.Text = "";
                    textBoxWorkPhone.Text = "";
                    textBoxMobile.Text = "";
                    textBoxOther.Text = "";
                    pictureBoxPhoto.Image = null;

                    textBoxVisitorId.Focus();

                    disp_data();
                }

                catch
                {
                    MessageBox.Show("There was an error!");
                    textBoxVisitorId.Focus();
                }
            }

            private void buttonDelete_Click(object sender, EventArgs e)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Visitor where visitorId='" + textBoxVisitorId.Text + "' OR FirstName='" + textBoxFirstName.Text + "' OR LastName='" + textBoxLastName.Text + "' OR NicNumber='" + maskedTextBoxNicNumber.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    comboBoxCategory.SelectedIndex = 0;
                    comboBoxGender.SelectedIndex = 0;
                    textBoxVisitorId.Text = "";
                    textBoxFirstName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxOrganization.Text = "";
                    textBoxDesignation.Text = "";
                    //comboBoxCategory.Text = "";
                    maskedTextBoxNicNumber.Text = "";
                    //comboBoxGender.Text = "";
                    textBoxPersonalAddress.Text = "";
                    textBoxCompanyAddress.Text = "";
                    textBoxEmail.Text = "";
                    textBoxWorkPhone.Text = "";
                    textBoxMobile.Text = "";
                    textBoxOther.Text = "";
                    pictureBoxPhoto.Image = null;


                    MessageBox.Show("Record Deleted!");
                    textBoxVisitorId.Focus();

                    disp_data();

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

            private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
            {

            }

            private void buttonAddNew_Click(object sender, EventArgs e)
            {
                

                try
                {
                    comboBoxCategory.SelectedIndex = 0;
                    comboBoxGender.SelectedIndex = 0;
                    textBoxVisitorId.Text = "";
                    textBoxFirstName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxOrganization.Text = "";
                    textBoxDesignation.Text = "";
                    //comboBoxCategory.Text = "";
                    maskedTextBoxNicNumber.Text = "";
                    //comboBoxGender.Text = "";
                    textBoxPersonalAddress.Text = "";
                    textBoxCompanyAddress.Text = "";
                    textBoxEmail.Text = "";
                    textBoxWorkPhone.Text = "";
                    textBoxMobile.Text = "";
                    textBoxOther.Text = "";
                    pictureBoxPhoto.Image = null;

                    textBoxVisitorId.Focus();

                    disp_data();
                }

                catch
                {
                    MessageBox.Show("There was an error!");
                    textBoxVisitorId.Focus();
                }

            }

            private void buttonSearch_Click(object sender, EventArgs e)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from Visitor where FirstName='" + textBoxFirstName.Text + "' OR NicNumber='" + maskedTextBoxNicNumber.Text + "'";
                    cmd.ExecuteNonQuery();
                    Object VisitorExist = cmd.ExecuteScalar();
                    Console.Write("Visitor"+VisitorExist);

                    if (VisitorExist != null)
                    {
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Visitor Not Found!Enter Visitor Details To Register New visitor.");
                        maskedTextBoxNicNumber.Clear();
                        textBoxVisitorId.Focus();
                    }
                    con.Close();

                    textBoxVisitorId.Focus();

                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    MessageBox.Show(ex.Message); 
                }
            }

            private void buttonViewAll_Click(object sender, EventArgs e)
            {
                disp_data();
                comboBoxCategory.SelectedIndex = 0;
                comboBoxGender.SelectedIndex = 0;
                textBoxVisitorId.Text = "";
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxOrganization.Text = "";
                textBoxDesignation.Text = "";
                //comboBoxCategory.Text = "";
                maskedTextBoxNicNumber.Text = "";
                //comboBoxGender.Text = "";
                textBoxPersonalAddress.Text = "";
                textBoxCompanyAddress.Text = "";
                textBoxEmail.Text = "";
                textBoxWorkPhone.Text = "";
                textBoxMobile.Text = "";
                textBoxOther.Text = "";
                pictureBoxPhoto.Image = null;

                textBoxVisitorId.Focus();
            }

            //int visitorId;

            private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                    con.Open();
                    visitorId = dataGridView1.Rows[e.RowIndex].Cells["VisitorId"].Value.ToString();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from Visitor where VisitorId='"+visitorId+"'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        textBoxVisitorId.Text = dr["VisitorId"].ToString();
                        textBoxFirstName.Text = dr["FirstName"].ToString();
                        textBoxLastName.Text = dr["LastName"].ToString();
                        maskedTextBoxNicNumber.Text = dr["NicNumber"].ToString();
                        dateTimePickerDateOfBirth.Text = dr["DateOfBirth"].ToString();
                        comboBoxCategory.Text = dr["Category"].ToString();
                        textBoxOrganization.Text = dr["Organization"].ToString();
                        textBoxDesignation.Text = dr["Designation"].ToString();
                        comboBoxGender.Text = dr["Gender"].ToString();
                        textBoxPersonalAddress.Text = dr["PersonalAddress"].ToString();
                        textBoxCompanyAddress.Text = dr["CompanyAddress"].ToString();
                        textBoxWorkPhone.Text = dr["WorkPhone"].ToString();
                        textBoxMobile.Text = dr["Mobile"].ToString();
                        textBoxOther.Text = dr["Other"].ToString();
                        textBoxEmail.Text = dr["Email"].ToString();
 
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.Message);
                }


            }

            private void buttonSaveAndAddAppointment_Click(object sender, EventArgs e)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert into Visitor(VisitorId,FirstName,LastName,NicNumber,Organization,Designation,Category,DateOfBirth,Gender,PersonalAddress,CompanyAddress,WorkPhone,Mobile,Other,Email,Photo) values('" + textBoxVisitorId.Text + "','" + textBoxFirstName.Text + "','" + textBoxLastName.Text + "','" + maskedTextBoxNicNumber.Text + "','" + textBoxOrganization.Text + "','" + textBoxDesignation.Text + "','" + comboBoxCategory.Text + "','" + dateTimePickerDateOfBirth.Value.ToString() + "','" + comboBoxGender.Text + "','" + textBoxPersonalAddress.Text + "','" + textBoxCompanyAddress.Text + "','" + textBoxWorkPhone.Text.ToString() + "','" + textBoxMobile.Text.ToString() + "','" + textBoxOther.Text.ToString() + "','" + textBoxEmail.Text + "','" + pictureBoxPhoto.Image + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //GenerateAutoId();  

                //    comboBoxCategory.SelectedIndex = 0;
                //    comboBoxGender.SelectedIndex = 0;
                //    textBoxVisitorId.Text = "";
                //    textBoxFirstName.Text = "";
                //    textBoxLastName.Text = "";
                //    textBoxOrganization.Text = "";
                //    textBoxDesignation.Text = "";
                //    //comboBoxCategory.Text = "";
                //    maskedTextBoxNicNumber.Text = "";
                //    //comboBoxGender.Text = "";
                //    textBoxPersonalAddress.Text = "";
                //    textBoxCompanyAddress.Text = "";
                //    textBoxEmail.Text = "";
                //    textBoxWorkPhone.Text = "";
                //    textBoxMobile.Text = "";
                //    textBoxOther.Text = "";
                //    pictureBoxPhoto.Image = null;


                    MessageBox.Show("Record Saved!");
                //    textBoxVisitorId.Focus();

                    disp_data();

                    AppointmentsForm appForm = new AppointmentsForm();
                    appForm.PassValue = textBoxVisitorId.Text;
                    appForm.ShowDialog();

                    //comboBoxCategory.SelectedIndex = 0;
                    //comboBoxGender.SelectedIndex = 0;
                    //textBoxVisitorId.Text = "";
                    //textBoxFirstName.Text = "";
                    //textBoxLastName.Text = "";
                    //textBoxOrganization.Text = "";
                    //textBoxDesignation.Text = "";
                    ////comboBoxCategory.Text = "";
                    //maskedTextBoxNicNumber.Text = "";
                    ////comboBoxGender.Text = "";
                    //textBoxPersonalAddress.Text = "";
                    //textBoxCompanyAddress.Text = "";
                    //textBoxEmail.Text = "";
                    //textBoxWorkPhone.Text = "";
                    //textBoxMobile.Text = "";
                    //textBoxOther.Text = "";
                    //pictureBoxPhoto.Image = null;


                }


                catch
                {
                    MessageBox.Show("There was an Error! Please re-enter the data");
                    textBoxVisitorId.Focus();
                }
                finally
                {
                    con.Close();
                }
            

            }

            private void buttonAddAppointment_Click(object sender, EventArgs e)
            {
                try
                {
                    AppointmentsForm appForm = new AppointmentsForm();
                    appForm.PassValue = textBoxVisitorId.Text;
                    appForm.ShowDialog();


                }
                catch 
                {
                    
                    MessageBox.Show("ERROR!");
                }
            }

            private void buttonViewHistory_Click(object sender, EventArgs e)
            {
                FormVisitorHistory history = new FormVisitorHistory();
                history.Show();
            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            //private void VisitorRegisterForm_LoadForSearchVisitor(object sender, EventArgs e)
            //{
            //    try
            //    {
            //        con.Open();
            //        SqlCommand cmd = con.CreateCommand();
            //        cmd.CommandType = CommandType.Text;
            //        cmd.CommandText = "select from Visitor where NicNumber='" + maskedTextBoxNicNumber.Text + "'";
            //        cmd.ExecuteNonQuery();
            //        con.Close();

            //        disp_data();

            //    }
            //    catch (Exception ex)
            //    {

            //        throw ex;
            //    }
            //    finally
            //    {
            //        con.Close();
            //    }
 
            //}

        }
    }

