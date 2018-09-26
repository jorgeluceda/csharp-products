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
            this.teamDescription = new CoreLibrary.teamDescription2();
            this.courseControl = new CoreLibrary.courseControl();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // teamDescription
            // 
            this.teamDescription.BackColor = System.Drawing.Color.MediumPurple;
            this.teamDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.teamDescription.Location = new System.Drawing.Point(0, 355);
            this.teamDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teamDescription.Name = "teamDescription";
            this.teamDescription.Size = new System.Drawing.Size(614, 53);
            this.teamDescription.TabIndex = 0;
            // 
            // courseControl
            // 
            this.courseControl.BackColor = System.Drawing.Color.Transparent;
            this.courseControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseControl.Location = new System.Drawing.Point(0, 0);
            this.courseControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.courseControl.Name = "courseControl";
            this.courseControl.Size = new System.Drawing.Size(614, 37);
            this.courseControl.TabIndex = 1;
            this.courseControl.Load += new System.EventHandler(this.courseControl_Load);
            // 
            // middlePanel
            // 
            this.middlePanel.BackColor = System.Drawing.Color.Transparent;
            this.middlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlePanel.Location = new System.Drawing.Point(0, 37);
            this.middlePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(614, 318);
            this.middlePanel.TabIndex = 2;
            // 
            // BaseDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 408);
            this.Controls.Add(this.middlePanel);
            this.Controls.Add(this.courseControl);
            this.Controls.Add(this.teamDescription);
            this.Name = "BaseDialogForm";
            this.Text = "BaseDialogForm";
            this.Controls.SetChildIndex(this.teamDescription, 0);
            this.Controls.SetChildIndex(this.courseControl, 0);
            this.Controls.SetChildIndex(this.middlePanel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected teamDescription2 teamDescription;
        protected courseControl courseControl;
        protected System.Windows.Forms.Panel middlePanel;
    }
}