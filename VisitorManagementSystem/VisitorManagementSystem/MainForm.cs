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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSearchVisitor_Click(object sender, EventArgs e)
        {
            VisitorForm formVisitor = new VisitorForm();
            formVisitor.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do You Want to Exit?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormRegister1 fr = new FormRegister1();
            fr.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void searchVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearchVisitor formSearch = new FormSearchVisitor();
            formSearch.ShowDialog();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormRegister1 fr = new FormRegister1();
            //fr.ShowDialog();

            VisitorRegisterForm objVisitorRegisterForm = new VisitorRegisterForm();
            objVisitorRegisterForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do You Want to Exit?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegisterVisitor_Click(object sender, EventArgs e)
        {
            FormVisitsAndAppointments formVisitAppointment = new FormVisitsAndAppointments();
            formVisitAppointment.ShowDialog();
            //    FormRegister1 register1 = new FormRegister1();
            //    //register1.testc();
            //    register1.Show();
            //MessageBox.Show("");
            //register1.Show();

            //VisitorRegisterForm objVisitorRegisterForm = new VisitorRegisterForm();
            //objVisitorRegisterForm.Show();


        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm emp = new EmployeeForm();
            emp.ShowDialog();
        }
    }
}
