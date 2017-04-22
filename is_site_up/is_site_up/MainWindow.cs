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
    public partial class MainWindow : Form
    {
        private string m_Url;
        private bool m_IsUrlSelected;
        private UrlCheck urlCheck;

        public MainWindow()
        {
            InitializeComponent();
            m_IsUrlSelected = false;
            urlCheck = new UrlCheck();

            this.ActiveControl = siteUrlLabel;
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
                urlCheck.m_Url = m_Url;
            }

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (m_IsUrlSelected)
            {
                bool isSiteUp = urlCheck.CheckIfSiteIsUp();

                statusButton.BackColor = isSiteUp ? Color.GreenYellow : Color.Red;

            }
        }
    }
}
