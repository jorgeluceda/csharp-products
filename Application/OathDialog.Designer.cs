namespace Application
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
            this.oathControl1 = new CoreLibrary.oathControl();
            this.middlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // middlePanel
            // 
            this.middlePanel.BackColor = System.Drawing.Color.Transparent;
            this.middlePanel.Controls.Add(this.oathControl1);
            this.middlePanel.Size = new System.Drawing.Size(414, 210);
            // 
            // oathControl1
            // 
            this.oathControl1.BackColor = System.Drawing.Color.Transparent;
            this.oathControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oathControl1.Location = new System.Drawing.Point(0, 0);
            this.oathControl1.Name = "oathControl1";
            this.oathControl1.Size = new System.Drawing.Size(414, 210);
            this.oathControl1.TabIndex = 0;
            // 
            // OathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Application.Properties.Resources.grilled;
            this.ClientSize = new System.Drawing.Size(414, 320);
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

        private CoreLibrary.oathControl oathControl1;
    }
}