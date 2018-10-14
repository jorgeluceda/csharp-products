namespace SingleDocumentInterface
{
    partial class OathDialog
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
            this.oathControl = new CoreLibrary.oathControl();
            this.middlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // middlePanel
            // 
            this.middlePanel.Controls.Add(this.oathControl);
            this.middlePanel.Size = new System.Drawing.Size(403, 237);
            // 
            // oathControl
            // 
            this.oathControl.BackColor = System.Drawing.Color.Transparent;
            this.oathControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oathControl.Location = new System.Drawing.Point(0, 0);
            this.oathControl.Name = "oathControl";
            this.oathControl.Size = new System.Drawing.Size(403, 237);
            this.oathControl.TabIndex = 0;
            // 
            // OathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 347);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OathDialog";
            this.ShowIcon = false;
            this.Text = "OathDialog";
            this.middlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CoreLibrary.oathControl oathControl;
    }
}