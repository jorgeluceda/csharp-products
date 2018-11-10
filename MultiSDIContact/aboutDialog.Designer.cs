namespace MultiSDIContact
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
            this.teamDescription2 = new CoreLibrary.teamDescription2();
            this.courseControl = new CoreLibrary.courseControl();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teamDescription2
            // 
            this.teamDescription2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teamDescription2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.teamDescription2.Location = new System.Drawing.Point(0, 266);
            this.teamDescription2.Name = "teamDescription2";
            this.teamDescription2.Size = new System.Drawing.Size(454, 83);
            this.teamDescription2.TabIndex = 0;
            // 
            // courseControl
            // 
            this.courseControl.BackColor = System.Drawing.Color.Transparent;
            this.courseControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseControl.Location = new System.Drawing.Point(0, 0);
            this.courseControl.Name = "courseControl";
            this.courseControl.Size = new System.Drawing.Size(454, 59);
            this.courseControl.TabIndex = 1;
            // 
            // aboutLabel
            // 
            this.aboutLabel.BackColor = System.Drawing.Color.Transparent;
            this.aboutLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutLabel.Location = new System.Drawing.Point(0, 59);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(454, 207);
            this.aboutLabel.TabIndex = 2;
            this.aboutLabel.Text = "A contact list application that contains and stores a list of contact info as wel" +
    "l as allow the user to see/change contact details.";
            this.aboutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 349);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.courseControl);
            this.Controls.Add(this.teamDescription2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "aboutDialog";
            this.ShowIcon = false;
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private CoreLibrary.teamDescription2 teamDescription2;
        private CoreLibrary.courseControl courseControl;
        private System.Windows.Forms.Label aboutLabel;
    }
}