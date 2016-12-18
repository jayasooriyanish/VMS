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
    public partial class VisitorFormToManager : Form
    {
        public VisitorFormToManager()
        {
            InitializeComponent();
        }

        private void buttonViewVisitor_Click(object sender, EventArgs e)
        {
            FormViewVisitorToManager view = new FormViewVisitorToManager();
            view.Show();
        }

        private void buttonSearchVisitor_Click(object sender, EventArgs e)
        {
            FormSearchVisitorToManager search = new FormSearchVisitorToManager();
            search.Show();
        }

        private void buttonRegisterVisitor_Click(object sender, EventArgs e)
        {
            FormRegisterFromVisitorFormToManager reg = new FormRegisterFromVisitorFormToManager();
            reg.Show();
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
