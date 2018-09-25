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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFormContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openPreferencesModelesslyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferencesModallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuOath = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.File.SuspendLayout();
            this.MainFormContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // File
            // 
            this.File.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.File.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.menuHelp});
            this.File.Location = new System.Drawing.Point(0, 0);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(886, 28);
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
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
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
            this.ellipsesToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.ellipsesToolStripMenuItem.Text = "Close Ellipses";
            // 
            // closeRectanglesToolStripMenuItem
            // 
            this.closeRectanglesToolStripMenuItem.Name = "closeRectanglesToolStripMenuItem";
            this.closeRectanglesToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.closeRectanglesToolStripMenuItem.Text = "Close Rectangles";
            this.closeRectanglesToolStripMenuItem.Click += new System.EventHandler(this.closeRectanglesToolStripMenuItem_Click);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplicationToolStripMenuItem_Click);
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
            this.openModallyToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.openModallyToolStripMenuItem.Text = "Open Modally";
            this.openModallyToolStripMenuItem.Click += new System.EventHandler(this.openPreferencesModallyToolStripMenuItem_Click);
            // 
            // openModelesslyToolStripMenuItem
            // 
            this.openModelesslyToolStripMenuItem.Name = "openModelesslyToolStripMenuItem";
            this.openModelesslyToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.openModelesslyToolStripMenuItem.Text = "Open Modelessly";
            this.openModelesslyToolStripMenuItem.Click += new System.EventHandler(this.openPreferencesModelesslyToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLoginToolStripMenuItem,
            this.hideLoginToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // showLoginToolStripMenuItem
            // 
            this.showLoginToolStripMenuItem.Name = "showLoginToolStripMenuItem";
            this.showLoginToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.showLoginToolStripMenuItem.Text = "Show Login";
            this.showLoginToolStripMenuItem.Click += new System.EventHandler(this.showLoginToolStripMenuItem_Click);
            // 
            // hideLoginToolStripMenuItem
            // 
            this.hideLoginToolStripMenuItem.Name = "hideLoginToolStripMenuItem";
            this.hideLoginToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.hideLoginToolStripMenuItem.Text = "Hide Login";
            this.hideLoginToolStripMenuItem.Click += new System.EventHandler(this.hideLoginToolStripMenuItem_Click);
            // 
            // MainFormContext
            // 
            this.MainFormContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainFormContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPreferencesModelesslyToolStripMenuItem,
            this.openPreferencesModallyToolStripMenuItem});
            this.MainFormContext.Name = "MainFormContext";
            this.MainFormContext.Size = new System.Drawing.Size(273, 52);
            // 
            // openPreferencesModelesslyToolStripMenuItem
            // 
            this.openPreferencesModelesslyToolStripMenuItem.Name = "openPreferencesModelesslyToolStripMenuItem";
            this.openPreferencesModelesslyToolStripMenuItem.Size = new System.Drawing.Size(272, 24);
            this.openPreferencesModelesslyToolStripMenuItem.Text = "Open Preferences Modelessly";
            this.openPreferencesModelesslyToolStripMenuItem.Click += new System.EventHandler(this.openPreferencesModelesslyToolStripMenuItem_Click);
            // 
            // openPreferencesModallyToolStripMenuItem
            // 
            this.openPreferencesModallyToolStripMenuItem.Name = "openPreferencesModallyToolStripMenuItem";
            this.openPreferencesModallyToolStripMenuItem.Size = new System.Drawing.Size(272, 24);
            this.openPreferencesModallyToolStripMenuItem.Text = "Open Preferences Modally";
            this.openPreferencesModallyToolStripMenuItem.Click += new System.EventHandler(this.openPreferencesModallyToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenuOath,
            this.helpMenuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(53, 24);
            this.menuHelp.Text = "Help";
            // 
            // helpMenuOath
            // 
            this.helpMenuOath.Name = "helpMenuOath";
            this.helpMenuOath.Size = new System.Drawing.Size(216, 26);
            this.helpMenuOath.Text = "Oath";
            // 
            // helpMenuAbout
            // 
            this.helpMenuAbout.Name = "helpMenuAbout";
            this.helpMenuAbout.Size = new System.Drawing.Size(216, 26);
            this.helpMenuAbout.Text = "About";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.ContextMenuStrip = this.MainFormContext;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.File);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.File;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.File.ResumeLayout(false);
            this.File.PerformLayout();
            this.MainFormContext.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip MainFormContext;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesModelesslyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesModallyToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem helpMenuOath;
        private System.Windows.Forms.ToolStripMenuItem helpMenuAbout;
    }
}
