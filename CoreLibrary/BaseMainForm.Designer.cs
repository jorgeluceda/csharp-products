namespace CoreLibrary
{
    partial class BaseMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseMainForm));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.smiOath = new System.Windows.Forms.ToolStripMenuItem();
            this.smiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator,
            this.toolStripSeparator1,
            this.tsddbHelp});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.ToolStrip.Size = new System.Drawing.Size(686, 47);
            this.ToolStrip.TabIndex = 3;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // tsddbHelp
            // 
            this.tsddbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiOath,
            this.smiAbout});
            this.tsddbHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsddbHelp.Image")));
            this.tsddbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbHelp.Name = "tsddbHelp";
            this.tsddbHelp.Size = new System.Drawing.Size(58, 44);
            this.tsddbHelp.Text = "toolStripDropDownButton1";
            // 
            // smiOath
            // 
            this.smiOath.Name = "smiOath";
            this.smiOath.Size = new System.Drawing.Size(210, 30);
            this.smiOath.Text = "Oath";
            this.smiOath.Click += new System.EventHandler(this.smiOath_Click);
            // 
            // smiAbout
            // 
            this.smiAbout.Name = "smiAbout";
            this.smiAbout.Size = new System.Drawing.Size(210, 30);
            this.smiAbout.Text = "About";
            this.smiAbout.Click += new System.EventHandler(this.smiAbout_Click);
            // 
            // BaseMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 417);
            this.Controls.Add(this.ToolStrip);
            this.Name = "BaseMainForm";
            this.Text = "BaseMainForm";
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsddbHelp;
        private System.Windows.Forms.ToolStripMenuItem smiOath;
        private System.Windows.Forms.ToolStripMenuItem smiAbout;
    }
}