namespace CoreLibrary
{
    partial class BaseForm
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
            this.baseFormContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.preferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundColor = new System.Windows.Forms.ColorDialog();
            this.baseFormMenu = new System.Windows.Forms.MenuStrip();
            this.baseFormMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.baseFormMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.baseFormContext.SuspendLayout();
            this.baseFormMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseFormContext
            // 
            this.baseFormContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.baseFormContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferenceToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.baseFormContext.Name = "contextMenuStrip1";
            this.baseFormContext.Size = new System.Drawing.Size(149, 52);
            this.baseFormContext.Text = "Menu";
            // 
            // preferenceToolStripMenuItem
            // 
            this.preferenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsToolStripMenuItem});
            this.preferenceToolStripMenuItem.Name = "preferenceToolStripMenuItem";
            this.preferenceToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.preferenceToolStripMenuItem.Text = "Preference";
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.colorsToolStripMenuItem.Text = "Colors";
            this.colorsToolStripMenuItem.Click += new System.EventHandler(this.colorsToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // BackgroundColor
            // 
            this.BackgroundColor.HelpRequest += new System.EventHandler(this.colorsToolStripMenuItem_Click);
            // 
            // baseFormMenu
            // 
            this.baseFormMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.baseFormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseFormMenuItem1,
            this.baseFormMenuItem2});
            this.baseFormMenu.Location = new System.Drawing.Point(0, 0);
            this.baseFormMenu.Name = "baseFormMenu";
            this.baseFormMenu.Size = new System.Drawing.Size(636, 28);
            this.baseFormMenu.TabIndex = 1;
            this.baseFormMenu.Text = "menuStrip1";
            this.baseFormMenu.Visible = false;
            // 
            // baseFormMenuItem1
            // 
            this.baseFormMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsToolStripMenuItem1});
            this.baseFormMenuItem1.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.baseFormMenuItem1.Name = "baseFormMenuItem1";
            this.baseFormMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.baseFormMenuItem1.Text = "File";
            // 
            // colorsToolStripMenuItem1
            // 
            this.colorsToolStripMenuItem1.Name = "colorsToolStripMenuItem1";
            this.colorsToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.colorsToolStripMenuItem1.Text = "Close Child";
            this.colorsToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // baseFormMenuItem2
            // 
            this.baseFormMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsToolStripMenuItem2});
            this.baseFormMenuItem2.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.baseFormMenuItem2.Name = "baseFormMenuItem2";
            this.baseFormMenuItem2.Size = new System.Drawing.Size(97, 24);
            this.baseFormMenuItem2.Text = "Preferences";
            // 
            // colorsToolStripMenuItem2
            // 
            this.colorsToolStripMenuItem2.Name = "colorsToolStripMenuItem2";
            this.colorsToolStripMenuItem2.Size = new System.Drawing.Size(126, 26);
            this.colorsToolStripMenuItem2.Text = "Colors";
            this.colorsToolStripMenuItem2.Click += new System.EventHandler(this.colorsToolStripMenuItem1_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(636, 326);
            this.ContextMenuStrip = this.baseFormContext;
            this.Controls.Add(this.baseFormMenu);
            this.MainMenuStrip = this.baseFormMenu;
            this.Name = "BaseForm";
            this.Text = "Base Form";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseUp);
            this.baseFormContext.ResumeLayout(false);
            this.baseFormMenu.ResumeLayout(false);
            this.baseFormMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip baseFormContext;
        private System.Windows.Forms.ToolStripMenuItem preferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ColorDialog BackgroundColor;
        private System.Windows.Forms.MenuStrip baseFormMenu;
        private System.Windows.Forms.ToolStripMenuItem baseFormMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem baseFormMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem2;
    }
}