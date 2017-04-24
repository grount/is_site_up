namespace is_site_up
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.generalTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.generalCancelButton = new System.Windows.Forms.Button();
            this.generalOkButton = new System.Windows.Forms.Button();
            this.displayTrackBarLabel = new System.Windows.Forms.Label();
            this.retrySecondsTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.emailCancelButton = new System.Windows.Forms.Button();
            this.emailOkButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.generalTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retrySecondsTrackBar)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // generalTabControl
            // 
            this.generalTabControl.Controls.Add(this.tabPage1);
            this.generalTabControl.Controls.Add(this.tabPage2);
            this.generalTabControl.Location = new System.Drawing.Point(1, 1);
            this.generalTabControl.Name = "generalTabControl";
            this.generalTabControl.SelectedIndex = 0;
            this.generalTabControl.Size = new System.Drawing.Size(434, 223);
            this.generalTabControl.TabIndex = 0;
            this.generalTabControl.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.generalCancelButton);
            this.tabPage1.Controls.Add(this.generalOkButton);
            this.tabPage1.Controls.Add(this.displayTrackBarLabel);
            this.tabPage1.Controls.Add(this.retrySecondsTrackBar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 197);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // generalCancelButton
            // 
            this.generalCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.generalCancelButton.Location = new System.Drawing.Point(195, 94);
            this.generalCancelButton.Name = "generalCancelButton";
            this.generalCancelButton.Size = new System.Drawing.Size(75, 23);
            this.generalCancelButton.TabIndex = 13;
            this.generalCancelButton.Text = "Cancel";
            this.generalCancelButton.UseVisualStyleBackColor = true;
            // 
            // generalOkButton
            // 
            this.generalOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.generalOkButton.Location = new System.Drawing.Point(114, 94);
            this.generalOkButton.Name = "generalOkButton";
            this.generalOkButton.Size = new System.Drawing.Size(75, 23);
            this.generalOkButton.TabIndex = 12;
            this.generalOkButton.Text = "OK";
            this.generalOkButton.UseVisualStyleBackColor = true;
            this.generalOkButton.Click += new System.EventHandler(this.generalOkButton_Click);
            // 
            // displayTrackBarLabel
            // 
            this.displayTrackBarLabel.AutoSize = true;
            this.displayTrackBarLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTrackBarLabel.Location = new System.Drawing.Point(348, 10);
            this.displayTrackBarLabel.Name = "displayTrackBarLabel";
            this.displayTrackBarLabel.Size = new System.Drawing.Size(21, 15);
            this.displayTrackBarLabel.TabIndex = 11;
            this.displayTrackBarLabel.Text = "10";
            // 
            // retrySecondsTrackBar
            // 
            this.retrySecondsTrackBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.retrySecondsTrackBar.LargeChange = 10;
            this.retrySecondsTrackBar.Location = new System.Drawing.Point(164, 7);
            this.retrySecondsTrackBar.Maximum = 60;
            this.retrySecondsTrackBar.Minimum = 10;
            this.retrySecondsTrackBar.Name = "retrySecondsTrackBar";
            this.retrySecondsTrackBar.Size = new System.Drawing.Size(179, 45);
            this.retrySecondsTrackBar.TabIndex = 10;
            this.retrySecondsTrackBar.Value = 10;
            this.retrySecondsTrackBar.ValueChanged += new System.EventHandler(this.retrySecondsTrackBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Retry after amount of seconds";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.emailCancelButton);
            this.tabPage2.Controls.Add(this.emailOkButton);
            this.tabPage2.Controls.Add(this.passwordTextBox);
            this.tabPage2.Controls.Add(this.usernameTextBox);
            this.tabPage2.Controls.Add(this.passwordLabel);
            this.tabPage2.Controls.Add(this.usernameLabel);
            this.tabPage2.Controls.Add(this.emailTextBox);
            this.tabPage2.Controls.Add(this.emailAddressLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 197);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Email";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // emailCancelButton
            // 
            this.emailCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.emailCancelButton.Location = new System.Drawing.Point(185, 94);
            this.emailCancelButton.Name = "emailCancelButton";
            this.emailCancelButton.Size = new System.Drawing.Size(75, 23);
            this.emailCancelButton.TabIndex = 7;
            this.emailCancelButton.Text = "Cancel";
            this.emailCancelButton.UseVisualStyleBackColor = true;
            // 
            // emailOkButton
            // 
            this.emailOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.emailOkButton.Location = new System.Drawing.Point(104, 94);
            this.emailOkButton.Name = "emailOkButton";
            this.emailOkButton.Size = new System.Drawing.Size(75, 23);
            this.emailOkButton.TabIndex = 6;
            this.emailOkButton.Text = "OK";
            this.emailOkButton.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(90, 55);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(212, 20);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(90, 29);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(212, 20);
            this.usernameTextBox.TabIndex = 4;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(4, 60);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(4, 34);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(61, 13);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "User name:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(90, 3);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(212, 20);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Location = new System.Drawing.Point(4, 7);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(79, 13);
            this.emailAddressLabel.TabIndex = 0;
            this.emailAddressLabel.Text = "Email Address: ";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 152);
            this.Controls.Add(this.generalTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.generalTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retrySecondsTrackBar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl generalTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TrackBar retrySecondsTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label displayTrackBarLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button emailCancelButton;
        private System.Windows.Forms.Button emailOkButton;
        private System.Windows.Forms.Button generalCancelButton;
        private System.Windows.Forms.Button generalOkButton;
    }
}