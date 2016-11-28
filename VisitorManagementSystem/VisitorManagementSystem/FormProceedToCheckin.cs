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
    public partial class FormProceedToCheckin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");
        private string id;


        public string PassValue
        {
            get { return id; }
            set { id = value; }
        }

        public FormProceedToCheckin()
        {
            InitializeComponent();
        }

        private void FormProceedToCheckin_Load(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrDrawer = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            
            try
            {
                textBoxVisitorId.Text = id;

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
                    textBoxNicNumber.Text = dr["NicNumber"].ToString();
                    textBoxOrganization.Text = dr["Organization"].ToString();
                    textBoxDesignation.Text = dr["Designation"].ToString();
                    //pictureBoxBarCode.Image = qrDrawer.Draw(dr["Barcode"].ToString(), pictureBoxBarCode.Height);
                }
                dr.Close();

                con.Close();
            }
            catch
            {
                MessageBox.Show("Error!");
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
