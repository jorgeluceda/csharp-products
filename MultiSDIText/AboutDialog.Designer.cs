﻿namespace MultiSDIText
{
    partial class aboutDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutDialog));
            this.aboutDescription = new System.Windows.Forms.Label();
            this.aboutInfo = new System.Windows.Forms.Label();
            this.middlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // middlePanel
            // 
            this.middlePanel.BackColor = System.Drawing.Color.Transparent;
            this.middlePanel.Controls.Add(this.aboutInfo);
            this.middlePanel.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.middlePanel.Size = new System.Drawing.Size(884, 471);
            // 
            // aboutDescription
            // 
            this.aboutDescription.BackColor = System.Drawing.Color.Transparent;
            this.aboutDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutDescription.Location = new System.Drawing.Point(0, 87);
            this.aboutDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.aboutDescription.Name = "aboutDescription";
            this.aboutDescription.Size = new System.Drawing.Size(884, 471);
            this.aboutDescription.TabIndex = 1;
            this.aboutDescription.Text = "A Multi-Document application that draws text, as text objects, using data binding" +
    " to connect to a text options dialog.";
            this.aboutDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutInfo
            // 
            this.aboutInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutInfo.Location = new System.Drawing.Point(0, 0);
            this.aboutInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.aboutInfo.Name = "aboutInfo";
            this.aboutInfo.Size = new System.Drawing.Size(884, 471);
            this.aboutInfo.TabIndex = 0;
            this.aboutInfo.Text = resources.GetString("aboutInfo.Text");
            this.aboutInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 684);
            this.Controls.Add(this.aboutDescription);
            this.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "aboutDialog";
            this.ShowIcon = false;
            this.Text = "About Dialog";
            this.Controls.SetChildIndex(this.aboutDescription, 0);
            this.Controls.SetChildIndex(this.middlePanel, 0);
            this.middlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label aboutDescription;
        private System.Windows.Forms.Label aboutInfo;
    }
}