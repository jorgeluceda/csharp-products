using CoreLibrary;

namespace SingleDocumentInterface
{
    partial class PreferencesDialog : BaseForm
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
            this.preferencesBackColorTextBox = new System.Windows.Forms.TextBox();
            this.preferencesFontTextBox = new System.Windows.Forms.TextBox();
            this.preferencesTextColorTextBox = new System.Windows.Forms.TextBox();
            this.preferencesDocumentSizeTextBox = new System.Windows.Forms.TextBox();
            this.preferencesDocumentLocationTextBox = new System.Windows.Forms.TextBox();
            this.preferencesDocumentTitleTextBox = new System.Windows.Forms.TextBox();

            this.preferencesBackColorLabel = new System.Windows.Forms.Label();
            this.preferencesFontLabel = new System.Windows.Forms.Label();
            this.preferencesTextColorLabel = new System.Windows.Forms.Label();
            this.preferencesDocumentSizeLabel = new System.Windows.Forms.Label();
            this.preferencesDocumentLocationLabel = new System.Windows.Forms.Label();
            this.preferencesDocumentTitleLabel = new System.Windows.Forms.Label();
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
            // preferencesBackColorTextBox
            // 
            this.hpHelp.SetHelpString(this.preferencesBackColorTextBox, "The Background color of the text.");
            this.preferencesBackColorTextBox.Location = new System.Drawing.Point(108, 20);
            this.preferencesBackColorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.preferencesBackColorTextBox.Name = "preferencesBackColorTextBox";
            this.hpHelp.SetShowHelp(this.preferencesBackColorTextBox, true);
            this.preferencesBackColorTextBox.Size = new System.Drawing.Size(132, 22);
            this.preferencesBackColorTextBox.TabIndex = 3;
            this.ttToolTip.SetToolTip(this.preferencesBackColorTextBox, "Width of the child windows. EntpreferencesBackColorTextBoxer an integer [10 - 700" +
        "]");
            this.preferencesBackColorTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.preferencesBackColor_Validating);
            // 
            // preferencesFontTextBox
            // 
            this.hpHelp.SetHelpString(this.preferencesFontTextBox, "Height of the child windows. Enter an integer [10 - 700]");
            this.preferencesFontTextBox.Location = new System.Drawing.Point(108, 52);
            this.preferencesFontTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.preferencesFontTextBox.Name = "preferencesFontTextBox";
            this.hpHelp.SetShowHelp(this.preferencesFontTextBox, true);
            this.preferencesFontTextBox.Size = new System.Drawing.Size(132, 22);
            this.preferencesFontTextBox.TabIndex = 4;
            this.ttToolTip.SetToolTip(this.preferencesFontTextBox, "Height of the child windows. Enter an integer [10 - 700]");
            this.preferencesFontTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.preferencesFont_Validating);
            // 
            // preferencesTextColorTextBox
            // 
            this.hpHelp.SetHelpString(this.preferencesTextColorTextBox, "Ratio between the width and height of the child windows. Enter a float [0.1 - 100" +
        "]");
            this.preferencesTextColorTextBox.Location = new System.Drawing.Point(108, 84);
            this.preferencesTextColorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.preferencesTextColorTextBox.Name = "preferencesTextColorTextBox";
            this.hpHelp.SetShowHelp(this.preferencesTextColorTextBox, true);
            this.preferencesTextColorTextBox.Size = new System.Drawing.Size(132, 22);
            this.preferencesTextColorTextBox.TabIndex = 5;
            this.ttToolTip.SetToolTip(this.preferencesTextColorTextBox, "Ratio between the width and height of the child windows. Enter a float [0.1 - 100" +
        "]");
            this.preferencesTextColorTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.preferencesTextColor_Validating);
            // 
            // preferencesDocumentSizeTextBox
            // 
            this.hpHelp.SetHelpString(this.preferencesDocumentSizeTextBox, "Width of the child windows. Enter an integer [10 - 700]");
            this.preferencesDocumentSizeTextBox.Location = new System.Drawing.Point(409, 20);
            this.preferencesDocumentSizeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.preferencesDocumentSizeTextBox.Name = "preferencesDocumentSizeTextBox";
            this.hpHelp.SetShowHelp(this.preferencesDocumentSizeTextBox, true);
            this.preferencesDocumentSizeTextBox.Size = new System.Drawing.Size(132, 22);
            this.preferencesDocumentSizeTextBox.TabIndex = 12;
            this.ttToolTip.SetToolTip(this.preferencesDocumentSizeTextBox, "Width of the child windows. Enter an integer [10 - 700]");
            // 
            // preferencesDocumentLocationTextBox
            // 
            this.preferencesDocumentLocationTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.hpHelp.SetHelpString(this.preferencesDocumentLocationTextBox, "Ratio between the width and height of the child windows. Enter a float [0.1 - 100" +
        "]");
            this.preferencesErrorProvider.SetIconAlignment(this.preferencesDocumentLocationTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.preferencesDocumentLocationTextBox.Location = new System.Drawing.Point(409, 84);
            this.preferencesDocumentLocationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.preferencesDocumentLocationTextBox.Name = "preferencesDocumentLocationTextBox";
            this.hpHelp.SetShowHelp(this.preferencesDocumentLocationTextBox, true);
            this.preferencesDocumentLocationTextBox.Size = new System.Drawing.Size(132, 22);
            this.preferencesDocumentLocationTextBox.TabIndex = 14;
            this.ttToolTip.SetToolTip(this.preferencesDocumentLocationTextBox, "Ratio between the width and height of the child windows. Enter a float [0.1 - 100" +
        "]");
            // 
            // preferencesDocumentTitleTextBox
            // 
            this.hpHelp.SetHelpString(this.preferencesDocumentTitleTextBox, "Height of the child windows. Enter an integer [10 - 700]");
            this.preferencesDocumentTitleTextBox.Location = new System.Drawing.Point(409, 52);
            this.preferencesDocumentTitleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.preferencesDocumentTitleTextBox.Name = "preferencesDocumentTitleTextBox";
            this.hpHelp.SetShowHelp(this.preferencesDocumentTitleTextBox, true);
            this.preferencesDocumentTitleTextBox.Size = new System.Drawing.Size(132, 22);
            this.preferencesDocumentTitleTextBox.TabIndex = 0;
            this.ttToolTip.SetToolTip(this.preferencesDocumentTitleTextBox, "Height of the child windows. Enter an integer [10 - 700]");
            // 
            // preferencesBackColorLabel
            // 
            this.preferencesBackColorLabel.AutoSize = true;
            this.preferencesBackColorLabel.Location = new System.Drawing.Point(7, 23);
            this.preferencesBackColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preferencesBackColorLabel.Name = "preferencesBackColorLabel";
            this.preferencesBackColorLabel.Size = new System.Drawing.Size(93, 17);
            this.preferencesBackColorLabel.TabIndex = 9;
            this.preferencesBackColorLabel.Text = "T. Back Color";
            // 
            // preferencesFontLabel
            // 
            this.preferencesFontLabel.AutoSize = true;
            this.preferencesFontLabel.Location = new System.Drawing.Point(7, 55);
            this.preferencesFontLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preferencesFontLabel.Name = "preferencesFontLabel";
            this.preferencesFontLabel.Size = new System.Drawing.Size(58, 17);
            this.preferencesFontLabel.TabIndex = 10;
            this.preferencesFontLabel.Text = "T. Color";
            // 
            // preferencesTextColorLabel
            // 
            this.preferencesTextColorLabel.AutoSize = true;
            this.preferencesTextColorLabel.Location = new System.Drawing.Point(8, 86);
            this.preferencesTextColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preferencesTextColorLabel.Name = "preferencesTextColorLabel";
            this.preferencesTextColorLabel.Size = new System.Drawing.Size(67, 17);
            this.preferencesTextColorLabel.TabIndex = 11;
            this.preferencesTextColorLabel.Text = "Text Font";
            // 
            // preferencesDocumentSizeLabel
            // 
            this.preferencesDocumentSizeLabel.AutoSize = true;
            this.preferencesDocumentSizeLabel.Location = new System.Drawing.Point(276, 23);
            this.preferencesDocumentSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preferencesDocumentSizeLabel.Name = "preferencesDocumentSizeLabel";
            this.preferencesDocumentSizeLabel.Size = new System.Drawing.Size(103, 17);
            this.preferencesDocumentSizeLabel.TabIndex = 15;
            this.preferencesDocumentSizeLabel.Text = "Document Size";
            this.ttToolTip.SetToolTip(this.preferencesDocumentSizeLabel, "Width of the child windows. EntpreferencesBackColorTextBoxer an integer [10 - 700" +
        "]");
            // 
            // preferencesDocumentLocationLabel
            // 
            this.preferencesDocumentLocationLabel.AutoSize = true;
            this.preferencesDocumentLocationLabel.Location = new System.Drawing.Point(277, 86);
            this.preferencesDocumentLocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preferencesDocumentLocationLabel.Name = "preferencesDocumentLocationLabel";
            this.preferencesDocumentLocationLabel.Size = new System.Drawing.Size(130, 17);
            this.preferencesDocumentLocationLabel.TabIndex = 17;
            this.preferencesDocumentLocationLabel.Text = "Document Location";
            // 
            // preferencesDocumentTitleLabel
            // 
            this.preferencesDocumentTitleLabel.AutoSize = true;
            this.preferencesDocumentTitleLabel.Location = new System.Drawing.Point(276, 55);
            this.preferencesDocumentTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preferencesDocumentTitleLabel.Name = "preferencesDocumentTitleLabel";
            this.preferencesDocumentTitleLabel.Size = new System.Drawing.Size(103, 17);
            this.preferencesDocumentTitleLabel.TabIndex = 16;
            this.preferencesDocumentTitleLabel.Text = "Document Title";
            // 
            // preferencesPanel
            // 
            this.preferencesPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.preferencesPanel.Controls.Add(this.preferencesDocumentTitleTextBox);
            this.preferencesPanel.Controls.Add(this.preferencesDocumentSizeTextBox);
            this.preferencesPanel.Controls.Add(this.preferencesDocumentLocationTextBox);
            this.preferencesPanel.Controls.Add(this.preferencesDocumentSizeLabel);
            this.preferencesPanel.Controls.Add(this.preferencesDocumentLocationLabel);
            this.preferencesPanel.Controls.Add(this.preferencesDocumentTitleLabel);
            this.preferencesPanel.Controls.Add(this.preferencesBackColorLabel);
            this.preferencesPanel.Controls.Add(this.preferencesTextColorLabel);
            this.preferencesPanel.Controls.Add(this.preferencesBackColorTextBox);
            this.preferencesPanel.Controls.Add(this.preferencesFontLabel);
            this.preferencesPanel.Controls.Add(this.preferencesTextColorTextBox);
            this.preferencesPanel.Controls.Add(this.preferencesFontTextBox);
            this.preferencesPanel.Location = new System.Drawing.Point(13, 73);
            this.preferencesPanel.Margin = new System.Windows.Forms.Padding(4);
            this.preferencesPanel.Name = "preferencesPanel";
            this.preferencesPanel.Size = new System.Drawing.Size(570, 133);
            this.preferencesPanel.TabIndex = 12;
            // 
            // preferencesOkButton
            // 
            this.preferencesOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.preferencesOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.hpHelp.SetHelpString(this.preferencesOkButton, "Save the current values");
            this.preferencesOkButton.Location = new System.Drawing.Point(270, 273);
            this.preferencesOkButton.Margin = new System.Windows.Forms.Padding(4);
            this.preferencesOkButton.Name = "preferencesOkButton";
            this.hpHelp.SetShowHelp(this.preferencesOkButton, true);
            this.preferencesOkButton.Size = new System.Drawing.Size(100, 28);
            this.preferencesOkButton.TabIndex = 8;
            this.preferencesOkButton.Text = "Ok";
            this.preferencesOkButton.UseVisualStyleBackColor = true;
            this.preferencesOkButton.Click += new System.EventHandler(this.preferencesOkButton_Click);
            // 
            // preferencesApplyButton
            // 
            this.preferencesApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hpHelp.SetHelpString(this.preferencesApplyButton, "Apply the current values");
            this.preferencesApplyButton.Location = new System.Drawing.Point(377, 273);
            this.preferencesApplyButton.Margin = new System.Windows.Forms.Padding(4);
            this.preferencesApplyButton.Name = "preferencesApplyButton";
            this.hpHelp.SetShowHelp(this.preferencesApplyButton, true);
            this.preferencesApplyButton.Size = new System.Drawing.Size(100, 28);
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
            this.preferencesCancelButton.Location = new System.Drawing.Point(483, 273);
            this.preferencesCancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.preferencesCancelButton.Name = "preferencesCancelButton";
            this.hpHelp.SetShowHelp(this.preferencesCancelButton, true);
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
            this.AcceptButton = this.preferencesOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.preferencesCancelButton;
            this.ClientSize = new System.Drawing.Size(594, 314);
            this.Controls.Add(this.preferencesCancelButton);
            this.Controls.Add(this.preferencesApplyButton);
            this.Controls.Add(this.preferencesPanel);
            this.Controls.Add(this.preferencesOkButton);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(352, 299);
            this.Name = "PreferencesDialog";
            this.Text = "Preferences Dialog";
            this.Load += new System.EventHandler(this.PreferencesDialog_Load);
            this.Controls.SetChildIndex(this.preferencesOkButton, 0);
            this.Controls.SetChildIndex(this.preferencesPanel, 0);
            this.Controls.SetChildIndex(this.preferencesApplyButton, 0);
            this.Controls.SetChildIndex(this.preferencesCancelButton, 0);
            this.preferencesPanel.ResumeLayout(false);
            this.preferencesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preferencesErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox preferencesBackColorTextBox;
        private System.Windows.Forms.TextBox preferencesFontTextBox;
        private System.Windows.Forms.TextBox preferencesTextColorTextBox;
        private System.Windows.Forms.TextBox preferencesDocumentSizeTextBox;
        private System.Windows.Forms.TextBox preferencesDocumentLocationTextBox;
        private System.Windows.Forms.TextBox preferencesDocumentTitleTextBox;

        private System.Windows.Forms.Label preferencesBackColorLabel;
        private System.Windows.Forms.Label preferencesFontLabel;
        private System.Windows.Forms.Label preferencesTextColorLabel;
        private System.Windows.Forms.Label preferencesDocumentSizeLabel;
        private System.Windows.Forms.Label preferencesDocumentLocationLabel;
        private System.Windows.Forms.Label preferencesDocumentTitleLabel;
    
        private System.Windows.Forms.Panel preferencesPanel;
        private System.Windows.Forms.Button preferencesOkButton;
        private System.Windows.Forms.Button preferencesApplyButton;
        private System.Windows.Forms.Button preferencesCancelButton;
        private System.Windows.Forms.ErrorProvider preferencesErrorProvider;
        private System.Windows.Forms.HelpProvider hpHelp;
        private System.Windows.Forms.ToolTip ttToolTip;
    }
}