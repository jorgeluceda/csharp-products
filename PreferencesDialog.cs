
using System.Windows.Forms;
using System.Drawing;
using System;

namespace Preferences
{
    public class PreferencesDialog : Form
    {
        //public Color BackColor { get; set; }
        //public Font Font { get; set; }
        public Color TextColor { get; set; }
        public Size DocumentSize { get; set; }
        public Point DocumentLocation { get; set; }
        public string DocumentTitle { get; set; }

        public event EventHandler Apply;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.hpHelp = new System.Windows.Forms.HelpProvider();
            this.ttToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.preferencesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preferencesErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // preferencesWidthTextBox
            // 
            this.hpHelp.SetHelpString(this.preferencesWidthTextBox, "Width of the child windows. Enter an integer [10 - 700]");
            this.preferencesWidthTextBox.Location = new System.Drawing.Point(64, 16);
            this.preferencesWidthTextBox.Name = "preferencesWidthTextBox";
            this.hpHelp.SetShowHelp(this.preferencesWidthTextBox, true);
            this.preferencesWidthTextBox.Size = new System.Drawing.Size(100, 22);
            this.preferencesWidthTextBox.TabIndex = 3;
            this.ttToolTip.SetToolTip(this.preferencesWidthTextBox, "Width of the child windows. Enter an integer [10 - 700]");
            // 
            // preferencesHeightTextBox
            // 
            this.hpHelp.SetHelpString(this.preferencesHeightTextBox, "Height of the child windows. Enter an integer [10 - 700]");
            this.preferencesHeightTextBox.Location = new System.Drawing.Point(64, 42);
            this.preferencesHeightTextBox.Name = "preferencesHeightTextBox";
            this.hpHelp.SetShowHelp(this.preferencesHeightTextBox, true);
            this.preferencesHeightTextBox.Size = new System.Drawing.Size(100, 22);
            this.preferencesHeightTextBox.TabIndex = 4;
            this.ttToolTip.SetToolTip(this.preferencesHeightTextBox, "Height of the child windows. Enter an integer [10 - 700]");
            // 
            // preferencesRatioTextBox
            // 
            this.hpHelp.SetHelpString(this.preferencesRatioTextBox, "Ratio between the width and height of the child windows. Enter a float [0.1 - 100" +
        "]");
            this.preferencesRatioTextBox.Location = new System.Drawing.Point(64, 68);
            this.preferencesRatioTextBox.Name = "preferencesRatioTextBox";
            this.hpHelp.SetShowHelp(this.preferencesRatioTextBox, true);
            this.preferencesRatioTextBox.Size = new System.Drawing.Size(100, 22);
            this.preferencesRatioTextBox.TabIndex = 5;
            this.ttToolTip.SetToolTip(this.preferencesRatioTextBox, "Ratio between the width and height of the child windows. Enter a float [0.1 - 100" +
        "]");
            // 
            // preferencesWidthLabel
            // 
            this.preferencesWidthLabel.AutoSize = true;
            this.preferencesWidthLabel.Location = new System.Drawing.Point(5, 19);
            this.preferencesWidthLabel.Name = "preferencesWidthLabel";
            this.preferencesWidthLabel.Size = new System.Drawing.Size(44, 17);
            this.preferencesWidthLabel.TabIndex = 9;
            this.preferencesWidthLabel.Text = "Width";
            // 
            // preferencesHeightLabel
            // 
            this.preferencesHeightLabel.AutoSize = true;
            this.preferencesHeightLabel.Location = new System.Drawing.Point(5, 45);
            this.preferencesHeightLabel.Name = "preferencesHeightLabel";
            this.preferencesHeightLabel.Size = new System.Drawing.Size(49, 17);
            this.preferencesHeightLabel.TabIndex = 10;
            this.preferencesHeightLabel.Text = "Height";
            // 
            // preferencesRatioLabel
            // 
            this.preferencesRatioLabel.AutoSize = true;
            this.preferencesRatioLabel.Location = new System.Drawing.Point(6, 70);
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
            this.preferencesPanel.Location = new System.Drawing.Point(103, 77);
            this.preferencesPanel.Name = "preferencesPanel";
            this.preferencesPanel.Size = new System.Drawing.Size(190, 102);
            this.preferencesPanel.TabIndex = 12;
            // 
            // preferencesOkButton
            // 
            this.preferencesOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.preferencesOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.hpHelp.SetHelpString(this.preferencesOkButton, "Save the current values");
            this.preferencesOkButton.Location = new System.Drawing.Point(155, 207);
            this.preferencesOkButton.Name = "preferencesOkButton";
            this.hpHelp.SetShowHelp(this.preferencesOkButton, true);
            this.preferencesOkButton.Size = new System.Drawing.Size(75, 23);
            this.preferencesOkButton.TabIndex = 8;
            this.preferencesOkButton.Text = "Ok";
            this.preferencesOkButton.UseVisualStyleBackColor = true;
            // 
            // preferencesApplyButton
            // 
            this.preferencesApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hpHelp.SetHelpString(this.preferencesApplyButton, "Apply the current values");
            this.preferencesApplyButton.Location = new System.Drawing.Point(235, 207);
            this.preferencesApplyButton.Name = "preferencesApplyButton";
            this.hpHelp.SetShowHelp(this.preferencesApplyButton, true);
            this.preferencesApplyButton.Size = new System.Drawing.Size(75, 22);
            this.preferencesApplyButton.TabIndex = 7;
            this.preferencesApplyButton.Text = "Apply";
            this.preferencesApplyButton.UseVisualStyleBackColor = true;
            // 
            // preferencesCancelButton
            // 
            this.preferencesCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.preferencesCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.hpHelp.SetHelpString(this.preferencesCancelButton, "Cancel edition of current values");
            this.preferencesCancelButton.Location = new System.Drawing.Point(314, 207);
            this.preferencesCancelButton.Name = "preferencesCancelButton";
            this.hpHelp.SetShowHelp(this.preferencesCancelButton, true);
            this.preferencesCancelButton.Size = new System.Drawing.Size(75, 22);
            this.preferencesCancelButton.TabIndex = 6;
            this.preferencesCancelButton.Text = "Cancel";
            this.preferencesCancelButton.UseVisualStyleBackColor = true;
            // 
            // preferencesErrorProvider
            // 
            this.preferencesErrorProvider.ContainerControl = this;
            // 
            // PreferencesDialog
            // 
            this.AcceptButton = this.preferencesOkButton;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.preferencesCancelButton;
            this.ClientSize = new System.Drawing.Size(399, 300);
            this.Controls.Add(this.preferencesCancelButton);
            this.Controls.Add(this.preferencesApplyButton);
            this.Controls.Add(this.preferencesPanel);
            this.Controls.Add(this.preferencesOkButton);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(415, 339);
            this.Name = "PreferencesDialog";
            this.Text = "Preferences Dialog";
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