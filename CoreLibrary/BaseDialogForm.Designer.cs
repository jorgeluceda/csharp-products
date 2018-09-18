namespace CoreLibrary
{
    partial class BaseDialogForm
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
            this.middlePanel = new System.Windows.Forms.Panel();
            this.teamDescription = new CoreLibrary.TeamDescription();
            this.courseDescription = new CoreLibrary.CourseDescription();
            this.SuspendLayout();
            // 
            // middlePanel
            // 
            this.middlePanel.BackColor = System.Drawing.Color.Transparent;
            this.middlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlePanel.Location = new System.Drawing.Point(0, 60);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(505, 132);
            this.middlePanel.TabIndex = 2;
            // 
            // teamDescription
            // 
            this.teamDescription.BackColor = System.Drawing.Color.MediumPurple;
            this.teamDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.teamDescription.Location = new System.Drawing.Point(0, 192);
            this.teamDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teamDescription.MinimumSize = new System.Drawing.Size(219, 268);
            this.teamDescription.Name = "teamDescription";
            this.teamDescription.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.teamDescription.Size = new System.Drawing.Size(505, 268);
            this.teamDescription.TabIndex = 1;
            // 
            // courseDescription
            // 
            this.courseDescription.BackColor = System.Drawing.SystemColors.Control;
            this.courseDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseDescription.Location = new System.Drawing.Point(0, 0);
            this.courseDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseDescription.MinimumSize = new System.Drawing.Size(125, 60);
            this.courseDescription.Name = "courseDescription";
            this.courseDescription.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.courseDescription.Size = new System.Drawing.Size(505, 60);
            this.courseDescription.TabIndex = 0;
            // 
            // BaseDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 460);
            this.Controls.Add(this.middlePanel);
            this.Controls.Add(this.teamDescription);
            this.Controls.Add(this.courseDescription);
            this.Name = "BaseDialogForm";
            this.Text = "BaseDialogForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CourseDescription courseDescription;
        private TeamDescription teamDescription;
        private System.Windows.Forms.Panel middlePanel;
    }
}