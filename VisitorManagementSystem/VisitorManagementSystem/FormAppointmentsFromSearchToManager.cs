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
    public partial class FormAppointmentsFromSearchToManager : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");
        private string id;
        String AId = "SILAPP0";
        int[] barCode;

        private void GenerateAutoId()
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select Count(appointmentId) from Appointment", con);
            int i = Convert.ToInt32(cmd1.ExecuteScalar());
            con.Close();
            i++;
            textBoxAppointmentId.Text = AId + i.ToString();
        }


        public string PassValue
        {
            get { return id; }
            set { id = value; }
        }


        public FormAppointmentsFromSearchToManager()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonArrangeFacilities_Click(object sender, EventArgs e)
        {
            FormFacilitiesArrangementFromSearchToManager frm = new FormFacilitiesArrangementFromSearchToManager();
            frm.Show();
        }

        private void buttonConfirmVisit_Click(object sender, EventArgs e)
        {
            FormVisitConfirmation confirm = new FormVisitConfirmation();
            confirm.PassEmail = textBoxEmail.Text;
            confirm.Show();
        }

        private void FormVisitorRegisterFromSearchToManager_Load(object sender, EventArgs e)
        {
            GenerateAutoId();
            textBoxVisitorId.Text = id;
            comboBoxStatus.SelectedIndex = 0;

            barCode = new int[5] { 0, 0, 0, 0, 0 };

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Visitor where VisitorId='" + textBoxVisitorId.Text + "'";

                Object VisitorExist = cmd.ExecuteScalar();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
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
                    //pictureBoxPhoto.Image =;

                }
                dr.Close();


                con.Close();

                //dateTimePickerFromDate.Focus();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            groupBoxAppointments.Enabled = true;
            GenerateAutoId();
            comboBoxStatus.SelectedIndex = 0;
            dateTimePickerFromDate.Value = DateTime.Now;
            dateTimePickerFromTime.Value = DateTime.Now;
            dateTimePickerToDate.Value = DateTime.Now;
            dateTimePickerToTime.Value = DateTime.Now;
            textBoxPurpose.Clear();
            textBoxEmployeeId.Clear();
            textBoxEmployeeFirstName.Clear();
            textBoxEmployeeLastName.Clear();
            checkBoxNeedAccomodation.Checked = false;
            checkBoxNeedVehicles.Checked = false;
            dateTimePickerFromDate.Focus();
        }

        private void buttonSaveAppointment_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Appointment(AppointmentId,FromDate,FromTime,Purpose,VisitorId,VisitorFirstName,VisitorLastName,EmployeeId,FirstName,LastName,NeedAccomodation,NeedVehicles,ToDate,ToTime,Status,CheckedIn,CheckedOut) values('" + textBoxAppointmentId.Text + "','" + dateTimePickerFromDate.Text.ToString() + "','" + dateTimePickerFromTime.Text.ToString() + "','" + textBoxPurpose.Text + "','" + textBoxVisitorId.Text + "','" + textBoxFirstName.Text + "','" + textBoxLastName.Text + "','" + textBoxEmployeeId.Text + "','" + textBoxEmployeeFirstName.Text + "','" + textBoxEmployeeLastName.Text + "','" + checkBoxNeedAccomodation.Checked + "','" + checkBoxNeedVehicles.Checked + "','" + dateTimePickerToDate.Text.ToString() + "','" + dateTimePickerToTime.Text.ToString() + "','" + comboBoxStatus.Text + "','"+checkBoxCheckedIn.Checked+"','"+checkBoxCheckedOut.Checked+"')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Saved!");
                comboBoxStatus.SelectedIndex = 0;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete * From Appointment where AppointmentId = '"+textBoxAppointmentId.Text+"'";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Deleted!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxPurpose.Clear();
            textBoxEmployeeId.Clear();
            textBoxEmployeeFirstName.Clear();
            textBoxEmployeeLastName.Clear();
            dateTimePickerFromDate.Value = DateTime.Now;
            dateTimePickerToDate.Value = DateTime.Now;
            dateTimePickerFromTime.Value = DateTime.Now;
            dateTimePickerToTime.Value = DateTime.Now;
            checkBoxNeedVehicles.Checked = false;
            checkBoxNeedAccomodation.Checked = false;
            checkBoxCheckedIn.Checked = false;
            checkBoxCheckedOut.Checked = false;
            comboBoxStatus.SelectedIndex = 0;

            
        }

        private void panelAppointments_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxEmployeeId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Employee where EmployeeId='" + textBoxEmployeeId.Text + "'";
                //cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBoxEmployeeFirstName.Text = dr["FirstName"].ToString();
                    textBoxEmployeeLastName.Text = dr["LastName"].ToString();
                }
                dr.Close();

                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void checkBoxA1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == true)
            {
                barCode[0] = 1;
            }
            else
            {
                barCode[0] = 0;
            }
        }

        private void checkBoxA2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == true)
            {
                barCode[1] = 1;
            }
            else
            {
                barCode[1] = 0;
            }
        }

        private void checkBoxA3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == true)
            {
                barCode[2] = 1;
            }
            else
            {
                barCode[2] = 0;
            }
        }

        private void checkBoxA4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == true)
            {
                barCode[3] = 1;
            }
            else
            {
                barCode[3] = 0;
            }
        }

        private void checkBoxA5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == true)
            {
                barCode[4] = 1;
            }
            else
            {
                barCode[4] = 0;
            }
        }
    }
}
