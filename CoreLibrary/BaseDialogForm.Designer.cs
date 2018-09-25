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
            this.teamDescription.Location = new System.Drawing.Point(0, 437);
            this.teamDescription.Name = "teamDescription";
            this.teamDescription.Size = new System.Drawing.Size(819, 65);
            this.teamDescription.TabIndex = 0;
            // 
            // courseControl
            // 
            this.courseControl.BackColor = System.Drawing.Color.Transparent;
            this.courseControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseControl.Location = new System.Drawing.Point(0, 0);
            this.courseControl.Name = "courseControl";
            this.courseControl.Size = new System.Drawing.Size(819, 45);
            this.courseControl.TabIndex = 1;
            // 
            // middlePanel
            // 
            this.middlePanel.BackColor = System.Drawing.Color.Transparent;
            this.middlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlePanel.Location = new System.Drawing.Point(0, 45);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(819, 392);
            this.middlePanel.TabIndex = 2;
            // 
            // BaseDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 502);
            this.Controls.Add(this.middlePanel);
            this.Controls.Add(this.courseControl);
            this.Controls.Add(this.teamDescription);
            this.Name = "BaseDialogForm";
            this.Text = "BaseDialogForm";
            this.ResumeLayout(false);

        }

        #endregion

        private teamDescription2 teamDescription;
        private courseControl courseControl;
        protected System.Windows.Forms.Panel middlePanel;
    }
}