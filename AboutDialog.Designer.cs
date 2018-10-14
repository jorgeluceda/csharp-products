namespace SingleDocumentInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
            this.assignmentDescription = new System.Windows.Forms.Label();
            this.middlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // middlePanel
            // 
            this.middlePanel.Controls.Add(this.assignmentDescription);
            this.middlePanel.Size = new System.Drawing.Size(402, 212);
            // 
            // assignmentDescription
            // 
            this.assignmentDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assignmentDescription.Location = new System.Drawing.Point(0, 0);
            this.assignmentDescription.Name = "assignmentDescription";
            this.assignmentDescription.Size = new System.Drawing.Size(402, 212);
            this.assignmentDescription.TabIndex = 0;
            this.assignmentDescription.Text = resources.GetString("assignmentDescription.Text");
            this.assignmentDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 322);
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