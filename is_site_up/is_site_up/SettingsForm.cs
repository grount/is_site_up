﻿using System;
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
        public string m_EmailAddress { get; private set; }

        public SettingsForm()
        {
            InitializeComponent();
            m_retrySeconds = 10;
        }

        private void retrySecondsTrackBar_ValueChanged(object sender, EventArgs e)
        { 
            displayTrackBarLabel.Text = retrySecondsTrackBar.Value.ToString();
            m_retrySeconds = retrySecondsTrackBar.Value;
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            m_EmailAddress = emailTextBox.Text;
        }
    }
}
