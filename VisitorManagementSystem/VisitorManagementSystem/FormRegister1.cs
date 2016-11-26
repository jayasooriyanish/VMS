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
    public partial class FormRegister1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");
        public FormRegister1()
        {
            InitializeComponent();
        }

        public void testc()
        {
            MessageBox.Show("HHHHHHH");
        }
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into table values('" + visitorIdTextBox.Text + "','" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "','" + nICNumberTextBox.Text + "','" + comboBoxCategory.Text + "','" + genderTextBox.Text + "','" + organizationTextBox.Text + "','" + designationTextBox.Text + "','" + dateOfBirthDateTimePicker.Text + "','" + listBoxPersonalAddress.Text + "','" + listBoxCompanyAddress.Text + "','" + emailTextBox.Text + "','" + workPhoneTextBox.Text + "','" + mobileTextBox.Text + "','" + otherTextBox.Text + "','" + imagePictureBox.Image + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Record Saved Successfully!");
        }

        public void disp_data()
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

            con.Close();


        
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            photoOpenFileDialog.FileName = "";
            if (photoOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = Image.FromFile(photoOpenFileDialog.FileName);
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void Load_FR(object sender, EventArgs e)
        {
            MessageBox.Show("2222");
        }
    }
}
