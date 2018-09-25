namespace CoreLibrary
{
    partial class CourseDescription
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblSemesterName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCourseName
            // 
            this.lblCourseName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCourseName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.ForeColor = System.Drawing.Color.White;
            this.lblCourseName.Location = new System.Drawing.Point(9, 8);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblCourseName.Size = new System.Drawing.Size(143, 30);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "COP 4226";
            this.lblCourseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSemesterName
            // 
            this.lblSemesterName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSemesterName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterName.ForeColor = System.Drawing.Color.White;
            this.lblSemesterName.Location = new System.Drawing.Point(9, 38);
            this.lblSemesterName.Name = "lblSemesterName";
            this.lblSemesterName.Size = new System.Drawing.Size(143, 42);
            this.lblSemesterName.TabIndex = 1;
            this.lblSemesterName.Text = "Fall 2018";
            this.lblSemesterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.lblSemesterName);
            this.Controls.Add(this.lblCourseName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(125, 60);
            this.Name = "CourseDescription";
            this.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Size = new System.Drawing.Size(161, 88);
            this.Load += new System.EventHandler(this.CourseDescription_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblSemesterName;
    }
}
