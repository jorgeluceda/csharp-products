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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseDialogForm));
            this.middlePanel = new System.Windows.Forms.Panel();
            this.assignmentDescription = new System.Windows.Forms.Label();
            this.courseDescription = new CoreLibrary.CourseDescription();
            this.teamDescription = new CoreLibrary.TeamDescription();
            this.middlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // middlePanel
            // 
            this.middlePanel.BackColor = System.Drawing.Color.Transparent;
            this.middlePanel.Controls.Add(this.teamDescription);
            this.middlePanel.Controls.Add(this.courseDescription);
            this.middlePanel.Controls.Add(this.assignmentDescription);
            this.middlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlePanel.Location = new System.Drawing.Point(0, 0);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(648, 532);
            this.middlePanel.TabIndex = 2;
            // 
            // assignmentDescription
            // 
            this.assignmentDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.assignmentDescription.AutoSize = true;
            this.assignmentDescription.ForeColor = System.Drawing.Color.Black;
            this.assignmentDescription.Location = new System.Drawing.Point(57, 111);
            this.assignmentDescription.Name = "assignmentDescription";
            this.assignmentDescription.Size = new System.Drawing.Size(525, 68);
            this.assignmentDescription.TabIndex = 0;
            this.assignmentDescription.Text = resources.GetString("assignmentDescription.Text");
            // 
            // courseDescription
            // 
            this.courseDescription.BackColor = System.Drawing.Color.Transparent;
            this.courseDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseDescription.Location = new System.Drawing.Point(0, 0);
            this.courseDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseDescription.MinimumSize = new System.Drawing.Size(125, 60);
            this.courseDescription.Name = "courseDescription";
            this.courseDescription.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.courseDescription.Size = new System.Drawing.Size(648, 60);
            this.courseDescription.TabIndex = 1;
            // 
            // teamDescription
            // 
            this.teamDescription.BackColor = System.Drawing.Color.MediumPurple;
            this.teamDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.teamDescription.Location = new System.Drawing.Point(0, 264);
            this.teamDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teamDescription.MinimumSize = new System.Drawing.Size(219, 268);
            this.teamDescription.Name = "teamDescription";
            this.teamDescription.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.teamDescription.Size = new System.Drawing.Size(648, 268);
            this.teamDescription.TabIndex = 2;
            // 
            // BaseDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 532);
            this.Controls.Add(this.middlePanel);
            this.Name = "BaseDialogForm";
            this.Text = "BaseDialogForm";
            this.middlePanel.ResumeLayout(false);
            this.middlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel middlePanel;
        private System.Windows.Forms.Label assignmentDescription;
        private TeamDescription teamDescription;
        private CourseDescription courseDescription;
    }
}