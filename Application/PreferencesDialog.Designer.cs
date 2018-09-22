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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesDialog));
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
            this.hpHelp = new System.Windows.Forms.HelpProvider();
            this.ttToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.preferencesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preferencesErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // preferencesWidthTextBox
            // 
            this.hpHelp.SetHelpString(this.preferencesWidthTextBox, "Width of the child windows. Double [10 - 700]");
            this.preferencesWidthTextBox.Location = new System.Drawing.Point(96, 25);
            this.preferencesWidthTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.preferencesWidthTextBox.Name = "preferencesWidthTextBox";
            this.hpHelp.SetShowHelp(this.preferencesWidthTextBox, true);
            this.preferencesWidthTextBox.Size = new System.Drawing.Size(148, 26);
            this.preferencesWidthTextBox.TabIndex = 3;
            this.ttToolTip.SetToolTip(this.preferencesWidthTextBox, "Width of the child windows. Double [10 - 700]");
            this.preferencesWidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.preferencesWidthTextBox_Validating);
            // 
            // preferencesHeightTextBox
            // 
            this.hpHelp.SetHelpString(this.preferencesHeightTextBox, "Height of the child windows. Double [10 - 700]");
            this.preferencesHeightTextBox.Location = new System.Drawing.Point(96, 65);
            this.preferencesHeightTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.preferencesHeightTextBox.Name = "preferencesHeightTextBox";
            this.hpHelp.SetShowHelp(this.preferencesHeightTextBox, true);
            this.preferencesHeightTextBox.Size = new System.Drawing.Size(148, 26);
            this.preferencesHeightTextBox.TabIndex = 4;
            this.ttToolTip.SetToolTip(this.preferencesHeightTextBox, "Height of the child windows. Double [10 - 700]");
            this.preferencesHeightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.preferencesHeightTextBox_Validating);
            // 
            // preferencesRatioTextBox
            // 
            this.hpHelp.SetHelpString(this.preferencesRatioTextBox, "Ratio between the width and heigth of the child windows. Double [0.1 - 100]");
            this.preferencesRatioTextBox.Location = new System.Drawing.Point(96, 105);
            this.preferencesRatioTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.preferencesRatioTextBox.Name = "preferencesRatioTextBox";
            this.hpHelp.SetShowHelp(this.preferencesRatioTextBox, true);
            this.preferencesRatioTextBox.Size = new System.Drawing.Size(148, 26);
            this.preferencesRatioTextBox.TabIndex = 5;
            this.ttToolTip.SetToolTip(this.preferencesRatioTextBox, "Ratio between the width and heigth of the child windows. Double [0.1 - 100]");
            this.preferencesRatioTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.preferencesRatioTextBox_Validating);
            // 
            // preferencesWidthLabel
            // 
            this.preferencesWidthLabel.AutoSize = true;
            this.preferencesWidthLabel.Location = new System.Drawing.Point(8, 29);
            this.preferencesWidthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preferencesWidthLabel.Name = "preferencesWidthLabel";
            this.preferencesWidthLabel.Size = new System.Drawing.Size(50, 20);
            this.preferencesWidthLabel.TabIndex = 9;
            this.preferencesWidthLabel.Text = "Width";
            // 
            // preferencesHeightLabel
            // 
            this.preferencesHeightLabel.AutoSize = true;
            this.preferencesHeightLabel.Location = new System.Drawing.Point(8, 69);
            this.preferencesHeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preferencesHeightLabel.Name = "preferencesHeightLabel";
            this.preferencesHeightLabel.Size = new System.Drawing.Size(56, 20);
            this.preferencesHeightLabel.TabIndex = 10;
            this.preferencesHeightLabel.Text = "Height";
            // 
            // preferencesRatioLabel
            // 
            this.preferencesRatioLabel.AutoSize = true;
            this.preferencesRatioLabel.Location = new System.Drawing.Point(9, 108);
            this.preferencesRatioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preferencesRatioLabel.Name = "preferencesRatioLabel";
            this.preferencesRatioLabel.Size = new System.Drawing.Size(47, 20);
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
            this.preferencesPanel.Location = new System.Drawing.Point(93, 109);
            this.preferencesPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.preferencesPanel.Name = "preferencesPanel";
            this.preferencesPanel.Size = new System.Drawing.Size(285, 158);
            this.preferencesPanel.TabIndex = 12;
            // 
            // preferencesOkButton
            // 
            this.preferencesOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.preferencesOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.hpHelp.SetHelpString(this.preferencesOkButton, "Save the current values");
            this.preferencesOkButton.Location = new System.Drawing.Point(109, 380);
            this.preferencesOkButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.preferencesOkButton.Name = "preferencesOkButton";
            this.hpHelp.SetShowHelp(this.preferencesOkButton, true);
            this.preferencesOkButton.Size = new System.Drawing.Size(112, 35);
            this.preferencesOkButton.TabIndex = 8;
            this.preferencesOkButton.Text = "Ok";
            this.preferencesOkButton.UseVisualStyleBackColor = true;
            this.preferencesOkButton.Click += new System.EventHandler(this.preferencesOkButton_Click);
            // 
            // preferencesApplyButton
            // 
            this.preferencesApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hpHelp.SetHelpString(this.preferencesApplyButton, "Apply the current values");
            this.preferencesApplyButton.Location = new System.Drawing.Point(229, 380);
            this.preferencesApplyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.preferencesApplyButton.Name = "preferencesApplyButton";
            this.hpHelp.SetShowHelp(this.preferencesApplyButton, true);
            this.preferencesApplyButton.Size = new System.Drawing.Size(112, 35);
            this.preferencesApplyButton.TabIndex = 7;
            this.preferencesApplyButton.Text = "Apply";
            this.preferencesApplyButton.UseVisualStyleBackColor = true;
            this.preferencesApplyButton.Click += new System.EventHandler(this.preferencesApplyButton_Click);
            // 
            // preferencesCancelButton
            // 
            this.preferencesCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.preferencesCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.hpHelp.SetHelpString(this.preferencesCancelButton, "Cancel edition of current values");
            this.preferencesCancelButton.Location = new System.Drawing.Point(349, 380);
            this.preferencesCancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.preferencesCancelButton.Name = "preferencesCancelButton";
            this.hpHelp.SetShowHelp(this.preferencesCancelButton, true);
            this.preferencesCancelButton.Size = new System.Drawing.Size(112, 35);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.preferencesCancelButton;
            this.ClientSize = new System.Drawing.Size(474, 431);
            this.Controls.Add(this.preferencesCancelButton);
            this.Controls.Add(this.preferencesApplyButton);
            this.Controls.Add(this.preferencesPanel);
            this.Controls.Add(this.preferencesOkButton);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(394, 362);
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
        private System.Windows.Forms.HelpProvider hpHelp;
        private System.Windows.Forms.ToolTip ttToolTip;
    }
}
