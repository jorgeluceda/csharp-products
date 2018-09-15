namespace CoreLibrary
{
    partial class Dialog_Form
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
            this.courseDescription1 = new CoreLibrary.CourseDescription();
            this.teamDescription1 = new CoreLibrary.TeamDescription();
            this.FillPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // courseDescription1
            // 
            this.courseDescription1.BackColor = System.Drawing.SystemColors.Control;
            this.courseDescription1.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseDescription1.Location = new System.Drawing.Point(0, 0);
            this.courseDescription1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseDescription1.MinimumSize = new System.Drawing.Size(125, 60);
            this.courseDescription1.Name = "courseDescription1";
            this.courseDescription1.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.courseDescription1.Size = new System.Drawing.Size(927, 60);
            this.courseDescription1.TabIndex = 0;
            // 
            // teamDescription1
            // 
            this.teamDescription1.BackColor = System.Drawing.Color.MediumPurple;
            this.teamDescription1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.teamDescription1.Location = new System.Drawing.Point(0, 239);
            this.teamDescription1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teamDescription1.MinimumSize = new System.Drawing.Size(219, 268);
            this.teamDescription1.Name = "teamDescription1";
            this.teamDescription1.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.teamDescription1.Size = new System.Drawing.Size(927, 268);
            this.teamDescription1.TabIndex = 1;
            // 
            // FillPanel
            // 
            this.FillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FillPanel.Location = new System.Drawing.Point(0, 60);
            this.FillPanel.Name = "FillPanel";
            this.FillPanel.Size = new System.Drawing.Size(927, 179);
            this.FillPanel.TabIndex = 2;
            // 
            // Dialog_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 507);
            this.Controls.Add(this.FillPanel);
            this.Controls.Add(this.teamDescription1);
            this.Controls.Add(this.courseDescription1);
            this.Name = "Dialog_Form";
            this.Text = "Dialog_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private CourseDescription courseDescription1;
        private TeamDescription teamDescription1;
        private System.Windows.Forms.Panel FillPanel;
    }
}