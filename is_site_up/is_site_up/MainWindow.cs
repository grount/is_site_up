﻿using System;
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
        private string m_Url;
        private bool m_IsUrlSelected;
        private readonly UrlCheck m_UrlCheck;
        private readonly SettingsForm m_SettingsForm;
        private readonly int m_RetrySeconds;
        private bool m_IsLoopClicked;
        private readonly bool m_IsSiteUp;
        private readonly Email m_email;

        public MainWindow()
        {
            InitializeComponent();
            m_IsUrlSelected = false;
            m_UrlCheck = new UrlCheck();
            m_SettingsForm = new SettingsForm();
            ActiveControl = siteUrlLabel;
            m_RetrySeconds = m_SettingsForm.m_retrySeconds;
            m_IsLoopClicked = loopCheckBox.Checked;
            m_IsSiteUp = false;
            m_email = new Email(m_SettingsForm.m_EmailAddress);
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
                m_UrlCheck.m_Url = m_Url;
            }
        }

        private async void checkButton_Click(object sender, EventArgs e)
        {
            checkTheSite();
            loopCheckBox.Enabled = !m_IsSiteUp;

            if (m_IsLoopClicked)
            {
                await updateRetryTimeLeftAsync();
            }
        }

        private void checkTheSite()
        {
            if (m_IsUrlSelected)
            {
                bool isSiteUp = m_UrlCheck.CheckIfSiteIsUp();

                statusButton.BackColor = isSiteUp ? Color.GreenYellow : Color.Red;
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            m_SettingsForm.ShowDialog();
        }

        private void loopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            m_IsLoopClicked = loopCheckBox.Checked;
            emailButton.Enabled = true;
        }

        private Task updateRetryTimeLeftAsync()
        {
            return Task.Factory.StartNew(updateRetryTimeLeft);
        }

        private async void updateRetryTimeLeft()
        {
            for (int i = m_RetrySeconds; i >= 0; i--)
            {
                if (retryLabel.InvokeRequired)
                {
                    int time = i;
                    await Task.Delay(TimeSpan.FromSeconds(1));
                    retryLabel.BeginInvoke((MethodInvoker) delegate()
                    {
                        toolStripRetryLabel.Text =
                        $"Time remaining untill refresh: {time}";
                    });

                    if (i == 0)
                    {
                        retryLoopChecking();
                    }
                }
                else
                {
                    retryLabel.Text = i.ToString();
                }
            }
            retryLabel.BeginInvoke((MethodInvoker) delegate()
            {
                toolStripRetryLabel.Text = "Refreshing..";
            });
        }

        private async void retryLoopChecking()
        {
            checkTheSite();

            if (!m_IsSiteUp)
            {
                await updateRetryTimeLeftAsync();
            }
            else // TOOD notify via email
            {
                
            }
        
        }
    }
}
