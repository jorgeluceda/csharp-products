namespace MultiSDIText
{
    partial class oathDialog
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
            this.middlePanel.BackColor = System.Drawing.Color.Transparent;
            this.middlePanel.Controls.Add(this.oathControl);
            this.middlePanel.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.middlePanel.Size = new System.Drawing.Size(914, 490);
            // 
            // oathControl
            // 
            this.oathControl.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.oathControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oathControl.ForeColor = System.Drawing.Color.DarkKhaki;
            this.oathControl.Location = new System.Drawing.Point(0, 0);
            this.oathControl.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.oathControl.Name = "oathControl";
            this.oathControl.Size = new System.Drawing.Size(914, 490);
            this.oathControl.TabIndex = 0;
            // 
            // oathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 703);
            this.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "oathDialog";
            this.ShowIcon = false;
            this.Text = "Oath DIalog";
            this.middlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CoreLibrary.oathControl oathControl;
    }
}