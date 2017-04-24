using System.Net.Mail;

namespace is_site_up
{
    public class Email
    {
        private MailMessage m_Mail;
        public string m_EmailAddress { get; set; }

        public Email(string i_EmailAddress)
        {
            m_Mail = new MailMessage();
            m_EmailAddress = i_EmailAddress;
        }

        public bool CheckEmailValidation()
        {
            return !string.IsNullOrWhiteSpace(m_EmailAddress);
        }
    }
}
