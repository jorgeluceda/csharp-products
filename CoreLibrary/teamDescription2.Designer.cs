namespace CoreLibrary
{
    partial class teamDescription2
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
            this.teamName = new System.Windows.Forms.Label();
            this.teamNames = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teamName
            // 
            this.teamName.Dock = System.Windows.Forms.DockStyle.Top;
            this.teamName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teamName.Location = new System.Drawing.Point(0, 0);
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(311, 23);
            this.teamName.TabIndex = 0;
            this.teamName.Text = "Team 3";
            this.teamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teamNames
            // 
            this.teamNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamNames.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teamNames.Location = new System.Drawing.Point(0, 23);
            this.teamNames.Name = "teamNames";
            this.teamNames.Size = new System.Drawing.Size(311, 102);
            this.teamNames.TabIndex = 1;
            this.teamNames.Text = "Lazaro Alvarez, Darien Morrison, Jorge Euceda, Alejandro Perez, Mohammed Bhatti, " +
    "Emmanuel Perez";
            this.teamNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teamDescription2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.teamNames);
            this.Controls.Add(this.teamName);
            this.Name = "teamDescription2";
            this.Size = new System.Drawing.Size(311, 125);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label teamName;
        private System.Windows.Forms.Label teamNames;
    }
}
