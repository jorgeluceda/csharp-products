using CoreLibrary;

namespace Application
{
    partial class PreferencesDialog: BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /*protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesDialog));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.preferencesWidthLabel = new System.Windows.Forms.Label();
            this.preferencesHeightLabel = new System.Windows.Forms.Label();
            this.preferencesRatioLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.preferencesOkButton = new System.Windows.Forms.Button();
            this.preferencesApplyButton = new System.Windows.Forms.Button();
            this.preferencesCancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(64, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // preferencesWidthLabel
            // 
            this.preferencesWidthLabel.AutoSize = true;
            this.preferencesWidthLabel.Location = new System.Drawing.Point(5, 19);
            this.preferencesWidthLabel.Name = "preferencesWidthLabel";
            this.preferencesWidthLabel.Size = new System.Drawing.Size(35, 13);
            this.preferencesWidthLabel.TabIndex = 9;
            this.preferencesWidthLabel.Text = "Width";
            // 
            // preferencesHeightLabel
            // 
            this.preferencesHeightLabel.AutoSize = true;
            this.preferencesHeightLabel.Location = new System.Drawing.Point(5, 45);
            this.preferencesHeightLabel.Name = "preferencesHeightLabel";
            this.preferencesHeightLabel.Size = new System.Drawing.Size(38, 13);
            this.preferencesHeightLabel.TabIndex = 10;
            this.preferencesHeightLabel.Text = "Height";
            // 
            // preferencesRatioLabel
            // 
            this.preferencesRatioLabel.AutoSize = true;
            this.preferencesRatioLabel.Location = new System.Drawing.Point(6, 70);
            this.preferencesRatioLabel.Name = "preferencesRatioLabel";
            this.preferencesRatioLabel.Size = new System.Drawing.Size(32, 13);
            this.preferencesRatioLabel.TabIndex = 11;
            this.preferencesRatioLabel.Text = "Ratio";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.preferencesWidthLabel);
            this.panel1.Controls.Add(this.preferencesRatioLabel);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.preferencesHeightLabel);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(41, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 103);
            this.panel1.TabIndex = 12;
            // 
            // preferencesOkButton
            // 
            this.preferencesOkButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.preferencesOkButton.Location = new System.Drawing.Point(9, 185);
            this.preferencesOkButton.Name = "preferencesOkButton";
            this.preferencesOkButton.Size = new System.Drawing.Size(75, 23);
            this.preferencesOkButton.TabIndex = 8;
            this.preferencesOkButton.Text = "Ok";
            this.preferencesOkButton.UseVisualStyleBackColor = true;
            this.preferencesOkButton.Click += new System.EventHandler(this.preferencesOkButton_Click);
            // 
            // preferencesApplyButton
            // 
            this.preferencesApplyButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.preferencesApplyButton.Location = new System.Drawing.Point(90, 185);
            this.preferencesApplyButton.Name = "preferencesApplyButton";
            this.preferencesApplyButton.Size = new System.Drawing.Size(75, 23);
            this.preferencesApplyButton.TabIndex = 7;
            this.preferencesApplyButton.Text = "Apply";
            this.preferencesApplyButton.UseVisualStyleBackColor = true;
            this.preferencesApplyButton.Click += new System.EventHandler(this.preferencesApplyButton_Click);
            // 
            // preferencesCancelButton
            // 
            this.preferencesCancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.preferencesCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.preferencesCancelButton.Location = new System.Drawing.Point(171, 185);
            this.preferencesCancelButton.Name = "preferencesCancelButton";
            this.preferencesCancelButton.Size = new System.Drawing.Size(75, 23);
            this.preferencesCancelButton.TabIndex = 6;
            this.preferencesCancelButton.Text = "Cancel";
            this.preferencesCancelButton.UseVisualStyleBackColor = true;
            this.preferencesCancelButton.Click += new System.EventHandler(this.preferencesCancelButton_Click);
            // 
            // PreferencesDialog
            // 
            this.AcceptButton = this.preferencesOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.preferencesCancelButton;
            this.ClientSize = new System.Drawing.Size(254, 218);
            this.Controls.Add(this.preferencesCancelButton);
            this.Controls.Add(this.preferencesApplyButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.preferencesOkButton);
            this.MinimumSize = new System.Drawing.Size(270, 257);
            this.Name = "PreferencesDialog";
            this.Text = "Preferences Dialog";
            this.Load += new System.EventHandler(this.PreferencesDialog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label preferencesWidthLabel;
        private System.Windows.Forms.Label preferencesHeightLabel;
        private System.Windows.Forms.Label preferencesRatioLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button preferencesOkButton;
        private System.Windows.Forms.Button preferencesApplyButton;
        private System.Windows.Forms.Button preferencesCancelButton;
    }
}