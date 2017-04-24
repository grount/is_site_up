using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace is_site_up
{
    public class Email
    {

        private string m_Website { get; set; }
        private string m_EmailAddress { get; set; }
        private string m_Username { get; set; }
        private string m_Password { get; set; }

        public Email(string i_EmailAddress, string i_Website, string i_Username, string i_Password)
        {
            m_EmailAddress = i_EmailAddress;
            m_Website = i_Website;
            m_Username = i_Username;
            m_Password = i_Password;
        }

        public void SendEmail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(m_EmailAddress);
                mail.To.Add(m_EmailAddress);
                mail.Subject = "Your site is up!";
                mail.Body = $"The site {m_Website} is up and running.";

                smtpServer.Port = 587;
                smtpServer.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                smtpServer.Credentials = new NetworkCredential(m_Username, m_Password);
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);
                MessageBox.Show("Mail sent");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
