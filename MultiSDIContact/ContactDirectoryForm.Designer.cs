namespace MultiSDIContact
{
    partial class ContactDIrectoryForm
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
            this.contactDirectoryStatusBar = new System.Windows.Forms.StatusBar();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.contactDataGrid = new System.Windows.Forms.DataGridView();
            this.directoryToolBar = new System.Windows.Forms.ToolBar();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.fileMenuItem = new System.Windows.Forms.MenuItem();
            this.saveMenuItem = new System.Windows.Forms.MenuItem();
            this.loadMenuItem = new System.Windows.Forms.MenuItem();
            this.rawMenuItem = new System.Windows.Forms.MenuItem();
            this.exitMenuItem = new System.Windows.Forms.MenuItem();
            this.helpMenuItem = new System.Windows.Forms.MenuItem();
            this.aboutMenuItem = new System.Windows.Forms.MenuItem();
            this.helpInfoMenuItem = new System.Windows.Forms.MenuItem();
            this.oathMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // contactDirectoryStatusBar
            // 
            this.contactDirectoryStatusBar.Location = new System.Drawing.Point(0, 472);
            this.contactDirectoryStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contactDirectoryStatusBar.Name = "contactDirectoryStatusBar";
            this.contactDirectoryStatusBar.Size = new System.Drawing.Size(735, 28);
            this.contactDirectoryStatusBar.TabIndex = 0;
            this.contactDirectoryStatusBar.Text = "Contact Directory Status";
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Location = new System.Drawing.Point(14, 436);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(84, 29);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editButton.Location = new System.Drawing.Point(105, 436);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(84, 29);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(637, 436);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(84, 29);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // contactDataGrid
            // 
            this.contactDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactDataGrid.Location = new System.Drawing.Point(14, 100);
            this.contactDataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contactDataGrid.Name = "contactDataGrid";
            this.contactDataGrid.RowTemplate.Height = 24;
            this.contactDataGrid.Size = new System.Drawing.Size(708, 329);
            this.contactDataGrid.TabIndex = 4;
            // 
            // directoryToolBar
            // 
            this.directoryToolBar.DropDownArrows = true;
            this.directoryToolBar.Location = new System.Drawing.Point(0, 0);
            this.directoryToolBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.directoryToolBar.Name = "directoryToolBar";
            this.directoryToolBar.ShowToolTips = true;
            this.directoryToolBar.Size = new System.Drawing.Size(735, 42);
            this.directoryToolBar.TabIndex = 6;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenuItem,
            this.helpMenuItem});
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.Index = 0;
            this.fileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.saveMenuItem,
            this.loadMenuItem,
            this.rawMenuItem,
            this.menuItem1,
            this.exitMenuItem});
            this.fileMenuItem.Text = "File";
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Index = 0;
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // loadMenuItem
            // 
            this.loadMenuItem.Index = 1;
            this.loadMenuItem.Text = "Load";
            this.loadMenuItem.Click += new System.EventHandler(this.loadMenuItem_Click);
            // 
            // rawMenuItem
            // 
            this.rawMenuItem.Index = 2;
            this.rawMenuItem.Text = "Raw";
            this.rawMenuItem.Click += new System.EventHandler(this.rawMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Index = 4;
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Index = 1;
            this.helpMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.aboutMenuItem,
            this.helpInfoMenuItem,
            this.oathMenuItem});
            this.helpMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Index = 0;
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // helpInfoMenuItem
            // 
            this.helpInfoMenuItem.Index = 1;
            this.helpInfoMenuItem.Text = "Help Info";
            this.helpInfoMenuItem.Click += new System.EventHandler(this.helpInfoMenuItem_Click);
            // 
            // oathMenuItem
            // 
            this.oathMenuItem.Index = 2;
            this.oathMenuItem.Text = "Oath";
            this.oathMenuItem.Click += new System.EventHandler(this.oathMenuItem_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 3;
            this.menuItem1.Text = "Print";
            // 
            // ContactDIrectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 500);
            this.Controls.Add(this.directoryToolBar);
            this.Controls.Add(this.contactDataGrid);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.contactDirectoryStatusBar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Menu = this.mainMenu1;
            this.Name = "ContactDIrectoryForm";
            this.Text = "Contact Directory";
            ((System.ComponentModel.ISupportInitialize)(this.contactDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusBar contactDirectoryStatusBar;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView contactDataGrid;
        private System.Windows.Forms.ToolBar directoryToolBar;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem fileMenuItem;
        private System.Windows.Forms.MenuItem saveMenuItem;
        private System.Windows.Forms.MenuItem loadMenuItem;
        private System.Windows.Forms.MenuItem rawMenuItem;
        private System.Windows.Forms.MenuItem exitMenuItem;
        private System.Windows.Forms.MenuItem helpMenuItem;
        private System.Windows.Forms.MenuItem aboutMenuItem;
        private System.Windows.Forms.MenuItem helpInfoMenuItem;
        private System.Windows.Forms.MenuItem oathMenuItem;
        private System.Windows.Forms.MenuItem menuItem1;
    }
}

