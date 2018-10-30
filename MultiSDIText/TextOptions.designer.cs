namespace MultiSDIText
{
    partial class TextOptions
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
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelOf = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelContent = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.bsDocument = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.listBoxDoc = new System.Windows.Forms.ListBox();
            this.groupBoxDisplayMember = new System.Windows.Forms.GroupBox();
            this.radioButtonLocation = new System.Windows.Forms.RadioButton();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonDefault = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.locationLabel = new System.Windows.Forms.Label();
            this.textColorButton = new System.Windows.Forms.Button();
            this.backgroundColorButton = new System.Windows.Forms.Button();
            this.textFontButton = new System.Windows.Forms.Button();
            this.OkOptionsButton = new System.Windows.Forms.Button();
            this.cancelOptionsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).BeginInit();
            this.groupBoxDisplayMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(232, 42);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(47, 25);
            this.labelPosition.TabIndex = 31;
            this.labelPosition.Text = "pos";
            // 
            // labelOf
            // 
            this.labelOf.AutoSize = true;
            this.labelOf.Location = new System.Drawing.Point(280, 42);
            this.labelOf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelOf.Name = "labelOf";
            this.labelOf.Size = new System.Drawing.Size(30, 25);
            this.labelOf.TabIndex = 30;
            this.labelOf.Text = "of";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(314, 42);
            this.labelCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(41, 25);
            this.labelCount.TabIndex = 29;
            this.labelCount.Text = "cnt";
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(460, 33);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(6);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(60, 44);
            this.buttonLast.TabIndex = 28;
            this.buttonLast.Text = ">|";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(370, 33);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(6);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(64, 44);
            this.buttonNext.TabIndex = 27;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(158, 33);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(6);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(62, 44);
            this.buttonPrev.TabIndex = 26;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.AutoSize = true;
            this.buttonFirst.Location = new System.Drawing.Point(58, 33);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(6);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(66, 44);
            this.buttonFirst.TabIndex = 25;
            this.buttonFirst.Text = "|<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(56, 349);
            this.labelLocation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(94, 25);
            this.labelLocation.TabIndex = 35;
            this.labelLocation.Text = "Location";
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Location = new System.Drawing.Point(61, 302);
            this.labelContent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(87, 25);
            this.labelContent.TabIndex = 34;
            this.labelContent.Text = "Content";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDocument, "Location", true));
            this.textBoxLocation.Location = new System.Drawing.Point(162, 346);
            this.textBoxLocation.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(354, 31);
            this.textBoxLocation.TabIndex = 33;
            // 
            // textBoxContent
            // 
            this.textBoxContent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDocument, "Content", true));
            this.textBoxContent.Location = new System.Drawing.Point(162, 299);
            this.textBoxContent.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(354, 31);
            this.textBoxContent.TabIndex = 32;
            // 
            // listBoxDoc
            // 
            this.listBoxDoc.DataSource = this.bsDocument;
            this.listBoxDoc.FormattingEnabled = true;
            this.listBoxDoc.ItemHeight = 25;
            this.listBoxDoc.Location = new System.Drawing.Point(58, 100);
            this.listBoxDoc.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxDoc.Name = "listBoxDoc";
            this.listBoxDoc.Size = new System.Drawing.Size(458, 179);
            this.listBoxDoc.TabIndex = 36;
            // 
            // groupBoxDisplayMember
            // 
            this.groupBoxDisplayMember.Controls.Add(this.radioButtonLocation);
            this.groupBoxDisplayMember.Controls.Add(this.radioButtonName);
            this.groupBoxDisplayMember.Controls.Add(this.radioButtonDefault);
            this.groupBoxDisplayMember.Location = new System.Drawing.Point(532, 106);
            this.groupBoxDisplayMember.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxDisplayMember.Name = "groupBoxDisplayMember";
            this.groupBoxDisplayMember.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxDisplayMember.Size = new System.Drawing.Size(222, 271);
            this.groupBoxDisplayMember.TabIndex = 37;
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
            this.radioButtonLocation.CheckedChanged += new System.EventHandler(this.radioButtonZOrder_CheckedChanged);
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
            this.radioButtonName.CheckedChanged += new System.EventHandler(this.radioButtonName_CheckedChanged);
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
            this.radioButtonDefault.CheckedChanged += new System.EventHandler(this.radioButtonDefault_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 492);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 44);
            this.button1.TabIndex = 38;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 492);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 44);
            this.button2.TabIndex = 39;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(66, 492);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 44);
            this.button3.TabIndex = 40;
            this.button3.Text = "|<";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(294, 492);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 44);
            this.button4.TabIndex = 41;
            this.button4.Text = ">|";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(167, 446);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(86, 25);
            this.locationLabel.TabIndex = 42;
            this.locationLabel.Text = "Z-Order";
            // 
            // textColorButton
            // 
            this.textColorButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", this.bsDocument, "Color", true));
            this.textColorButton.Location = new System.Drawing.Point(405, 423);
            this.textColorButton.Name = "textColorButton";
            this.textColorButton.Size = new System.Drawing.Size(155, 71);
            this.textColorButton.TabIndex = 43;
            this.textColorButton.Text = "Text Color";
            this.textColorButton.UseVisualStyleBackColor = true;
            this.textColorButton.Click += new System.EventHandler(this.textColorButton_Click);
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", this.bsDocument, "BackgroundColor", true));
            this.backgroundColorButton.Location = new System.Drawing.Point(599, 423);
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(155, 71);
            this.backgroundColorButton.TabIndex = 44;
            this.backgroundColorButton.Text = "Background Color";
            this.backgroundColorButton.UseVisualStyleBackColor = true;
            this.backgroundColorButton.Click += new System.EventHandler(this.backgroundColorButton_Click);
            // 
            // textFontButton
            // 
            this.textFontButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", this.bsDocument, "Font", true));
            this.textFontButton.Location = new System.Drawing.Point(506, 516);
            this.textFontButton.Name = "textFontButton";
            this.textFontButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textFontButton.Size = new System.Drawing.Size(155, 71);
            this.textFontButton.TabIndex = 45;
            this.textFontButton.Text = "Text Font";
            this.textFontButton.UseVisualStyleBackColor = true;
            this.textFontButton.Click += new System.EventHandler(this.textFontButton_Click);
            // 
            // OkOptionsButton
            // 
            this.OkOptionsButton.Location = new System.Drawing.Point(460, 641);
            this.OkOptionsButton.Name = "OkOptionsButton";
            this.OkOptionsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OkOptionsButton.Size = new System.Drawing.Size(155, 71);
            this.OkOptionsButton.TabIndex = 46;
            this.OkOptionsButton.Text = "Apply";
            this.OkOptionsButton.UseVisualStyleBackColor = true;
            this.OkOptionsButton.Click += new System.EventHandler(this.OkOptionsButton_Click);
            // 
            // cancelOptionsButton
            // 
            this.cancelOptionsButton.Location = new System.Drawing.Point(661, 641);
            this.cancelOptionsButton.Name = "cancelOptionsButton";
            this.cancelOptionsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cancelOptionsButton.Size = new System.Drawing.Size(155, 71);
            this.cancelOptionsButton.TabIndex = 47;
            this.cancelOptionsButton.Text = "Cancel";
            this.cancelOptionsButton.UseVisualStyleBackColor = true;
            // 
            // TextOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 747);
            this.Controls.Add(this.cancelOptionsButton);
            this.Controls.Add(this.OkOptionsButton);
            this.Controls.Add(this.textFontButton);
            this.Controls.Add(this.backgroundColorButton);
            this.Controls.Add(this.textColorButton);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxDisplayMember);
            this.Controls.Add(this.listBoxDoc);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelOf);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonFirst);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TextOptions";
            this.Text = "Text Options";
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).EndInit();
            this.groupBoxDisplayMember.ResumeLayout(false);
            this.groupBoxDisplayMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelOf;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.ListBox listBoxDoc;
        private System.Windows.Forms.GroupBox groupBoxDisplayMember;
        private System.Windows.Forms.RadioButton radioButtonLocation;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonDefault;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource bsDocument;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Button textColorButton;
        private System.Windows.Forms.Button backgroundColorButton;
        private System.Windows.Forms.Button textFontButton;
        private System.Windows.Forms.Button OkOptionsButton;
        private System.Windows.Forms.Button cancelOptionsButton;
        //private System.Collections.Generic.List<Storage.Text> textDoc = new System.Collections.Generic.List<Storage.Text>();


    }
}