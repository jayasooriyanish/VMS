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
    public partial class FormVisitorRegisterFromSearchToSecurity : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=NISH\SQLSERVER;Initial Catalog=VMS;Integrated Security=True");
        public FormVisitorRegisterFromSearchToSecurity()
        {
            InitializeComponent();
        }

        private void FormVisitorRegisterFromSearchToSecurity_Load(object sender, EventArgs e)
        {

        }

        private void buttonProceedToCheckin_Click(object sender, EventArgs e)
        {
            FormProceedToCheckin newCheckinForm = new FormProceedToCheckin();
            newCheckinForm.PassValue = textBoxVisitorId.Text;
            newCheckinForm.ShowDialog();
        }
    }
}
