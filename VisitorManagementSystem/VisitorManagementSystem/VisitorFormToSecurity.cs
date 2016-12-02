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
    public partial class VisitorFormToSecurity : Form
    {
        public VisitorFormToSecurity()
        {
            InitializeComponent();
        }

        private void buttonSearchVisitor_Click(object sender, EventArgs e)
        {
            FormSearchVisitorToSecurity newfrm = new FormSearchVisitorToSecurity();
            newfrm.ShowDialog();
        }

        private void buttonViewVisitor_Click(object sender, EventArgs e)
        {
            FormViewVisitorToSecurity newfrm = new FormViewVisitorToSecurity();
            newfrm.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
