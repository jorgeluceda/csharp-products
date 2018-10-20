namespace TextMDI
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
            this.middlePanel.Size = new System.Drawing.Size(457, 253);
            // 
            // oathControl
            // 
            this.oathControl.BackColor = System.Drawing.Color.Transparent;
            this.oathControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oathControl.Location = new System.Drawing.Point(0, 0);
            this.oathControl.Name = "oathControl";
            this.oathControl.Size = new System.Drawing.Size(457, 253);
            this.oathControl.TabIndex = 0;
            // 
            // oathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 363);
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