namespace MultiSDIContact
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
            this.teamDescription = new CoreLibrary.teamDescription2();
            this.courseControl1 = new CoreLibrary.courseControl();
            this.oathControl = new CoreLibrary.oathControl();
            this.SuspendLayout();
            // 
            // teamDescription
            // 
            this.teamDescription.BackColor = System.Drawing.Color.CornflowerBlue;
            this.teamDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.teamDescription.Location = new System.Drawing.Point(0, 272);
            this.teamDescription.Name = "teamDescription";
            this.teamDescription.Size = new System.Drawing.Size(455, 73);
            this.teamDescription.TabIndex = 0;
            // 
            // courseControl1
            // 
            this.courseControl1.BackColor = System.Drawing.Color.Transparent;
            this.courseControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseControl1.Location = new System.Drawing.Point(0, 0);
            this.courseControl1.Name = "courseControl1";
            this.courseControl1.Size = new System.Drawing.Size(455, 54);
            this.courseControl1.TabIndex = 1;
            // 
            // oathControl
            // 
            this.oathControl.BackColor = System.Drawing.Color.Transparent;
            this.oathControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oathControl.Location = new System.Drawing.Point(0, 54);
            this.oathControl.Name = "oathControl";
            this.oathControl.Size = new System.Drawing.Size(455, 218);
            this.oathControl.TabIndex = 2;
            // 
            // oathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 345);
            this.Controls.Add(this.oathControl);
            this.Controls.Add(this.courseControl1);
            this.Controls.Add(this.teamDescription);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "oathDialog";
            this.ShowIcon = false;
            this.Text = "Oath";
            this.ResumeLayout(false);

        }

        #endregion

        private CoreLibrary.teamDescription2 teamDescription;
        private CoreLibrary.courseControl courseControl1;
        private CoreLibrary.oathControl oathControl;
    }
}