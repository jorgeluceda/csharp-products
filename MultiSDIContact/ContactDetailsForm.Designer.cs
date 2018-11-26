namespace MultiSDIContact
{
    partial class ContactDetailsForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.homePhoneLabel = new System.Windows.Forms.Label();
            this.homeTextBox = new System.Windows.Forms.TextBox();
            this.cellPhoneLabel = new System.Windows.Forms.Label();
            this.cellPhoneTextBox = new System.Windows.Forms.TextBox();
            this.address1Label = new System.Windows.Forms.Label();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2Label = new System.Windows.Forms.Label();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.contactPictureBox = new System.Windows.Forms.PictureBox();
            this.EditContactsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.contactPictureBox)).BeginInit();
            this.EditContactsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.okButton.Location = new System.Drawing.Point(24, 875);
            this.okButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(171, 76);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.contactsToolTip.SetToolTip(this.okButton, "Confirm and add your contact");
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancelButton.Location = new System.Drawing.Point(205, 875);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(165, 76);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.contactsToolTip.SetToolTip(this.cancelButton, "Cancel adding this contact");
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteButton.Location = new System.Drawing.Point(541, 875);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(187, 76);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.contactsToolTip.SetToolTip(this.deleteButton, "Delete this contact");
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLabel.Location = new System.Drawing.Point(408, 29);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(160, 32);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.firstNameTextBox.Location = new System.Drawing.Point(413, 67);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(311, 38);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLabel.Location = new System.Drawing.Point(408, 169);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(159, 32);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lastNameTextBox.Location = new System.Drawing.Point(413, 207);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(311, 38);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // homePhoneLabel
            // 
            this.homePhoneLabel.AutoSize = true;
            this.homePhoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.homePhoneLabel.Location = new System.Drawing.Point(405, 322);
            this.homePhoneLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.homePhoneLabel.Name = "homePhoneLabel";
            this.homePhoneLabel.Size = new System.Drawing.Size(188, 32);
            this.homePhoneLabel.TabIndex = 7;
            this.homePhoneLabel.Text = "Home Phone:";
            // 
            // homeTextBox
            // 
            this.homeTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.homeTextBox.Location = new System.Drawing.Point(411, 367);
            this.homeTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.homeTextBox.Name = "homeTextBox";
            this.homeTextBox.Size = new System.Drawing.Size(311, 38);
            this.homeTextBox.TabIndex = 8;
            // 
            // cellPhoneLabel
            // 
            this.cellPhoneLabel.AutoSize = true;
            this.cellPhoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.cellPhoneLabel.Location = new System.Drawing.Point(21, 322);
            this.cellPhoneLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cellPhoneLabel.Name = "cellPhoneLabel";
            this.cellPhoneLabel.Size = new System.Drawing.Size(163, 32);
            this.cellPhoneLabel.TabIndex = 9;
            this.cellPhoneLabel.Text = "Cell Phone:";
            // 
            // cellPhoneTextBox
            // 
            this.cellPhoneTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellPhoneTextBox.Location = new System.Drawing.Point(21, 367);
            this.cellPhoneTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cellPhoneTextBox.Name = "cellPhoneTextBox";
            this.cellPhoneTextBox.Size = new System.Drawing.Size(311, 38);
            this.cellPhoneTextBox.TabIndex = 10;
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.BackColor = System.Drawing.Color.Transparent;
            this.address1Label.Location = new System.Drawing.Point(21, 453);
            this.address1Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(150, 32);
            this.address1Label.TabIndex = 11;
            this.address1Label.Text = "Address 1:";
            // 
            // address1TextBox
            // 
            this.address1TextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.address1TextBox.Location = new System.Drawing.Point(27, 494);
            this.address1TextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(695, 38);
            this.address1TextBox.TabIndex = 12;
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.BackColor = System.Drawing.Color.Transparent;
            this.address2Label.Location = new System.Drawing.Point(27, 568);
            this.address2Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(150, 32);
            this.address2Label.TabIndex = 13;
            this.address2Label.Text = "Address 2:";
            // 
            // address2TextBox
            // 
            this.address2TextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.address2TextBox.Location = new System.Drawing.Point(27, 608);
            this.address2TextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(695, 38);
            this.address2TextBox.TabIndex = 14;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Location = new System.Drawing.Point(27, 670);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(72, 32);
            this.cityLabel.TabIndex = 15;
            this.cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cityTextBox.Location = new System.Drawing.Point(27, 711);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(265, 38);
            this.cityTextBox.TabIndex = 16;
            // 
            // stateTextBox
            // 
            this.stateTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.stateTextBox.Location = new System.Drawing.Point(331, 711);
            this.stateTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(103, 38);
            this.stateTextBox.TabIndex = 17;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.BackColor = System.Drawing.Color.Transparent;
            this.stateLabel.Location = new System.Drawing.Point(325, 670);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(90, 32);
            this.stateLabel.TabIndex = 18;
            this.stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.BackColor = System.Drawing.Color.Transparent;
            this.zipLabel.Location = new System.Drawing.Point(472, 672);
            this.zipLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(63, 32);
            this.zipLabel.TabIndex = 19;
            this.zipLabel.Text = "Zip:";
            // 
            // zipTextBox
            // 
            this.zipTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.zipTextBox.Location = new System.Drawing.Point(477, 711);
            this.zipTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(247, 38);
            this.zipTextBox.TabIndex = 20;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.BackColor = System.Drawing.Color.Transparent;
            this.countryLabel.Location = new System.Drawing.Point(27, 770);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(114, 32);
            this.countryLabel.TabIndex = 21;
            this.countryLabel.Text = "Country";
            // 
            // countryTextBox
            // 
            this.countryTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.countryTextBox.Location = new System.Drawing.Point(27, 808);
            this.countryTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(695, 38);
            this.countryTextBox.TabIndex = 22;
            // 
            // contactPictureBox
            // 
            this.contactPictureBox.Location = new System.Drawing.Point(21, 29);
            this.contactPictureBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.contactPictureBox.Name = "contactPictureBox";
            this.contactPictureBox.Size = new System.Drawing.Size(347, 262);
            this.contactPictureBox.TabIndex = 23;
            this.contactPictureBox.TabStop = false;
            // 
            // EditContactsMenu
            // 
            this.EditContactsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.EditContactsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutContactToolStripMenuItem,
            this.copyContactToolStripMenuItem,
            this.pasteContactToolStripMenuItem});
            this.EditContactsMenu.Name = "EditContactsMenu";
            this.EditContactsMenu.Size = new System.Drawing.Size(278, 142);
            // 
            // cutContactToolStripMenuItem
            // 
            this.cutContactToolStripMenuItem.Name = "cutContactToolStripMenuItem";
            this.cutContactToolStripMenuItem.Size = new System.Drawing.Size(277, 46);
            this.cutContactToolStripMenuItem.Text = "Cut Contact";
            this.cutContactToolStripMenuItem.Click += new System.EventHandler(this.cutContactToolStripMenuItem_Click);
            // 
            // copyContactToolStripMenuItem
            // 
            this.copyContactToolStripMenuItem.Name = "copyContactToolStripMenuItem";
            this.copyContactToolStripMenuItem.Size = new System.Drawing.Size(277, 46);
            this.copyContactToolStripMenuItem.Text = "Copy Contact";
            this.copyContactToolStripMenuItem.Click += new System.EventHandler(this.copyContactToolStripMenuItem_Click);
            // 
            // pasteContactToolStripMenuItem
            // 
            this.pasteContactToolStripMenuItem.Name = "pasteContactToolStripMenuItem";
            this.pasteContactToolStripMenuItem.Size = new System.Drawing.Size(277, 46);
            this.pasteContactToolStripMenuItem.Text = "Paste Contact";
            this.pasteContactToolStripMenuItem.Click += new System.EventHandler(this.pasteContactToolStripMenuItem_Click);
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(MultiSDIContact.Services.Entities.Contact);
            // 
            // contactsToolTip
            // 
            this.contactsToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ContactDetailsForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(771, 978);
            this.ContextMenuStrip = this.EditContactsMenu;
            this.Controls.Add(this.contactPictureBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.address2Label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(this.address1Label);
            this.Controls.Add(this.cellPhoneTextBox);
            this.Controls.Add(this.cellPhoneLabel);
            this.Controls.Add(this.homeTextBox);
            this.Controls.Add(this.homePhoneLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactDetailsForm";
            this.ShowIcon = false;
            this.Text = "Contact Details";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ContactDetailsForm_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.ContactDetailsForm_DragOver);
            ((System.ComponentModel.ISupportInitialize)(this.contactPictureBox)).EndInit();
            this.EditContactsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label homePhoneLabel;
        private System.Windows.Forms.TextBox homeTextBox;
        private System.Windows.Forms.Label cellPhoneLabel;
        private System.Windows.Forms.TextBox cellPhoneTextBox;
        private System.Windows.Forms.Label address1Label;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.PictureBox contactPictureBox;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private System.Windows.Forms.ContextMenuStrip EditContactsMenu;
        private System.Windows.Forms.ToolStripMenuItem cutContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteContactToolStripMenuItem;
        private System.Windows.Forms.ToolTip contactsToolTip;
    }
}