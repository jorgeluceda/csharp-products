namespace MultiSDIText
{
    partial class ImageWindow
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
            this.Panel = new System.Windows.Forms.Panel();
            this.imgPictureBox = new System.Windows.Forms.PictureBox();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveViewAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.imgPictureBox);
            this.Panel.Controls.Add(this.MainMenu);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1200, 703);
            this.Panel.TabIndex = 0;
            this.Panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseClick);
            // 
            // imgPictureBox
            // 
            this.imgPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgPictureBox.Location = new System.Drawing.Point(0, 50);
            this.imgPictureBox.Name = "imgPictureBox";
            this.imgPictureBox.Size = new System.Drawing.Size(1200, 653);
            this.imgPictureBox.TabIndex = 7;
            this.imgPictureBox.TabStop = false;
            this.imgPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.imgPictureBox_Paint);
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(9, 6, 0, 6);
            this.MainMenu.Size = new System.Drawing.Size(1200, 50);
            this.MainMenu.TabIndex = 6;
            this.MainMenu.Text = "MainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToWindowToolStripMenuItem,
            this.saveViewAsImageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveViewAsImageToolStripMenuItem
            // 
            this.saveViewAsImageToolStripMenuItem.Name = "saveViewAsImageToolStripMenuItem";
            this.saveViewAsImageToolStripMenuItem.Size = new System.Drawing.Size(369, 38);
            this.saveViewAsImageToolStripMenuItem.Text = "Save Window As Image";
            this.saveViewAsImageToolStripMenuItem.Click += new System.EventHandler(this.saveViewAsImageToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(218, 38);
            this.editToolStripMenuItem.Text = "Change any Color";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // openImageToWindowToolStripMenuItem
            // 
            this.openImageToWindowToolStripMenuItem.Name = "openImageToWindowToolStripMenuItem";
            this.openImageToWindowToolStripMenuItem.Size = new System.Drawing.Size(369, 38);
            this.openImageToWindowToolStripMenuItem.Text = "Open Image as Window";
            this.openImageToWindowToolStripMenuItem.Click += new System.EventHandler(this.openImageToWindowToolStripMenuItem_Click);
            // 
            // ImageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.Panel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ImageWindow";
            this.Text = "ImageWindow";
            this.Load += new System.EventHandler(this.ImageWindow_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveViewAsImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgPictureBox;
        private System.Windows.Forms.ToolStripMenuItem openImageToWindowToolStripMenuItem;
    }
}