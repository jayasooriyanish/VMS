using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


namespace VisitorManagementSystem
{
    
    

    public partial class FormVisitConfirmation : Form
    {
        private string email;
        public string PassEmail
        {
            get { return email; }
            set { 
                email = value;
                textBoxEmail.Text = value;
            }

        }
        public FormVisitConfirmation()
        {
            InitializeComponent();
        }

        private void buttonInformVisitor_Click(object sender, EventArgs e)
        {
            sendMail(email);

        }

        private void sendMail(string to)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("jayasooriyanish@gmail.com");
                mail.To.Add(to);
                mail.Subject = "Test Mail";
                mail.Body = "This is for testing SMTP mail from GMAIL";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("jayasooriyanish@gmail.com", "Managenadithamaduranga");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Mail Sent Successfully ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void FormVisitConfirmation_Load(object sender, EventArgs e)
        {

        }
    }
}
