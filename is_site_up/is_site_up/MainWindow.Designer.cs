﻿namespace is_site_up
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.siteUrlLabel = new System.Windows.Forms.Label();
            this.addUrlButton = new System.Windows.Forms.ToolStripButton();
            this.settingsButton = new System.Windows.Forms.ToolStripButton();
            this.checkButton = new System.Windows.Forms.ToolStripButton();
            this.statusButton = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUrlButton,
            this.settingsButton,
            this.checkButton});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(473, 58);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(56, 79);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.ReadOnly = true;
            this.urlTextBox.Size = new System.Drawing.Size(377, 20);
            this.urlTextBox.TabIndex = 1;
            // 
            // siteUrlLabel
            // 
            this.siteUrlLabel.AutoSize = true;
            this.siteUrlLabel.Location = new System.Drawing.Point(3, 82);
            this.siteUrlLabel.Name = "siteUrlLabel";
            this.siteUrlLabel.Size = new System.Drawing.Size(50, 13);
            this.siteUrlLabel.TabIndex = 2;
            this.siteUrlLabel.Text = "Site URL";
            // 
            // addUrlButton
            // 
            this.addUrlButton.AutoSize = false;
            this.addUrlButton.Image = ((System.Drawing.Image)(resources.GetObject("addUrlButton.Image")));
            this.addUrlButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addUrlButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addUrlButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addUrlButton.Name = "addUrlButton";
            this.addUrlButton.Size = new System.Drawing.Size(50, 55);
            this.addUrlButton.Text = "Add URL";
            this.addUrlButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addUrlButton.Click += new System.EventHandler(this.addUrlButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.AutoSize = false;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(50, 55);
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // checkButton
            // 
            this.checkButton.AutoSize = false;
            this.checkButton.Image = global::is_site_up.Resource.check;
            this.checkButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.checkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(50, 55);
            this.checkButton.Text = "Check";
            this.checkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkButton.ToolTipText = "Check Site";
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // statusButton
            // 
            this.statusButton.Enabled = false;
            this.statusButton.Location = new System.Drawing.Point(439, 78);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(22, 22);
            this.statusButton.TabIndex = 4;
            this.statusButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(473, 207);
            this.Controls.Add(this.statusButton);
            this.Controls.Add(this.siteUrlLabel);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.toolStrip);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Is Site Up";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton addUrlButton;
        private System.Windows.Forms.ToolStripButton settingsButton;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label siteUrlLabel;
        private System.Windows.Forms.ToolStripButton checkButton;
        private System.Windows.Forms.Button statusButton;
    }
}

