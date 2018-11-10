﻿namespace MultiSDIContact
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
            this.helpMenuItem = new System.Windows.Forms.MenuItem();
            this.aboutMenuItem = new System.Windows.Forms.MenuItem();
            this.helpInfoMenuItem = new System.Windows.Forms.MenuItem();
            this.oathMenuItem = new System.Windows.Forms.MenuItem();
            this.saveMenuItem = new System.Windows.Forms.MenuItem();
            this.loadMenuItem = new System.Windows.Forms.MenuItem();
            this.rawMenuItem = new System.Windows.Forms.MenuItem();
            this.exitMenuItem = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // contactDirectoryStatusBar
            // 
            this.contactDirectoryStatusBar.Location = new System.Drawing.Point(0, 378);
            this.contactDirectoryStatusBar.Name = "contactDirectoryStatusBar";
            this.contactDirectoryStatusBar.Size = new System.Drawing.Size(653, 22);
            this.contactDirectoryStatusBar.TabIndex = 0;
            this.contactDirectoryStatusBar.Text = "Contact Directory Status";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 349);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(93, 349);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(566, 349);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // contactDataGrid
            // 
            this.contactDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactDataGrid.Location = new System.Drawing.Point(12, 80);
            this.contactDataGrid.Name = "contactDataGrid";
            this.contactDataGrid.RowTemplate.Height = 24;
            this.contactDataGrid.Size = new System.Drawing.Size(629, 263);
            this.contactDataGrid.TabIndex = 4;
            // 
            // directoryToolBar
            // 
            this.directoryToolBar.DropDownArrows = true;
            this.directoryToolBar.Location = new System.Drawing.Point(0, 0);
            this.directoryToolBar.Name = "directoryToolBar";
            this.directoryToolBar.ShowToolTips = true;
            this.directoryToolBar.Size = new System.Drawing.Size(653, 42);
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
            this.exitMenuItem});
            this.fileMenuItem.Text = "File";
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
            // 
            // helpInfoMenuItem
            // 
            this.helpInfoMenuItem.Index = 1;
            this.helpInfoMenuItem.Text = "Help";
            // 
            // oathMenuItem
            // 
            this.oathMenuItem.Index = 2;
            this.oathMenuItem.Text = "Oath";
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Index = 0;
            this.saveMenuItem.Text = "Save";
            // 
            // loadMenuItem
            // 
            this.loadMenuItem.Index = 1;
            this.loadMenuItem.Text = "Load";
            // 
            // rawMenuItem
            // 
            this.rawMenuItem.Index = 2;
            this.rawMenuItem.Text = "Raw";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Index = 3;
            this.exitMenuItem.Text = "Exit";
            // 
            // ContactDIrectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 400);
            this.Controls.Add(this.directoryToolBar);
            this.Controls.Add(this.contactDataGrid);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.contactDirectoryStatusBar);
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
    }
}

