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
            this.teamDescription = new CoreLibrary.TeamDescription();
            this.assignmentDescription = new System.Windows.Forms.Label();
            this.courseDescription = new CoreLibrary.CourseDescription();
            this.middlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // middlePanel
            // 
            this.middlePanel.BackColor = System.Drawing.Color.Transparent;
            this.middlePanel.Controls.Add(this.assignmentDescription);
            this.middlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlePanel.Location = new System.Drawing.Point(0, 72);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(630, 204);
            this.middlePanel.TabIndex = 2;
            // 
            // teamDescription
            // 
            this.teamDescription.BackColor = System.Drawing.Color.MediumPurple;
            this.teamDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.teamDescription.Location = new System.Drawing.Point(0, 276);
            this.teamDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teamDescription.MinimumSize = new System.Drawing.Size(219, 268);
            this.teamDescription.Name = "teamDescription";
            this.teamDescription.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.teamDescription.Size = new System.Drawing.Size(630, 268);
            this.teamDescription.TabIndex = 2;
            // 
            // assignmentDescription
            // 
            this.assignmentDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.assignmentDescription.ForeColor = System.Drawing.Color.Black;
            this.assignmentDescription.Location = new System.Drawing.Point(0, 121);
            this.assignmentDescription.Name = "assignmentDescription";
            this.assignmentDescription.Size = new System.Drawing.Size(630, 83);
            this.assignmentDescription.TabIndex = 0;
            this.assignmentDescription.Text = resources.GetString("assignmentDescription.Text");
            this.assignmentDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.courseDescription.Size = new System.Drawing.Size(630, 72);
            this.courseDescription.TabIndex = 1;
            // 
            // BaseDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 544);
            this.Controls.Add(this.middlePanel);
            this.Controls.Add(this.courseDescription);
            this.Controls.Add(this.teamDescription);
            this.Name = "BaseDialogForm";
            this.Text = "BaseDialogForm";
            this.middlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel middlePanel;
        private System.Windows.Forms.Label assignmentDescription;
        private TeamDescription teamDescription;
        private CourseDescription courseDescription;
    }
}