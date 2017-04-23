using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace is_site_up
{
    public partial class MainWindow : Form
    {
        private  string m_Url;
        private  bool m_IsUrlSelected;
        private  UrlCheck m_urlCheck;
        private SettingsForm m_settingsForm;
        private int m_retrySeconds;
        private bool m_isLoopClicked;
        private int m_index;

        public MainWindow()
        {
            InitializeComponent();
            m_IsUrlSelected = false;
            m_urlCheck = new UrlCheck();
            m_settingsForm = new SettingsForm();
            ActiveControl = siteUrlLabel;
            m_retrySeconds = m_settingsForm.m_retrySeconds;
            m_isLoopClicked = loopCheckBox.Checked;
        }

        private void addUrlButton_Click(object sender, EventArgs e)
        {
            AddUrlForm urlForm = new AddUrlForm();
            urlForm.ShowDialog();
            m_IsUrlSelected = urlForm.m_IsUrlSelected;

            if (m_IsUrlSelected)
            {
                m_Url = urlForm.m_Url;
                urlTextBox.Text = m_Url;
                m_urlCheck.m_Url = m_Url;
            }

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            checkTheSite();
            
        }

        private void checkTheSite()
        {
            if (m_IsUrlSelected)
            {
                bool isSiteUp = m_urlCheck.CheckIfSiteIsUp();

                statusButton.BackColor = isSiteUp ? Color.GreenYellow : Color.Red;

            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            m_settingsForm.ShowDialog();
        }

        private async void loopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            m_isLoopClicked = loopCheckBox.Checked;

            if (m_isLoopClicked)
            {
                toolStripRetryLabel.Text = "Time remaining untill refresh: ";
                retryTimer.Interval = m_retrySeconds * 1000;
                retryTimer.Enabled = true;
                await updateRetryTimeLeftAsync();
            }
        }

        private Task updateRetryTimeLeftAsync()
        {
            return Task.Factory.StartNew(updateRetryTimeLeft);
        }

        private async void updateRetryTimeLeft()
        {
            for (int m_index = m_retrySeconds; m_index >= 0; m_index--)
            {
                if (retryLabel.InvokeRequired)
                {
                    int time = m_index;
                    await Task.Delay(TimeSpan.FromSeconds(1));
                    retryLabel.BeginInvoke((MethodInvoker) delegate()
                    {
                        toolStripRetryLabel.Text =
                        $"Time remaining untill refresh: {time}";
                    });
                }
                else
                {
                    retryLabel.Text = m_index.ToString();
                }
            }
            retryLabel.BeginInvoke((MethodInvoker) delegate()
            {
                toolStripRetryLabel.Text = "Refreshing..";
            });
        }

        private async void retryTimer_Tick(object sender, EventArgs e)
        {
            if (m_index == 0)
            {
                await Task.Delay(TimeSpan.FromSeconds(1));
                checkTheSite();
                await updateRetryTimeLeftAsync();
            }
        }
    }
}
