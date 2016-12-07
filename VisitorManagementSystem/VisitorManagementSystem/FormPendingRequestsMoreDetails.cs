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
    public partial class FormPendingRequestsMoreDetails : Form
    {
        int[] barCode;
        public FormPendingRequestsMoreDetails()
        {
            InitializeComponent();
        }

        private void FormPendingRequestsForApproval_Load(object sender, EventArgs e)
        {
            barCode = new int[5]{0,0,0,0,0};
        }

        private void checkBoxArea1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == true)
            {
                barCode[0] = 1;
            }
            else
            {
                barCode[0] = 0;
            }
        }

        private void checkBoxArea2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == true)
            {
                barCode[1] = 1;
            }
            else
            {
                barCode[1] = 0;
            }

        }

        private void checkBoxArea3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == true)
            {
                barCode[2] = 1;
            }
            else
            {
                barCode[2] = 0;
            }

        }

        private void checkBoxArea4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == true)
            {
                barCode[3] = 1;
            }
            else
            {
                barCode[3] = 0;
            }
        }

        private void checkBoxArea5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == true)
            {
                barCode[4] = 1;
            }
            else
            {
                barCode[4] = 0;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string barCodeString = string.Join("", barCode); ;
            Console.Write(barCodeString);
        }
    }
}
