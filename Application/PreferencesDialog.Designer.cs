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
            this.components = new System.ComponentModel.Container();
            this.preferencesWidthTextBox = new System.Windows.Forms.TextBox();
            this.preferencesHeightTextBox = new System.Windows.Forms.TextBox();
            this.preferencesRatioTextBox = new System.Windows.Forms.TextBox();
            this.preferencesWidthLabel = new System.Windows.Forms.Label();
            this.preferencesHeightLabel = new System.Windows.Forms.Label();
            this.preferencesRatioLabel = new System.Windows.Forms.Label();
            this.preferencesPanel = new System.Windows.Forms.Panel();
            this.preferencesOkButton = new System.Windows.Forms.Button();
            this.preferencesApplyButton = new System.Windows.Forms.Button();
            this.preferencesCancelButton = new System.Windows.Forms.Button();
            this.preferencesErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.preferencesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preferencesErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // preferencesWidthTextBox
            // 
            this.preferencesWidthTextBox.Location = new System.Drawing.Point(85, 20);
            this.preferencesWidthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.preferencesWidthTextBox.Name = "preferencesWidthTextBox";
            this.preferencesWidthTextBox.Size = new System.Drawing.Size(132, 22);
            this.preferencesWidthTextBox.TabIndex = 3;
            this.preferencesWidthTextBox.TextAlignChanged += new System.EventHandler(this.preferencesHeightTextBox_TextChanged);
            this.preferencesWidthTextBox.TextChanged += new System.EventHandler(this.preferencesWidthTextBox_TextChanged);
            this.preferencesWidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.preferencesWidthTextBox_Validating);
            // 
            // preferencesHeightTextBox
            // 
            this.preferencesHeightTextBox.Location = new System.Drawing.Point(85, 52);
            this.preferencesHeightTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.preferencesHeightTextBox.Name = "preferencesHeightTextBox";
            this.preferencesHeightTextBox.Size = new System.Drawing.Size(132, 22);
            this.preferencesHeightTextBox.TabIndex = 4;
            this.preferencesHeightTextBox.TextChanged += new System.EventHandler(this.preferencesHeightTextBox_TextChanged);
            this.preferencesHeightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.preferencesHeightTextBox_Validating);
            // 
            // preferencesRatioTextBox
            // 
            this.preferencesRatioTextBox.Location = new System.Drawing.Point(85, 84);
            this.preferencesRatioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.preferencesRatioTextBox.Name = "preferencesRatioTextBox";
            this.preferencesRatioTextBox.Size = new System.Drawing.Size(132, 22);
            this.preferencesRatioTextBox.TabIndex = 5;
            this.preferencesRatioTextBox.TextChanged += new System.EventHandler(this.preferencesRatioTextBox_TextChanged);
            this.preferencesRatioTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.preferencesRatioTextBox_Validating);
            // 
            // preferencesWidthLabel
            // 
            this.preferencesWidthLabel.AutoSize = true;
            this.preferencesWidthLabel.Location = new System.Drawing.Point(7, 23);
            this.preferencesWidthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preferencesWidthLabel.Name = "preferencesWidthLabel";
            this.preferencesWidthLabel.Size = new System.Drawing.Size(44, 17);
            this.preferencesWidthLabel.TabIndex = 9;
            this.preferencesWidthLabel.Text = "Width";
            // 
            // preferencesHeightLabel
            // 
            this.preferencesHeightLabel.AutoSize = true;
            this.preferencesHeightLabel.Location = new System.Drawing.Point(7, 55);
            this.preferencesHeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preferencesHeightLabel.Name = "preferencesHeightLabel";
            this.preferencesHeightLabel.Size = new System.Drawing.Size(49, 17);
            this.preferencesHeightLabel.TabIndex = 10;
            this.preferencesHeightLabel.Text = "Height";
            // 
            // preferencesRatioLabel
            // 
            this.preferencesRatioLabel.AutoSize = true;
            this.preferencesRatioLabel.Location = new System.Drawing.Point(8, 86);
            this.preferencesRatioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preferencesRatioLabel.Name = "preferencesRatioLabel";
            this.preferencesRatioLabel.Size = new System.Drawing.Size(41, 17);
            this.preferencesRatioLabel.TabIndex = 11;
            this.preferencesRatioLabel.Text = "Ratio";
            // 
            // preferencesPanel
            // 
            this.preferencesPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.preferencesPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.preferencesPanel.Controls.Add(this.preferencesWidthLabel);
            this.preferencesPanel.Controls.Add(this.preferencesRatioLabel);
            this.preferencesPanel.Controls.Add(this.preferencesWidthTextBox);
            this.preferencesPanel.Controls.Add(this.preferencesHeightLabel);
            this.preferencesPanel.Controls.Add(this.preferencesRatioTextBox);
            this.preferencesPanel.Controls.Add(this.preferencesHeightTextBox);
            this.preferencesPanel.Location = new System.Drawing.Point(83, 87);
            this.preferencesPanel.Margin = new System.Windows.Forms.Padding(4);
            this.preferencesPanel.Name = "preferencesPanel";
            this.preferencesPanel.Size = new System.Drawing.Size(253, 127);
            this.preferencesPanel.TabIndex = 12;
            // 
            // preferencesOkButton
            // 
            this.preferencesOkButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.preferencesOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.preferencesOkButton.Location = new System.Drawing.Point(54, 304);
            this.preferencesOkButton.Margin = new System.Windows.Forms.Padding(4);
            this.preferencesOkButton.Name = "preferencesOkButton";
            this.preferencesOkButton.Size = new System.Drawing.Size(100, 28);
            this.preferencesOkButton.TabIndex = 8;
            this.preferencesOkButton.Text = "Ok";
            this.preferencesOkButton.UseVisualStyleBackColor = true;
            this.preferencesOkButton.Click += new System.EventHandler(this.preferencesOkButton_Click);
            // 
            // preferencesApplyButton
            // 
            this.preferencesApplyButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.preferencesApplyButton.Location = new System.Drawing.Point(162, 304);
            this.preferencesApplyButton.Margin = new System.Windows.Forms.Padding(4);
            this.preferencesApplyButton.Name = "preferencesApplyButton";
            this.preferencesApplyButton.Size = new System.Drawing.Size(100, 28);
            this.preferencesApplyButton.TabIndex = 7;
            this.preferencesApplyButton.Text = "Apply";
            this.preferencesApplyButton.UseVisualStyleBackColor = true;
            this.preferencesApplyButton.Click += new System.EventHandler(this.preferencesApplyButton_Click);
            // 
            // preferencesCancelButton
            // 
            this.preferencesCancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.preferencesCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.preferencesCancelButton.Location = new System.Drawing.Point(270, 304);
            this.preferencesCancelButton.Margin = new System.Windows.Forms.Padding(4);

            this.preferencesCancelButton.Name = "preferencesCancelButton";
            this.preferencesCancelButton.Size = new System.Drawing.Size(100, 28);
            this.preferencesCancelButton.TabIndex = 6;
            this.preferencesCancelButton.Text = "Cancel";
            this.preferencesCancelButton.UseVisualStyleBackColor = true;
            this.preferencesCancelButton.Click += new System.EventHandler(this.preferencesCancelButton_Click);
            // 
            // preferencesErrorProvider
            // 
            this.preferencesErrorProvider.ContainerControl = this;
            // 
            // PreferencesDialog
            // 
            this.AcceptButton = this.preferencesApplyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.preferencesCancelButton;
            this.ClientSize = new System.Drawing.Size(422, 344);
            this.Controls.Add(this.preferencesCancelButton);
            this.Controls.Add(this.preferencesApplyButton);
            this.Controls.Add(this.preferencesPanel);
            this.Controls.Add(this.preferencesOkButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(354, 305);
            this.Name = "PreferencesDialog";
            this.Text = "Preferences Dialog";
            this.Load += new System.EventHandler(this.PreferencesDialog_Load);
            this.preferencesPanel.ResumeLayout(false);
            this.preferencesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preferencesErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox preferencesWidthTextBox;
        private System.Windows.Forms.TextBox preferencesHeightTextBox;
        private System.Windows.Forms.TextBox preferencesRatioTextBox;
        private System.Windows.Forms.Label preferencesWidthLabel;
        private System.Windows.Forms.Label preferencesHeightLabel;
        private System.Windows.Forms.Label preferencesRatioLabel;
        private System.Windows.Forms.Panel preferencesPanel;
        private System.Windows.Forms.Button preferencesOkButton;
        private System.Windows.Forms.Button preferencesApplyButton;
        private System.Windows.Forms.Button preferencesCancelButton;
        private System.Windows.Forms.ErrorProvider preferencesErrorProvider;
    }
}
