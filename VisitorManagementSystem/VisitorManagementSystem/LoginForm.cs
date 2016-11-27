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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            postInit();
        }

        private void postInit()
        {
            this.forgotPasswordbutton.TabStop = false;
            this.forgotPasswordbutton.FlatStyle = FlatStyle.Flat;
            this.forgotPasswordbutton.FlatAppearance.BorderSize = 0;
            this.forgotPasswordbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }
        private void forgotPasswordbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
