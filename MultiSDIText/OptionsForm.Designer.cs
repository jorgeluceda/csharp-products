using System;

namespace MultiSDIText
{
    partial class OptionsForm
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
            System.Windows.Forms.Label zOrderLabel;
            System.Windows.Forms.Label rotationLabel;
            System.Windows.Forms.Label contentLabel;
            System.Windows.Forms.Label xLabel;
            System.Windows.Forms.Label yLabel;
            this.zOrderTextBox = new System.Windows.Forms.TextBox();
            this.rotationTextBox = new System.Windows.Forms.TextBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.backgroundColorButton = new System.Windows.Forms.Button();
            this.textColorDialog = new System.Windows.Forms.ColorDialog();
            this.backgroundColorButtonDialog = new System.Windows.Forms.ColorDialog();
            this.fontButton = new System.Windows.Forms.Button();
            this.textFontDialog = new System.Windows.Forms.FontDialog();
            this.preferencesPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.bsText = new System.Windows.Forms.BindingSource(this.components);
            zOrderLabel = new System.Windows.Forms.Label();
            rotationLabel = new System.Windows.Forms.Label();
            contentLabel = new System.Windows.Forms.Label();
            xLabel = new System.Windows.Forms.Label();
            yLabel = new System.Windows.Forms.Label();
            this.preferencesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsText)).BeginInit();
            this.SuspendLayout();
            // 
            // zOrderLabel
            // 
            zOrderLabel.AutoSize = true;
            zOrderLabel.Location = new System.Drawing.Point(23, 90);
            zOrderLabel.Name = "zOrderLabel";
            zOrderLabel.Size = new System.Drawing.Size(85, 25);
            zOrderLabel.TabIndex = 0;
            zOrderLabel.Text = "ZOrder:";
            // 
            // rotationLabel
            // 
            rotationLabel.AutoSize = true;
            rotationLabel.Location = new System.Drawing.Point(10, 136);
            rotationLabel.Name = "rotationLabel";
            rotationLabel.Size = new System.Drawing.Size(98, 25);
            rotationLabel.TabIndex = 2;
            rotationLabel.Text = "Rotation:";
            // 
            // contentLabel
            // 
            contentLabel.AutoSize = true;
            contentLabel.Location = new System.Drawing.Point(15, 43);
            contentLabel.Name = "contentLabel";
            contentLabel.Size = new System.Drawing.Size(93, 25);
            contentLabel.TabIndex = 4;
            contentLabel.Text = "Content:";
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Location = new System.Drawing.Point(618, 62);
            xLabel.Name = "xLabel";
            xLabel.Size = new System.Drawing.Size(120, 25);
            xLabel.TabIndex = 6;
            xLabel.Text = "Location X:";
            xLabel.Click += new System.EventHandler(this.xLabel_Click);
            // 
            // yLabel
            // 
            yLabel.AutoSize = true;
            yLabel.Location = new System.Drawing.Point(617, 106);
            yLabel.Name = "yLabel";
            yLabel.Size = new System.Drawing.Size(121, 25);
            yLabel.TabIndex = 8;
            yLabel.Text = "Location Y:";
            yLabel.Click += new System.EventHandler(this.yLabel_Click);
            // 
            // zOrderTextBox
            // 
            this.zOrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsText, "ZOrder", true));
            this.zOrderTextBox.Location = new System.Drawing.Point(114, 87);
            this.zOrderTextBox.Name = "zOrderTextBox";
            this.zOrderTextBox.Size = new System.Drawing.Size(100, 31);
            this.zOrderTextBox.TabIndex = 1;
            this.zOrderTextBox.TextChanged += new System.EventHandler(this.zOrderTextBox_TextChanged);
            // 
            // rotationTextBox
            // 
            this.rotationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsText, "Rotation", true));
            this.rotationTextBox.Location = new System.Drawing.Point(114, 133);
            this.rotationTextBox.Name = "rotationTextBox";
            this.rotationTextBox.Size = new System.Drawing.Size(100, 31);
            this.rotationTextBox.TabIndex = 3;
            // 
            // contentTextBox
            // 
            this.contentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsText, "Content", true));
            this.contentTextBox.Location = new System.Drawing.Point(114, 40);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(100, 31);
            this.contentTextBox.TabIndex = 5;
            // 
            // xTextBox
            // 
            this.xTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsText, "Location.X", true));
            this.xTextBox.Location = new System.Drawing.Point(738, 59);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 31);
            this.xTextBox.TabIndex = 7;
            this.xTextBox.TextChanged += new System.EventHandler(this.xTextBox_TextChanged);
            // 
            // yTextBox
            // 
            this.yTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsText, "Location.Y", true));
            this.yTextBox.Location = new System.Drawing.Point(738, 103);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(100, 31);
            this.yTextBox.TabIndex = 9;
            this.yTextBox.TextChanged += new System.EventHandler(this.yTextBox_TextChanged);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(227, 106);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(189, 68);
            this.colorButton.TabIndex = 10;
            this.colorButton.Text = "Text Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.Location = new System.Drawing.Point(422, 106);
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(189, 68);
            this.backgroundColorButton.TabIndex = 11;
            this.backgroundColorButton.Text = "Background Color";
            this.backgroundColorButton.UseVisualStyleBackColor = true;
            this.backgroundColorButton.Click += new System.EventHandler(this.backgroundColorButton_Click);
            // 
            // fontButton
            // 
            this.fontButton.Location = new System.Drawing.Point(322, 32);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(191, 68);
            this.fontButton.TabIndex = 12;
            this.fontButton.Text = "Font";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
            // 
            // preferencesPanel
            // 
            this.preferencesPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.preferencesPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.preferencesPanel.Controls.Add(this.colorButton);
            this.preferencesPanel.Controls.Add(contentLabel);
            this.preferencesPanel.Controls.Add(yLabel);
            this.preferencesPanel.Controls.Add(this.contentTextBox);
            this.preferencesPanel.Controls.Add(rotationLabel);
            this.preferencesPanel.Controls.Add(this.yTextBox);
            this.preferencesPanel.Controls.Add(this.rotationTextBox);
            this.preferencesPanel.Controls.Add(this.fontButton);
            this.preferencesPanel.Controls.Add(zOrderLabel);
            this.preferencesPanel.Controls.Add(xLabel);
            this.preferencesPanel.Controls.Add(this.zOrderTextBox);
            this.preferencesPanel.Controls.Add(this.backgroundColorButton);
            this.preferencesPanel.Controls.Add(this.xTextBox);
            this.preferencesPanel.Location = new System.Drawing.Point(33, 106);
            this.preferencesPanel.Margin = new System.Windows.Forms.Padding(6);
            this.preferencesPanel.MinimumSize = new System.Drawing.Size(856, 208);
            this.preferencesPanel.Name = "preferencesPanel";
            this.preferencesPanel.Padding = new System.Windows.Forms.Padding(6);
            this.preferencesPanel.Size = new System.Drawing.Size(856, 208);
            this.preferencesPanel.TabIndex = 13;
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okButton.Location = new System.Drawing.Point(739, 345);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(150, 47);
            this.okButton.TabIndex = 16;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // bsText
            // 
            this.bsText.DataSource = typeof(MultiSDIText.Storage.Text);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 426);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.preferencesPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(963, 497);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.preferencesPanel.ResumeLayout(false);
            this.preferencesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsText)).EndInit();
            this.ResumeLayout(false);

        }

        private void backgroundColorButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        public System.Windows.Forms.BindingSource bsText;
        public System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ErrorProvider shapeOptionsErrorProvider;
        private System.Windows.Forms.TextBox zOrderTextBox;
        private System.Windows.Forms.TextBox rotationTextBox;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button backgroundColorButton;
        private System.Windows.Forms.ColorDialog textColorDialog;
        private System.Windows.Forms.ColorDialog backgroundColorButtonDialog;
        private System.Windows.Forms.Button fontButton;
        private System.Windows.Forms.FontDialog textFontDialog;
        private System.Windows.Forms.Panel preferencesPanel;
        private System.Windows.Forms.Button okButton;
    }
}