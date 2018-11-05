namespace MultiSDIText
{
    partial class TopLevelForm
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textPreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.fontToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.backToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.capsToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.docPictureBox = new System.Windows.Forms.PictureBox();
            this.tfToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainMenu.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.addToolStripMenuItem,
            this.mainHelpToolStripMenuItem,
            this.importTextToolStripMenuItem,
            this.gridViewToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(11, 7, 0, 7);
            this.MainMenu.Size = new System.Drawing.Size(1485, 59);
            this.MainMenu.TabIndex = 5;
            this.MainMenu.Text = "MainMenu";
            this.MainMenu.MouseEnter += new System.EventHandler(this.MainMenu_MouseEnter);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 48);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(407, 46);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(407, 46);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(407, 46);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(407, 46);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(407, 46);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(118, 48);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textPreferencesToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(140, 48);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // textPreferencesToolStripMenuItem
            // 
            this.textPreferencesToolStripMenuItem.Name = "textPreferencesToolStripMenuItem";
            this.textPreferencesToolStripMenuItem.Size = new System.Drawing.Size(347, 46);
            this.textPreferencesToolStripMenuItem.Text = "Text Preferences";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(184, 48);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(146, 48);
            this.addToolStripMenuItem.Text = "Add Text";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // mainHelpToolStripMenuItem
            // 
            this.mainHelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oathToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainHelpToolStripMenuItem.Name = "mainHelpToolStripMenuItem";
            this.mainHelpToolStripMenuItem.Size = new System.Drawing.Size(92, 48);
            this.mainHelpToolStripMenuItem.Text = "Help";
            // 
            // oathToolStripMenuItem
            // 
            this.oathToolStripMenuItem.Name = "oathToolStripMenuItem";
            this.oathToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.oathToolStripMenuItem.Size = new System.Drawing.Size(455, 46);
            this.oathToolStripMenuItem.Text = "Oath";
            this.oathToolStripMenuItem.Click += new System.EventHandler(this.oathToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(455, 46);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(455, 46);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // importTextToolStripMenuItem
            // 
            this.importTextToolStripMenuItem.Name = "importTextToolStripMenuItem";
            this.importTextToolStripMenuItem.Size = new System.Drawing.Size(181, 48);
            this.importTextToolStripMenuItem.Text = "Import Text";
            this.importTextToolStripMenuItem.Click += new System.EventHandler(this.importTextToolStripMenuItem_Click);
            // 
            // gridViewToolStripMenuItem
            // 
            this.gridViewToolStripMenuItem.Name = "gridViewToolStripMenuItem";
            this.gridViewToolStripMenuItem.Size = new System.Drawing.Size(158, 48);
            this.gridViewToolStripMenuItem.Text = "Grid View";
            this.gridViewToolStripMenuItem.Click += new System.EventHandler(this.gridViewToolStripMenuItem_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripStatusLabel,
            this.colorToolStripStatusLabel,
            this.backToolStripStatusLabel,
            this.capsToolStripStatusLabel,
            this.statusToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 725);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Padding = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.mainStatusStrip.Size = new System.Drawing.Size(1485, 48);
            this.mainStatusStrip.TabIndex = 6;
            this.mainStatusStrip.Text = "statusStrip1";
            this.tfToolTip.SetToolTip(this.mainStatusStrip, "Indicates selected font type, text color, back color, caps, and status");
            this.mainStatusStrip.MouseEnter += new System.EventHandler(this.mainStatusStrip_MouseEnter);
            // 
            // fontToolStripStatusLabel
            // 
            this.fontToolStripStatusLabel.Name = "fontToolStripStatusLabel";
            this.fontToolStripStatusLabel.Size = new System.Drawing.Size(93, 41);
            this.fontToolStripStatusLabel.Text = "Font: ";
            // 
            // colorToolStripStatusLabel
            // 
            this.colorToolStripStatusLabel.Name = "colorToolStripStatusLabel";
            this.colorToolStripStatusLabel.Size = new System.Drawing.Size(90, 41);
            this.colorToolStripStatusLabel.Text = "Color";
            // 
            // backToolStripStatusLabel
            // 
            this.backToolStripStatusLabel.Name = "backToolStripStatusLabel";
            this.backToolStripStatusLabel.Size = new System.Drawing.Size(151, 41);
            this.backToolStripStatusLabel.Text = "ColorBack";
            // 
            // capsToolStripStatusLabel
            // 
            this.capsToolStripStatusLabel.Name = "capsToolStripStatusLabel";
            this.capsToolStripStatusLabel.Size = new System.Drawing.Size(212, 41);
            this.capsToolStripStatusLabel.Text = "CapsLock: OFF";
            // 
            // statusToolStripStatusLabel
            // 
            this.statusToolStripStatusLabel.Name = "statusToolStripStatusLabel";
            this.statusToolStripStatusLabel.Size = new System.Drawing.Size(98, 41);
            this.statusToolStripStatusLabel.Text = "Status";
            // 
            // docPictureBox
            // 
            this.docPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docPictureBox.Location = new System.Drawing.Point(0, 59);
            this.docPictureBox.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.docPictureBox.Name = "docPictureBox";
            this.docPictureBox.Size = new System.Drawing.Size(1485, 714);
            this.docPictureBox.TabIndex = 6;
            this.docPictureBox.TabStop = false;
            this.docPictureBox.Click += new System.EventHandler(this.docPictureBox_Click);
            this.docPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.docPictureBox_MouseDown);
            this.docPictureBox.MouseEnter += new System.EventHandler(this.docPictureBox_MouseEnter);
            this.docPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.docPictureBox_MouseMove);
            this.docPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.docPictureBox_MouseUp);
            // 
            // TopLevelForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 773);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.docPictureBox);
            this.Controls.Add(this.MainMenu);
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MinimumSize = new System.Drawing.Size(1248, 682);
            this.Name = "TopLevelForm";
            this.Text = "Typography++";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.TopLevelForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.TopLevelForm_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.TopLevelForm_DragOver);
            this.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.TopLevelForm_QueryContinueDrag);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TopLevelForm_KeyDown);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem textPreferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.PictureBox docPictureBox;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel fontToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel colorToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel backToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel capsToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTextToolStripMenuItem;
        private System.Windows.Forms.ToolTip tfToolTip;
        private System.Windows.Forms.ToolStripMenuItem gridViewToolStripMenuItem;
    }
}

