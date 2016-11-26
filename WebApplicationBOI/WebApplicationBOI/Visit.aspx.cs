using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplicationBOI
{
    

    public partial class Visit : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=BOI;Integrated Security=True");
        string visitId = "Visit"; 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GenerateAutoId();
            }

        }

        private void GenerateAutoId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(VisitId) from Visit",con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            i++;
            TextBoxVisitId.Text = visitId + i.ToString();
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {

            //con.Open();
            //SqlCommand cmd = new SqlCommand("Insert into Visit(VisitId,InDate,OutDate,InTime,OutTime) values('"+TextBoxVisitId.Text+"','"+TextBoxInDate.Text+"','"+TextBoxOutDate.Text+"','"+TextBoxInTime.Text+"','"+TextBoxOutTime.Text+"')");
            //cmd.ExecuteNonQuery();
            //con.Close();
            //GenerateAutoId();
            //ClearTextBox();

        }

        private void ClearTextBox()
        {
            TextBoxInDate.Text = "";
            TextBoxOutDate.Text = "";
            TextBoxInTime.Text = "";
            TextBoxOutTime.Text = "";
        
        }
    }
}