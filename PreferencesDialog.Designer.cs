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
            this.DocumentTitleTextBox = new System.Windows.Forms.TextBox();
            this.DocumentSizeHeightTextBox = new System.Windows.Forms.TextBox();
            this.DocumentSizeWidthTextBox = new System.Windows.Forms.TextBox();
            this.preferencesDocumentLocationLabel = new System.Windows.Forms.Label();
            this.preferencesDocumentTitleLabel = new System.Windows.Forms.Label();
            this.preferencesPanel = new System.Windows.Forms.Panel();
            this.preferencesYLabel = new System.Windows.Forms.Label();
            this.preferencesXLabel = new System.Windows.Forms.Label();
            this.DocumentLocationYTextBox = new System.Windows.Forms.TextBox();
            this.DocumentLocationXTextBox = new System.Windows.Forms.TextBox();
            this.preferencesHeightLabel = new System.Windows.Forms.Label();
            this.preferencesWidthLabel = new System.Windows.Forms.Label();
            this.TextFontButton = new System.Windows.Forms.Button();
            this.TextColorButton = new System.Windows.Forms.Button();
            this.BackColorButton = new System.Windows.Forms.Button();
            this.preferencesOkButton = new System.Windows.Forms.Button();
            this.preferencesApplyButton = new System.Windows.Forms.Button();
            this.preferencesCancelButton = new System.Windows.Forms.Button();
            this.preferencesErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.hpHelp = new System.Windows.Forms.HelpProvider();
            this.ttToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.preferencesFontDialog = new System.Windows.Forms.FontDialog();
            this.preferencesBackColorDialog = new System.Windows.Forms.ColorDialog();
            this.preferencesTextColorDialog = new System.Windows.Forms.ColorDialog();
            this.documentTitleActualLabel = new System.Windows.Forms.Label();
            this.DocumentTitleLabel = new System.Windows.Forms.Label();
            this.TextTitleLabel = new System.Windows.Forms.Label();
            this.preferencesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preferencesErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DocumentTitleTextBox
            // 
            this.hpHelp.SetHelpString(this.DocumentTitleTextBox, "Width of the child windows. Enter an integer [10 - 700]");
            this.DocumentTitleTextBox.Location = new System.Drawing.Point(389, 53);
            this.DocumentTitleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DocumentTitleTextBox.Name = "DocumentTitleTextBox";
            this.hpHelp.SetShowHelp(this.DocumentTitleTextBox, true);
            this.DocumentTitleTextBox.Size = new System.Drawing.Size(132, 22);
            this.DocumentTitleTextBox.TabIndex = 12;
            this.ttToolTip.SetToolTip(this.DocumentTitleTextBox, "Width of the child windows. Enter an integer [10 - 700]");
            // 
            // DocumentSizeHeightTextBox
            // 
            this.DocumentSizeHeightTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.hpHelp.SetHelpString(this.DocumentSizeHeightTextBox, "Ratio between the width and height of the child windows. Enter a float [0.1 - 100" +
        "]");
            this.preferencesErrorProvider.SetIconAlignment(this.DocumentSizeHeightTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.DocumentSizeHeightTextBox.Location = new System.Drawing.Point(389, 117);
            this.DocumentSizeHeightTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DocumentSizeHeightTextBox.Name = "DocumentSizeHeightTextBox";
            this.hpHelp.SetShowHelp(this.DocumentSizeHeightTextBox, true);
            this.DocumentSizeHeightTextBox.Size = new System.Drawing.Size(132, 22);
            this.DocumentSizeHeightTextBox.TabIndex = 14;
            this.ttToolTip.SetToolTip(this.DocumentSizeHeightTextBox, "Ratio between the width and height of the child windows. Enter a float [0.1 - 100" +
        "]");
            // 
            // DocumentSizeWidthTextBox
            // 
            this.hpHelp.SetHelpString(this.DocumentSizeWidthTextBox, "Height of the child windows. Enter an integer [10 - 700]");
            this.DocumentSizeWidthTextBox.Location = new System.Drawing.Point(389, 85);
            this.DocumentSizeWidthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DocumentSizeWidthTextBox.Name = "DocumentSizeWidthTextBox";
            this.hpHelp.SetShowHelp(this.DocumentSizeWidthTextBox, true);
            this.DocumentSizeWidthTextBox.Size = new System.Drawing.Size(132, 22);
            this.DocumentSizeWidthTextBox.TabIndex = 0;
            this.ttToolTip.SetToolTip(this.DocumentSizeWidthTextBox, "Height of the child windows. Enter an integer [10 - 700]");
            // 
            // preferencesDocumentLocationLabel
            // 
            this.preferencesDocumentLocationLabel.AutoSize = true;
            this.preferencesDocumentLocationLabel.Location = new System.Drawing.Point(245, 150);
            this.preferencesDocumentLocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preferencesDocumentLocationLabel.Name = "preferencesDocumentLocationLabel";
            this.preferencesDocumentLocationLabel.Size = new System.Drawing.Size(130, 17);
            this.preferencesDocumentLocationLabel.TabIndex = 17;
            this.preferencesDocumentLocationLabel.Text = "Document Location";
            // 
            // preferencesDocumentTitleLabel
            // 
            this.preferencesDocumentTitleLabel.AutoSize = true;
            this.preferencesDocumentTitleLabel.Location = new System.Drawing.Point(245, 88);
            this.preferencesDocumentTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preferencesDocumentTitleLabel.Name = "preferencesDocumentTitleLabel";
            this.preferencesDocumentTitleLabel.Size = new System.Drawing.Size(103, 17);
            this.preferencesDocumentTitleLabel.TabIndex = 16;
            this.preferencesDocumentTitleLabel.Text = "Document Size";
            // 
            // preferencesPanel
            // 
            this.preferencesPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.preferencesPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.preferencesPanel.Controls.Add(this.TextTitleLabel);
            this.preferencesPanel.Controls.Add(this.DocumentTitleLabel);
            this.preferencesPanel.Controls.Add(this.documentTitleActualLabel);
            this.preferencesPanel.Controls.Add(this.preferencesYLabel);
            this.preferencesPanel.Controls.Add(this.preferencesXLabel);
            this.preferencesPanel.Controls.Add(this.DocumentLocationYTextBox);
            this.preferencesPanel.Controls.Add(this.DocumentLocationXTextBox);
            this.preferencesPanel.Controls.Add(this.preferencesHeightLabel);
            this.preferencesPanel.Controls.Add(this.preferencesWidthLabel);
            this.preferencesPanel.Controls.Add(this.TextFontButton);
            this.preferencesPanel.Controls.Add(this.TextColorButton);
            this.preferencesPanel.Controls.Add(this.BackColorButton);
            this.preferencesPanel.Controls.Add(this.DocumentSizeWidthTextBox);
            this.preferencesPanel.Controls.Add(this.DocumentTitleTextBox);
            this.preferencesPanel.Controls.Add(this.DocumentSizeHeightTextBox);
            this.preferencesPanel.Controls.Add(this.preferencesDocumentLocationLabel);
            this.preferencesPanel.Controls.Add(this.preferencesDocumentTitleLabel);
            this.preferencesPanel.Location = new System.Drawing.Point(48, 54);
            this.preferencesPanel.Margin = new System.Windows.Forms.Padding(4);
            this.preferencesPanel.MinimumSize = new System.Drawing.Size(570, 133);
            this.preferencesPanel.Name = "preferencesPanel";
            this.preferencesPanel.Padding = new System.Windows.Forms.Padding(4);
            this.preferencesPanel.Size = new System.Drawing.Size(603, 229);
            this.preferencesPanel.TabIndex = 12;
            // 
            // preferencesYLabel
            // 
            this.preferencesYLabel.AutoSize = true;
            this.preferencesYLabel.Location = new System.Drawing.Point(529, 180);
            this.preferencesYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preferencesYLabel.Name = "preferencesYLabel";
            this.preferencesYLabel.Size = new System.Drawing.Size(17, 17);
            this.preferencesYLabel.TabIndex = 28;
            this.preferencesYLabel.Text = "Y";
            this.ttToolTip.SetToolTip(this.preferencesYLabel, "Width of the child windows. EntpreferencesBackColorTextBoxer an integer [10 - 700" +
        "]");
            // 
            // preferencesXLabel
            // 
            this.preferencesXLabel.AutoSize = true;
            this.preferencesXLabel.Location = new System.Drawing.Point(529, 149);
            this.preferencesXLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preferencesXLabel.Name = "preferencesXLabel";
            this.preferencesXLabel.Size = new System.Drawing.Size(17, 17);
            this.preferencesXLabel.TabIndex = 27;
            this.preferencesXLabel.Text = "X";
            this.ttToolTip.SetToolTip(this.preferencesXLabel, "Width of the child windows. EntpreferencesBackColorTextBoxer an integer [10 - 700" +
        "]");
            // 
            // DocumentLocationYTextBox
            // 
            this.DocumentLocationYTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.hpHelp.SetHelpString(this.DocumentLocationYTextBox, "Ratio between the width and height of the child windows. Enter a float [0.1 - 100" +
        "]");
            this.preferencesErrorProvider.SetIconAlignment(this.DocumentLocationYTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.DocumentLocationYTextBox.Location = new System.Drawing.Point(389, 177);
            this.DocumentLocationYTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DocumentLocationYTextBox.Name = "DocumentLocationYTextBox";
            this.hpHelp.SetShowHelp(this.DocumentLocationYTextBox, true);
            this.DocumentLocationYTextBox.Size = new System.Drawing.Size(132, 22);
            this.DocumentLocationYTextBox.TabIndex = 26;
            this.ttToolTip.SetToolTip(this.DocumentLocationYTextBox, "Ratio between the width and height of the child windows. Enter a float [0.1 - 100" +
        "]");
            // 
            // DocumentLocationXTextBox
            // 
            this.DocumentLocationXTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.hpHelp.SetHelpString(this.DocumentLocationXTextBox, "Ratio between the width and height of the child windows. Enter a float [0.1 - 100" +
        "]");
            this.preferencesErrorProvider.SetIconAlignment(this.DocumentLocationXTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.DocumentLocationXTextBox.Location = new System.Drawing.Point(389, 147);
            this.DocumentLocationXTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DocumentLocationXTextBox.Name = "DocumentLocationXTextBox";
            this.hpHelp.SetShowHelp(this.DocumentLocationXTextBox, true);
            this.DocumentLocationXTextBox.Size = new System.Drawing.Size(132, 22);
            this.DocumentLocationXTextBox.TabIndex = 25;
            this.ttToolTip.SetToolTip(this.DocumentLocationXTextBox, "Ratio between the width and height of the child windows. Enter a float [0.1 - 100" +
        "]");
            // 
            // preferencesHeightLabel
            // 
            this.preferencesHeightLabel.AutoSize = true;
            this.preferencesHeightLabel.Location = new System.Drawing.Point(529, 119);
            this.preferencesHeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preferencesHeightLabel.Name = "preferencesHeightLabel";
            this.preferencesHeightLabel.Size = new System.Drawing.Size(49, 17);
            this.preferencesHeightLabel.TabIndex = 24;
            this.preferencesHeightLabel.Text = "Height";
            this.ttToolTip.SetToolTip(this.preferencesHeightLabel, "Width of the child windows. EntpreferencesBackColorTextBoxer an integer [10 - 700" +
        "]");
            // 
            // preferencesWidthLabel
            // 
            this.preferencesWidthLabel.AutoSize = true;
            this.preferencesWidthLabel.Location = new System.Drawing.Point(529, 88);
            this.preferencesWidthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preferencesWidthLabel.Name = "preferencesWidthLabel";
            this.preferencesWidthLabel.Size = new System.Drawing.Size(44, 17);
            this.preferencesWidthLabel.TabIndex = 23;
            this.preferencesWidthLabel.Text = "Width";
            this.ttToolTip.SetToolTip(this.preferencesWidthLabel, "Width of the child windows. EntpreferencesBackColorTextBoxer an integer [10 - 700" +
        "]");
            // 
            // TextFontButton
            // 
            this.TextFontButton.Location = new System.Drawing.Point(34, 124);
            this.TextFontButton.Name = "TextFontButton";
            this.TextFontButton.Size = new System.Drawing.Size(141, 34);
            this.TextFontButton.TabIndex = 20;
            this.TextFontButton.Text = "Font";
            this.TextFontButton.UseVisualStyleBackColor = true;
            this.TextFontButton.Click += new System.EventHandler(this.TextFontButton_Click);
            // 
            // TextColorButton
            // 
            this.TextColorButton.Location = new System.Drawing.Point(34, 89);
            this.TextColorButton.Name = "TextColorButton";
            this.TextColorButton.Size = new System.Drawing.Size(141, 34);
            this.TextColorButton.TabIndex = 19;
            this.TextColorButton.Text = "Color";
            this.TextColorButton.UseVisualStyleBackColor = true;
            this.TextColorButton.Click += new System.EventHandler(this.TextColorButton_Click);
            // 
            // BackColorButton
            // 
            this.BackColorButton.Location = new System.Drawing.Point(34, 53);
            this.BackColorButton.Name = "BackColorButton";
            this.BackColorButton.Size = new System.Drawing.Size(141, 34);
            this.BackColorButton.TabIndex = 18;
            this.BackColorButton.Text = "Back Color";
            this.BackColorButton.UseVisualStyleBackColor = true;
            this.BackColorButton.Click += new System.EventHandler(this.BackColorButton_Click);
            // 
            // preferencesOkButton
            // 
            this.preferencesOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.preferencesOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.hpHelp.SetHelpString(this.preferencesOkButton, "Save the current values");
            this.preferencesOkButton.Location = new System.Drawing.Point(340, 329);
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
            this.preferencesApplyButton.Location = new System.Drawing.Point(447, 329);
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
            this.preferencesCancelButton.Location = new System.Drawing.Point(553, 329);
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
            // preferencesFontDialog
            // 
            this.preferencesFontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // documentTitleActualLabel
            // 
            this.documentTitleActualLabel.AutoSize = true;
            this.documentTitleActualLabel.Location = new System.Drawing.Point(245, 53);
            this.documentTitleActualLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.documentTitleActualLabel.Name = "documentTitleActualLabel";
            this.documentTitleActualLabel.Size = new System.Drawing.Size(103, 17);
            this.documentTitleActualLabel.TabIndex = 29;
            this.documentTitleActualLabel.Text = "Document Title";
            // 
            // DocumentTitleLabel
            // 
            this.DocumentTitleLabel.AutoSize = true;
            this.DocumentTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentTitleLabel.Location = new System.Drawing.Point(235, 15);
            this.DocumentTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DocumentTitleLabel.Name = "DocumentTitleLabel";
            this.DocumentTitleLabel.Size = new System.Drawing.Size(157, 25);
            this.DocumentTitleLabel.TabIndex = 30;
            this.DocumentTitleLabel.Text = "Document Title";
            // 
            // TextTitleLabel
            // 
            this.TextTitleLabel.AutoSize = true;
            this.TextTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTitleLabel.Location = new System.Drawing.Point(29, 15);
            this.TextTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextTitleLabel.Name = "TextTitleLabel";
            this.TextTitleLabel.Size = new System.Drawing.Size(55, 25);
            this.TextTitleLabel.TabIndex = 31;
            this.TextTitleLabel.Text = "Text";
            // 
            // PreferencesDialog
            // 
            this.AcceptButton = this.preferencesOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.preferencesCancelButton;
            this.ClientSize = new System.Drawing.Size(664, 370);
            this.Controls.Add(this.preferencesCancelButton);
            this.Controls.Add(this.preferencesApplyButton);
            this.Controls.Add(this.preferencesPanel);
            this.Controls.Add(this.preferencesOkButton);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(682, 417);
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
        private System.Windows.Forms.TextBox DocumentTitleTextBox;
        private System.Windows.Forms.TextBox DocumentSizeHeightTextBox;
        private System.Windows.Forms.TextBox DocumentSizeWidthTextBox;
        private System.Windows.Forms.Label preferencesDocumentLocationLabel;
        private System.Windows.Forms.Label preferencesDocumentTitleLabel;
    
        private System.Windows.Forms.Panel preferencesPanel;
        private System.Windows.Forms.Button preferencesOkButton;
        private System.Windows.Forms.Button preferencesApplyButton;
        private System.Windows.Forms.Button preferencesCancelButton;
        private System.Windows.Forms.ErrorProvider preferencesErrorProvider;
        private System.Windows.Forms.HelpProvider hpHelp;
        private System.Windows.Forms.ToolTip ttToolTip;
        private System.Windows.Forms.Button TextFontButton;
        private System.Windows.Forms.Button TextColorButton;
        private System.Windows.Forms.Button BackColorButton;
        private System.Windows.Forms.Label preferencesHeightLabel;
        private System.Windows.Forms.Label preferencesWidthLabel;
        private System.Windows.Forms.TextBox DocumentLocationYTextBox;
        private System.Windows.Forms.TextBox DocumentLocationXTextBox;
        private System.Windows.Forms.Label preferencesYLabel;
        private System.Windows.Forms.Label preferencesXLabel;
        private System.Windows.Forms.FontDialog preferencesFontDialog;
        private System.Windows.Forms.ColorDialog preferencesBackColorDialog;
        private System.Windows.Forms.ColorDialog preferencesTextColorDialog;
        private System.Windows.Forms.Label TextTitleLabel;
        private System.Windows.Forms.Label DocumentTitleLabel;
        private System.Windows.Forms.Label documentTitleActualLabel;
    }
}