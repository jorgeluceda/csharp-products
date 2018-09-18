namespace Application
{
    partial class MainForm
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
            this.File = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipsesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeRectanglesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openModallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openModelesslyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.File.SuspendLayout();
            this.SuspendLayout();
            // 
            // File
            // 
            this.File.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.File.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.File.Location = new System.Drawing.Point(0, 0);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(800, 28);
            this.File.TabIndex = 0;
            this.File.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ellipseToolStripMenuItem,
            this.rectangleToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ellipsesToolStripMenuItem,
            this.closeRectanglesToolStripMenuItem,
            this.closeApplicationToolStripMenuItem});
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // ellipsesToolStripMenuItem
            // 
            this.ellipsesToolStripMenuItem.Name = "ellipsesToolStripMenuItem";
            this.ellipsesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ellipsesToolStripMenuItem.Text = "Close Ellipses";
            // 
            // closeRectanglesToolStripMenuItem
            // 
            this.closeRectanglesToolStripMenuItem.Name = "closeRectanglesToolStripMenuItem";
            this.closeRectanglesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.closeRectanglesToolStripMenuItem.Text = "Close Rectangles";
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openModallyToolStripMenuItem,
            this.openModelesslyToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // openModallyToolStripMenuItem
            // 
            this.openModallyToolStripMenuItem.Name = "openModallyToolStripMenuItem";
            this.openModallyToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openModallyToolStripMenuItem.Text = "Open Modally";
            // 
            // openModelesslyToolStripMenuItem
            // 
            this.openModelesslyToolStripMenuItem.Name = "openModelesslyToolStripMenuItem";
            this.openModelesslyToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openModelesslyToolStripMenuItem.Text = "Open Modelessly";
            this.openModelesslyToolStripMenuItem.Click += new System.EventHandler(this.openModelesslyToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.File);
            this.MainMenuStrip = this.File;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.File.ResumeLayout(false);
            this.File.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip File;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipsesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeRectanglesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openModallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openModelesslyToolStripMenuItem;
    }
}