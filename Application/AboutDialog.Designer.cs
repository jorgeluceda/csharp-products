namespace Application
{
    partial class AboutDialog
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
            this.assignmentDescription = new System.Windows.Forms.Label();
            this.middlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // middlePanel
            // 
            this.middlePanel.BackColor = System.Drawing.Color.Transparent;
            this.middlePanel.Controls.Add(this.assignmentDescription);
            this.middlePanel.Size = new System.Drawing.Size(411, 213);
            // 
            // assignmentDescription
            // 
            this.assignmentDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assignmentDescription.Location = new System.Drawing.Point(0, 0);
            this.assignmentDescription.Name = "assignmentDescription";
            this.assignmentDescription.Size = new System.Drawing.Size(411, 213);
            this.assignmentDescription.TabIndex = 0;
            this.assignmentDescription.Text = "Assignment 3 (Part B) is an extension of Part A. This time,\r\nwe\'re adding MDI fun" +
    "ctionality, as well as StatusStrips,\r\nToolTips, Help Information, and Shortcut K" +
    "eys";
            this.assignmentDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Application.Properties.Resources.grilled;
            this.ClientSize = new System.Drawing.Size(411, 323);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.ShowIcon = false;
            this.Text = "AboutDialog";
            this.middlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label assignmentDescription;
    }
}