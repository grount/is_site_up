using System;
using System.Windows.Forms;

namespace is_site_up
{
    public partial class AddUrlForm : Form
    {
        public string m_Url { get; private set; }
        public bool m_IsUrlSelected { get; private set; }

        public AddUrlForm()
        {
            InitializeComponent();
            m_IsUrlSelected = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(m_Url))
            {
                m_IsUrlSelected = false;
                MessageBox.Show("Please enter a url", "No url is selected", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                m_IsUrlSelected = true;
                Close();
            }
        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {
            m_Url = urlTextBox.Text;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            m_IsUrlSelected = false;
        }
    }
}
