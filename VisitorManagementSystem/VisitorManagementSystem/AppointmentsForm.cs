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
    public partial class AppointmentsForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");
        private string id;



        public string PassValue
        {
            get { return id; }
            set { id = value; }
        }

        public AppointmentsForm()
        {
            InitializeComponent();
        }

        private void AppointmentsForm_Load(object sender, EventArgs e)
        {

            textBoxVisitorId.Text = id;
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText ="select * from Visitor where VisitorId='"+textBoxVisitorId.Text+"'";
                //cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBoxFirstName.Text = dr["FirstName"].ToString();
                    textBoxLastName.Text = dr["LastName"].ToString();
                    maskedTextBoxNicNumber.Text = dr["NicNumber"].ToString();
                    dateTimePickerDateOfBirth.Text = dr["DateOfBirth"].ToString();
                    textBoxCategory.Text = dr["Category"].ToString();
                    textBoxOrganization.Text = dr["Organization"].ToString();
                    textBoxDesignation.Text = dr["Designation"].ToString();
                    textBoxGender.Text = dr["Gender"].ToString();
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
                dateTimePickerFromDate.Focus();

            }
            catch 
            {
                
                MessageBox.Show("Error!");
            }

        }

        private void buttonArrangeFacilities_Click(object sender, EventArgs e)
        {
            FormFacilitiesArrangement newfacilitiesform = new FormFacilitiesArrangement();
            newfacilitiesform.ShowDialog();
        }

        private void buttonConfirmVisit_Click(object sender, EventArgs e)
        {
            FormVisitConfirmation newConfirmationForm = new FormVisitConfirmation();
            newConfirmationForm.ShowDialog();
        }

        private void buttonCAncelVisit_Click(object sender, EventArgs e)
        {
            FormVisitConfirmation newConfirmationForm = new FormVisitConfirmation();
            newConfirmationForm.ShowDialog();
        }

        //public string ImageToBase64(Image image,
        //                    System.Drawing.Imaging.ImageFormat format)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        // Convert Image to byte[]
        //        image.Save(ms, format);
        //        byte[] imageBytes = ms.ToArray();

        //        // Convert byte[] to Base64 String
        //        string base64String = Convert.ToBase64String(imageBytes);
        //        return base64String;
        //    }
        //}
    }
}
