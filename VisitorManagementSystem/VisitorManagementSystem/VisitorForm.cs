using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisitorManagementSystem
{
    public partial class VisitorForm : Form
    {
        public VisitorForm()
        {
            InitializeComponent();
        }

        private void buttonRegisterVisitor_Click(object sender, EventArgs e)
        {
            VisitorRegisterForm newform = new VisitorRegisterForm();
            newform.ShowDialog();
        }

        private void buttonSearchVisitor_Click(object sender, EventArgs e)
        {
            FormSearchVisitor newSearch = new FormSearchVisitor();
            newSearch.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonViewVisitor_Click(object sender, EventArgs e)
        {
            FormViewVisitor viewVisitor = new FormViewVisitor();
            viewVisitor.ShowDialog();
        }
    }
}
