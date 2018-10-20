namespace TextMDI
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
            this.aboutDescription = new System.Windows.Forms.Label();
            this.aboutInfo = new System.Windows.Forms.Label();
            this.middlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // middlePanel
            // 
            this.middlePanel.BackColor = System.Drawing.Color.Transparent;
            this.middlePanel.Controls.Add(this.aboutInfo);
            this.middlePanel.Size = new System.Drawing.Size(442, 243);
            // 
            // aboutDescription
            // 
            this.aboutDescription.BackColor = System.Drawing.Color.Transparent;
            this.aboutDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutDescription.Location = new System.Drawing.Point(0, 0);
            this.aboutDescription.Name = "aboutDescription";
            this.aboutDescription.Size = new System.Drawing.Size(442, 353);
            this.aboutDescription.TabIndex = 1;
            this.aboutDescription.Text = "A Multi-Document application that draws text, as text objects, using data binding" +
    " to connect to a text options dialog.";
            this.aboutDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutInfo
            // 
            this.aboutInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutInfo.Location = new System.Drawing.Point(0, 0);
            this.aboutInfo.Name = "aboutInfo";
            this.aboutInfo.Size = new System.Drawing.Size(442, 243);
            this.aboutInfo.TabIndex = 0;
            this.aboutInfo.Text = "A Multi-Document application that draws text, as text objects, using data binding" +
    " to connect to a text options dialog.";
            this.aboutInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 353);
            this.Controls.Add(this.aboutDescription);
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