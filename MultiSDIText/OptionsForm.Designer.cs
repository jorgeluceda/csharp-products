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
            System.Windows.Forms.Label locationLabel;
            this.zOrderTextBox = new System.Windows.Forms.TextBox();
            this.bsText = new System.Windows.Forms.BindingSource(this.components);
            this.rotationTextBox = new System.Windows.Forms.TextBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.backgroundColorButton = new System.Windows.Forms.Button();
            this.textColorDialog = new System.Windows.Forms.ColorDialog();
            this.backgroundColorButtonDialog = new System.Windows.Forms.ColorDialog();
            this.fontButton = new System.Windows.Forms.Button();
            this.textFontDialog = new System.Windows.Forms.FontDialog();
            this.preferencesPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bsDocument = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxDisplayMember = new System.Windows.Forms.GroupBox();
            this.radioButtonLocation = new System.Windows.Forms.RadioButton();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonDefault = new System.Windows.Forms.RadioButton();
            this.listBoxDoc = new System.Windows.Forms.ListBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelOf = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            zOrderLabel = new System.Windows.Forms.Label();
            rotationLabel = new System.Windows.Forms.Label();
            contentLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsText)).BeginInit();
            this.preferencesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBoxDisplayMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // zOrderLabel
            // 
            zOrderLabel.AutoSize = true;
            zOrderLabel.Location = new System.Drawing.Point(109, 119);
            zOrderLabel.Name = "zOrderLabel";
            zOrderLabel.Size = new System.Drawing.Size(85, 25);
            zOrderLabel.TabIndex = 0;
            zOrderLabel.Text = "ZOrder:";
            // 
            // rotationLabel
            // 
            rotationLabel.AutoSize = true;
            rotationLabel.Location = new System.Drawing.Point(582, 119);
            rotationLabel.Name = "rotationLabel";
            rotationLabel.Size = new System.Drawing.Size(98, 25);
            rotationLabel.TabIndex = 2;
            rotationLabel.Text = "Rotation:";
            // 
            // contentLabel
            // 
            contentLabel.AutoSize = true;
            contentLabel.Location = new System.Drawing.Point(101, 43);
            contentLabel.Name = "contentLabel";
            contentLabel.Size = new System.Drawing.Size(93, 25);
            contentLabel.TabIndex = 4;
            contentLabel.Text = "Content:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(333, 119);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(100, 25);
            locationLabel.TabIndex = 6;
            locationLabel.Text = "Location:";
            // 
            // zOrderTextBox
            // 
            this.zOrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsText, "ZOrder", true));
            this.zOrderTextBox.Location = new System.Drawing.Point(200, 116);
            this.zOrderTextBox.Name = "zOrderTextBox";
            this.zOrderTextBox.Size = new System.Drawing.Size(103, 31);
            this.zOrderTextBox.TabIndex = 1;
            // 
            // bsText
            // 
            this.bsText.DataSource = typeof(MultiSDIText.Storage.Text);
            // 
            // rotationTextBox
            // 
            this.rotationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsText, "Rotation", true));
            this.rotationTextBox.Location = new System.Drawing.Point(686, 116);
            this.rotationTextBox.Name = "rotationTextBox";
            this.rotationTextBox.Size = new System.Drawing.Size(84, 31);
            this.rotationTextBox.TabIndex = 3;
            // 
            // contentTextBox
            // 
            this.contentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsText, "Content", true));
            this.contentTextBox.Location = new System.Drawing.Point(200, 40);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(570, 31);
            this.contentTextBox.TabIndex = 5;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsText, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(439, 116);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(123, 31);
            this.locationTextBox.TabIndex = 7;
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(587, 205);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(189, 68);
            this.colorButton.TabIndex = 10;
            this.colorButton.Text = "Text Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.Location = new System.Drawing.Point(106, 205);
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(189, 68);
            this.backgroundColorButton.TabIndex = 11;
            this.backgroundColorButton.Text = "Background Color";
            this.backgroundColorButton.UseVisualStyleBackColor = true;
            this.backgroundColorButton.Click += new System.EventHandler(this.backgroundColorButton_Click);
            // 
            // fontButton
            // 
            this.fontButton.Location = new System.Drawing.Point(327, 205);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(235, 68);
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
            this.preferencesPanel.Controls.Add(this.fontButton);
            this.preferencesPanel.Controls.Add(this.contentTextBox);
            this.preferencesPanel.Controls.Add(rotationLabel);
            this.preferencesPanel.Controls.Add(this.rotationTextBox);
            this.preferencesPanel.Controls.Add(zOrderLabel);
            this.preferencesPanel.Controls.Add(locationLabel);
            this.preferencesPanel.Controls.Add(this.zOrderTextBox);
            this.preferencesPanel.Controls.Add(this.backgroundColorButton);
            this.preferencesPanel.Controls.Add(this.locationTextBox);
            this.preferencesPanel.Location = new System.Drawing.Point(445, 161);
            this.preferencesPanel.Margin = new System.Windows.Forms.Padding(6);
            this.preferencesPanel.MinimumSize = new System.Drawing.Size(856, 208);
            this.preferencesPanel.Name = "preferencesPanel";
            this.preferencesPanel.Padding = new System.Windows.Forms.Padding(6);
            this.preferencesPanel.Size = new System.Drawing.Size(856, 321);
            this.preferencesPanel.TabIndex = 13;
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okButton.Location = new System.Drawing.Point(1151, 508);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(150, 47);
            this.okButton.TabIndex = 16;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // bsDocument
            // 
            this.bsDocument.DataSource = typeof(MultiSDIText.Storage.Document);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(MultiSDIText.Storage.Document);
            // 
            // groupBoxDisplayMember
            // 
            this.groupBoxDisplayMember.Controls.Add(this.radioButtonLocation);
            this.groupBoxDisplayMember.Controls.Add(this.radioButtonName);
            this.groupBoxDisplayMember.Controls.Add(this.radioButtonDefault);
            this.groupBoxDisplayMember.Location = new System.Drawing.Point(553, 585);
            this.groupBoxDisplayMember.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxDisplayMember.Name = "groupBoxDisplayMember";
            this.groupBoxDisplayMember.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxDisplayMember.Size = new System.Drawing.Size(222, 271);
            this.groupBoxDisplayMember.TabIndex = 46;
            this.groupBoxDisplayMember.TabStop = false;
            this.groupBoxDisplayMember.Text = "Display Member";
            // 
            // radioButtonLocation
            // 
            this.radioButtonLocation.AutoSize = true;
            this.radioButtonLocation.Location = new System.Drawing.Point(12, 119);
            this.radioButtonLocation.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonLocation.Name = "radioButtonLocation";
            this.radioButtonLocation.Size = new System.Drawing.Size(125, 29);
            this.radioButtonLocation.TabIndex = 2;
            this.radioButtonLocation.TabStop = true;
            this.radioButtonLocation.Text = "Location";
            this.radioButtonLocation.UseVisualStyleBackColor = false;
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(12, 75);
            this.radioButtonName.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(99, 29);
            this.radioButtonName.TabIndex = 1;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "Name";
            this.radioButtonName.UseVisualStyleBackColor = true;
            // 
            // radioButtonDefault
            // 
            this.radioButtonDefault.AutoSize = true;
            this.radioButtonDefault.Location = new System.Drawing.Point(12, 31);
            this.radioButtonDefault.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonDefault.Name = "radioButtonDefault";
            this.radioButtonDefault.Size = new System.Drawing.Size(111, 29);
            this.radioButtonDefault.TabIndex = 0;
            this.radioButtonDefault.TabStop = true;
            this.radioButtonDefault.Text = "Default";
            this.radioButtonDefault.UseVisualStyleBackColor = true;
            // 
            // listBoxDoc
            // 
            this.listBoxDoc.FormattingEnabled = true;
            this.listBoxDoc.ItemHeight = 25;
            this.listBoxDoc.Location = new System.Drawing.Point(79, 579);
            this.listBoxDoc.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxDoc.Name = "listBoxDoc";
            this.listBoxDoc.Size = new System.Drawing.Size(458, 179);
            this.listBoxDoc.TabIndex = 45;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(253, 521);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(47, 25);
            this.labelPosition.TabIndex = 44;
            this.labelPosition.Text = "pos";
            // 
            // labelOf
            // 
            this.labelOf.AutoSize = true;
            this.labelOf.Location = new System.Drawing.Point(301, 521);
            this.labelOf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelOf.Name = "labelOf";
            this.labelOf.Size = new System.Drawing.Size(30, 25);
            this.labelOf.TabIndex = 43;
            this.labelOf.Text = "of";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(335, 521);
            this.labelCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(41, 25);
            this.labelCount.TabIndex = 42;
            this.labelCount.Text = "cnt";
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(481, 512);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(6);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(60, 44);
            this.buttonLast.TabIndex = 41;
            this.buttonLast.Text = ">|";
            this.buttonLast.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(391, 512);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(6);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(64, 44);
            this.buttonNext.TabIndex = 40;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(179, 512);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(6);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(62, 44);
            this.buttonPrev.TabIndex = 39;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            // 
            // buttonFirst
            // 
            this.buttonFirst.AutoSize = true;
            this.buttonFirst.Location = new System.Drawing.Point(79, 512);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(6);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(66, 44);
            this.buttonFirst.TabIndex = 38;
            this.buttonFirst.Text = "|<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1760, 847);
            this.Controls.Add(this.groupBoxDisplayMember);
            this.Controls.Add(this.listBoxDoc);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelOf);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.preferencesPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(963, 497);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            ((System.ComponentModel.ISupportInitialize)(this.bsText)).EndInit();
            this.preferencesPanel.ResumeLayout(false);
            this.preferencesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBoxDisplayMember.ResumeLayout(false);
            this.groupBoxDisplayMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.BindingSource bsText;
        public System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TextBox zOrderTextBox;
        private System.Windows.Forms.TextBox rotationTextBox;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button backgroundColorButton;
        private System.Windows.Forms.ColorDialog textColorDialog;
        private System.Windows.Forms.ColorDialog backgroundColorButtonDialog;
        private System.Windows.Forms.Button fontButton;
        private System.Windows.Forms.FontDialog textFontDialog;
        private System.Windows.Forms.Panel preferencesPanel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.BindingSource bsDocument;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBoxDisplayMember;
        private System.Windows.Forms.RadioButton radioButtonLocation;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonDefault;
        public System.Windows.Forms.ListBox listBoxDoc;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelOf;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonFirst;
    }
}