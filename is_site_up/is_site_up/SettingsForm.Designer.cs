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
            this.generalTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.retrySecondsTrackBar = new System.Windows.Forms.TrackBar();
            this.displayTrackBarLabel = new System.Windows.Forms.Label();
            this.generalTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retrySecondsTrackBar)).BeginInit();
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 197);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Email";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 223);
            this.Controls.Add(this.generalTabControl);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.generalTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retrySecondsTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl generalTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TrackBar retrySecondsTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label displayTrackBarLabel;
    }
}