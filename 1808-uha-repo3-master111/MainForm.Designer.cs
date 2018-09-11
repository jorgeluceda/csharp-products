﻿namespace Application
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
            this.gbSetteingsContainer = new System.Windows.Forms.GroupBox();
            this.btnResetSettings = new System.Windows.Forms.Button();
            this.btnSaveLocation = new System.Windows.Forms.Button();
            this.btnSaveSize = new System.Windows.Forms.Button();
            this.btnAddName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lvNamesList = new System.Windows.Forms.ListView();
            this.gbSetteingsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSetteingsContainer
            // 
            this.gbSetteingsContainer.Controls.Add(this.btnResetSettings);
            this.gbSetteingsContainer.Controls.Add(this.btnSaveLocation);
            this.gbSetteingsContainer.Controls.Add(this.btnSaveSize);
            this.gbSetteingsContainer.Controls.Add(this.btnAddName);
            this.gbSetteingsContainer.Controls.Add(this.label1);
            this.gbSetteingsContainer.Controls.Add(this.textBox1);
            this.gbSetteingsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSetteingsContainer.Location = new System.Drawing.Point(26, 23);
            this.gbSetteingsContainer.Margin = new System.Windows.Forms.Padding(8);
            this.gbSetteingsContainer.Name = "gbSetteingsContainer";
            this.gbSetteingsContainer.Padding = new System.Windows.Forms.Padding(8);
            this.gbSetteingsContainer.Size = new System.Drawing.Size(762, 238);
            this.gbSetteingsContainer.TabIndex = 0;
            this.gbSetteingsContainer.TabStop = false;
            this.gbSetteingsContainer.Text = "Settings";
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResetSettings.Location = new System.Drawing.Point(234, 169);
            this.btnResetSettings.Margin = new System.Windows.Forms.Padding(8);
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new System.Drawing.Size(254, 54);
            this.btnResetSettings.TabIndex = 5;
            this.btnResetSettings.Text = "Reset Settings";
            this.btnResetSettings.UseVisualStyleBackColor = true;
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveLocation.Location = new System.Drawing.Point(506, 169);
            this.btnSaveLocation.Margin = new System.Windows.Forms.Padding(8);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(240, 54);
            this.btnSaveLocation.TabIndex = 4;
            this.btnSaveLocation.Text = "Save Location";
            this.btnSaveLocation.UseVisualStyleBackColor = true;
            // 
            // btnSaveSize
            // 
            this.btnSaveSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveSize.Location = new System.Drawing.Point(18, 169);
            this.btnSaveSize.Margin = new System.Windows.Forms.Padding(8);
            this.btnSaveSize.Name = "btnSaveSize";
            this.btnSaveSize.Size = new System.Drawing.Size(200, 54);
            this.btnSaveSize.TabIndex = 3;
            this.btnSaveSize.Text = "Save Size";
            this.btnSaveSize.UseVisualStyleBackColor = true;
            // 
            // btnAddName
            // 
            this.btnAddName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddName.Location = new System.Drawing.Point(508, 93);
            this.btnAddName.Margin = new System.Windows.Forms.Padding(8);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(238, 54);
            this.btnAddName.TabIndex = 2;
            this.btnAddName.Text = "Add Name";
            this.btnAddName.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a name:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(16, 97);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(470, 38);
            this.textBox1.TabIndex = 0;
            // 
            // lvNamesList
            // 
            this.lvNamesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNamesList.Location = new System.Drawing.Point(26, 261);
            this.lvNamesList.Margin = new System.Windows.Forms.Padding(8);
            this.lvNamesList.Name = "lvNamesList";
            this.lvNamesList.Size = new System.Drawing.Size(762, 340);
            this.lvNamesList.TabIndex = 1;
            this.lvNamesList.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 624);
            this.Controls.Add(this.lvNamesList);
            this.Controls.Add(this.gbSetteingsContainer);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MinimumSize = new System.Drawing.Size(812, 611);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(26, 23, 26, 23);
            this.Text = "User Settings";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbSetteingsContainer.ResumeLayout(false);
            this.gbSetteingsContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSetteingsContainer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveLocation;
        private System.Windows.Forms.Button btnSaveSize;
        private System.Windows.Forms.Button btnResetSettings;
        private System.Windows.Forms.ListView lvNamesList;
    }
}

