namespace CoreLibrary
{
    partial class Oath
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
            this.lblOath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOath
            // 
            this.lblOath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOath.Font = new System.Drawing.Font("Arial", 9F);
            this.lblOath.ForeColor = System.Drawing.Color.White;
            this.lblOath.Location = new System.Drawing.Point(9, 7);
            this.lblOath.Name = "lblOath";
            this.lblOath.Size = new System.Drawing.Size(201, 254);
            this.lblOath.TabIndex = 2;
            this.lblOath.Text = "I understand that this is a group project.\r\n\r\nIt is in my best interest to partic" +
    "ipate in writing the homework and study all the\r\ncode from the homework.";
            this.lblOath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Oath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.lblOath);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(219, 268);
            this.Name = "Oath";
            this.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.Size = new System.Drawing.Size(219, 268);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblOath;
    }
}
