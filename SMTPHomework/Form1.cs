using System.Net;
using System.Net.Mail;

namespace SMTPHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            AttachmentTB.Text = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress(GmailIdTB.Text);
            MailAddress to = new MailAddress(SendToTB.Text);
            MailMessage message = new MailMessage(from, to);
            message.Subject = SubjectTb.Text;
            message.Body = MessageTB.Text;
            message.IsBodyHtml = false;
            message.Attachments.Add(new Attachment(AttachmentTB.Text));
            SmtpClient smtpClient = new SmtpClient(ServerAddressTB.Text, Convert.ToInt32(PortTB.Text));
            smtpClient.Credentials = new NetworkCredential(GmailIdTB.Text, "pcac kpnc agbj qvic");
            smtpClient.EnableSsl = true;
            try
            {
                smtpClient.Send(message);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}