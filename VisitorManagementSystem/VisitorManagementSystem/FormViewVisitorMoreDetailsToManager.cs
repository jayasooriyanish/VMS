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
    public partial class FormViewVisitorMoreDetailsToManager : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");

        public FormViewVisitorMoreDetailsToManager(string visitorId)
        {
            InitializeComponent();
            textBoxVisitorId.Text = visitorId;
        }

        

        private void FormViewVisitorMoreDetailsToManager_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Visitor where VisitorId='" + textBoxVisitorId.Text + "'";
                //cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBoxFirstName.Text = dr["FirstName"].ToString();
                    textBoxLastName.Text = dr["LastName"].ToString();
                    maskedTextBoxNicNumber.Text = dr["NicNumber"].ToString();
                    dateTimePickerDateOfBirth.Text = dr["DateOfBirth"].ToString();
                    textBoxOrganization.Text = dr["Organization"].ToString();
                    textBoxDesignation.Text = dr["Designation"].ToString();
                    comboBoxGender.Text = dr["Gender"].ToString();
                    textBoxPersonalAddress.Text = dr["PersonalAddress"].ToString();
                    textBoxCompanyAddress.Text = dr["CompanyAddress"].ToString();
                    textBoxWorkPhone.Text = dr["WorkPhone"].ToString();
                    textBoxMobile.Text = dr["Mobile"].ToString();
                    textBoxOther.Text = dr["Other"].ToString();
                    textBoxEmail.Text = dr["Email"].ToString();
                    comboBoxCategory.Text = dr["Category"].ToString();
                    //pictureBoxPhoto.Image =;

                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();

            }

        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            FormAppointmentsFromSearchToManager newfrm = new FormAppointmentsFromSearchToManager();
            newfrm.PassValue = textBoxVisitorId.Text;
            newfrm.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from Visitor where VisitorId='" + textBoxVisitorId.Text + "'";
                cmd.ExecuteNonQuery();

                textBoxVisitorId.Clear();
                textBoxFirstName.Clear();
                textBoxLastName.Clear();
                maskedTextBoxNicNumber.Clear();
                textBoxOrganization.Clear();
                textBoxDesignation.Clear();
                comboBoxCategory.SelectedIndex = 0;
                comboBoxGender.SelectedIndex = 0;
                dateTimePickerDateOfBirth.Value = DateTime.Now;
                textBoxPersonalAddress.Clear();
                textBoxCompanyAddress.Clear();
                textBoxEmail.Clear();
                textBoxWorkPhone.Clear();
                textBoxMobile.Clear();
                textBoxOther.Clear();
                pictureBoxPhoto.Image = null;



            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.Message);
            }

        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
