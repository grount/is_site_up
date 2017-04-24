namespace is_site_up
{
    partial class HelpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.helpTabControl = new System.Windows.Forms.TabControl();
            this.instructionTabPage = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.aboutTabPage = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.helpTabControl.SuspendLayout();
            this.instructionTabPage.SuspendLayout();
            this.aboutTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpTabControl
            // 
            this.helpTabControl.Controls.Add(this.instructionTabPage);
            this.helpTabControl.Controls.Add(this.aboutTabPage);
            this.helpTabControl.Location = new System.Drawing.Point(1, 1);
            this.helpTabControl.Name = "helpTabControl";
            this.helpTabControl.SelectedIndex = 0;
            this.helpTabControl.Size = new System.Drawing.Size(406, 186);
            this.helpTabControl.TabIndex = 0;
            // 
            // instructionTabPage
            // 
            this.instructionTabPage.Controls.Add(this.textBox1);
            this.instructionTabPage.Location = new System.Drawing.Point(4, 22);
            this.instructionTabPage.Name = "instructionTabPage";
            this.instructionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.instructionTabPage.Size = new System.Drawing.Size(398, 160);
            this.instructionTabPage.TabIndex = 0;
            this.instructionTabPage.Text = "Instructions";
            this.instructionTabPage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 160);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "In order to send mail the site needs to be down.\r\nYou need to check the loop chec" +
    "kbox and click the email button.\r\nFill your email in the settings window.\r\n";
            // 
            // aboutTabPage
            // 
            this.aboutTabPage.Controls.Add(this.textBox2);
            this.aboutTabPage.Location = new System.Drawing.Point(4, 22);
            this.aboutTabPage.Name = "aboutTabPage";
            this.aboutTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.aboutTabPage.Size = new System.Drawing.Size(398, 160);
            this.aboutTabPage.TabIndex = 1;
            this.aboutTabPage.Text = "About";
            this.aboutTabPage.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(398, 160);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Is Site Up\r\nWritten by Daniel Gront, 2017.\r\n";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 188);
            this.Controls.Add(this.helpTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Help";
            this.helpTabControl.ResumeLayout(false);
            this.instructionTabPage.ResumeLayout(false);
            this.instructionTabPage.PerformLayout();
            this.aboutTabPage.ResumeLayout(false);
            this.aboutTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl helpTabControl;
        private System.Windows.Forms.TabPage instructionTabPage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage aboutTabPage;
        private System.Windows.Forms.TextBox textBox2;
    }
}