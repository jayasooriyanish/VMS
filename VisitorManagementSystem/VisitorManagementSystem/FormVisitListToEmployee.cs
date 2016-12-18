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
    public partial class FormVisitListToEmployee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");

        public FormVisitListToEmployee()
        {
            InitializeComponent();
        }

        private void FormVisitListToEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Visit";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewVisitList.DataSource = dt;

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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
