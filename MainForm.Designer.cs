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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnSaveSize = new System.Windows.Forms.Button();
            this.btnSaveLocation = new System.Windows.Forms.Button();
            this.btnResetSettings = new System.Windows.Forms.Button();
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
            this.gbSetteingsContainer.Location = new System.Drawing.Point(10, 10);
            this.gbSetteingsContainer.Name = "gbSetteingsContainer";
            this.gbSetteingsContainer.Size = new System.Drawing.Size(285, 100);
            this.gbSetteingsContainer.TabIndex = 0;
            this.gbSetteingsContainer.TabStop = false;
            this.gbSetteingsContainer.Text = "Settings";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a name:";
            // 
            // btnAddName
            // 
            this.btnAddName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddName.Location = new System.Drawing.Point(190, 39);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(89, 23);
            this.btnAddName.TabIndex = 2;
            this.btnAddName.Text = "Add Name";
            this.btnAddName.UseVisualStyleBackColor = true;
            // 
            // btnSaveSize
            // 
            this.btnSaveSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveSize.Location = new System.Drawing.Point(7, 71);
            this.btnSaveSize.Name = "btnSaveSize";
            this.btnSaveSize.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSize.TabIndex = 3;
            this.btnSaveSize.Text = "Save Size";
            this.btnSaveSize.UseVisualStyleBackColor = true;
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveLocation.Location = new System.Drawing.Point(189, 71);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(90, 23);
            this.btnSaveLocation.TabIndex = 4;
            this.btnSaveLocation.Text = "Save Location";
            this.btnSaveLocation.UseVisualStyleBackColor = true;
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResetSettings.Location = new System.Drawing.Point(88, 71);
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new System.Drawing.Size(95, 23);
            this.btnResetSettings.TabIndex = 5;
            this.btnResetSettings.Text = "Reset Settings";
            this.btnResetSettings.UseVisualStyleBackColor = true;
            // 
            // lvNamesList
            // 
            this.lvNamesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNamesList.Location = new System.Drawing.Point(10, 110);
            this.lvNamesList.Name = "lvNamesList";
            this.lvNamesList.Size = new System.Drawing.Size(285, 142);
            this.lvNamesList.TabIndex = 1;
            this.lvNamesList.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 262);
            this.Controls.Add(this.lvNamesList);
            this.Controls.Add(this.gbSetteingsContainer);
            this.MinimumSize = new System.Drawing.Size(321, 300);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "User Settings";
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
