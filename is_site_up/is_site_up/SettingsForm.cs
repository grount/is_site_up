using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_site_up
{
    public partial class SettingsForm : Form
    {
        public int m_retrySeconds { get; private set; }
        private int m_CurrentRetrySeconds { get; set; }
        public string m_EmailAddress { get; private set; }
        public string m_UserName { get; private set; }
        public string m_Password { get; private set; }

        public SettingsForm()
        {
            InitializeComponent();
            m_retrySeconds = retrySecondsTrackBar.Value;
            m_CurrentRetrySeconds = retrySecondsTrackBar.Value;
        }

        private void retrySecondsTrackBar_ValueChanged(object sender, EventArgs e)
        { 
            displayTrackBarLabel.Text = retrySecondsTrackBar.Value.ToString();
            m_CurrentRetrySeconds = retrySecondsTrackBar.Value;
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            m_EmailAddress = emailTextBox.Text;
        }

        private void generalOkButton_Click(object sender, EventArgs e)
        {
            m_retrySeconds = m_CurrentRetrySeconds;
            Close();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            m_UserName = usernameTextBox.Text;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            m_Password = passwordTextBox.Text;
        }

        // TODO add password show button with pressdown event and pressup event.
    }
}
