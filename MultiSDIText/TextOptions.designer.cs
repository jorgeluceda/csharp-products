using System;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextOptions));
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
            this.radioButtonBackgroundColor = new System.Windows.Forms.RadioButton();
            this.radioButtonTextColor = new System.Windows.Forms.RadioButton();
            this.radioButtonTextFont = new System.Windows.Forms.RadioButton();
            this.radioButtonZOrder = new System.Windows.Forms.RadioButton();
            this.radioButtonLocation = new System.Windows.Forms.RadioButton();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.buttonSendToBack = new System.Windows.Forms.Button();
            this.buttonBringToFront = new System.Windows.Forms.Button();
            this.locationLabel = new System.Windows.Forms.Label();
            this.textColorButton = new System.Windows.Forms.Button();
            this.backgroundColorButton = new System.Windows.Forms.Button();
            this.textFontButton = new System.Windows.Forms.Button();
            this.OkOptionsButton = new System.Windows.Forms.Button();
            this.cancelOptionsButton = new System.Windows.Forms.Button();
            this.ZOrderTextBox = new System.Windows.Forms.TextBox();
            this.toToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.preferencesErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelRotation = new System.Windows.Forms.Label();
            this.rotationTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).BeginInit();
            this.groupBoxDisplayMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preferencesErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPosition
            // 
            this.labelPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPosition.AutoSize = true;
            this.labelPosition.BackColor = System.Drawing.Color.Transparent;
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(232, 42);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(50, 25);
            this.labelPosition.TabIndex = 31;
            this.labelPosition.Text = "pos";
            // 
            // labelOf
            // 
            this.labelOf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOf.AutoSize = true;
            this.labelOf.BackColor = System.Drawing.Color.Transparent;
            this.labelOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOf.Location = new System.Drawing.Point(280, 42);
            this.labelOf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelOf.Name = "labelOf";
            this.labelOf.Size = new System.Drawing.Size(32, 25);
            this.labelOf.TabIndex = 30;
            this.labelOf.Text = "of";
            // 
            // labelCount
            // 
            this.labelCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.Color.Transparent;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(314, 42);
            this.labelCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(44, 25);
            this.labelCount.TabIndex = 29;
            this.labelCount.Text = "cnt";
            // 
            // buttonLast
            // 
            this.buttonLast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLast.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonLast.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.buttonLast.Location = new System.Drawing.Point(460, 33);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(60, 44);
            this.buttonLast.TabIndex = 28;
            this.buttonLast.Text = ">|";
            this.toToolTip.SetToolTip(this.buttonLast, "Go to last member");
            this.buttonLast.UseVisualStyleBackColor = false;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonNext.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.buttonNext.Location = new System.Drawing.Point(370, 33);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(64, 44);
            this.buttonNext.TabIndex = 27;
            this.buttonNext.Text = ">";
            this.toToolTip.SetToolTip(this.buttonNext, "Go to next member");
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrev.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonPrev.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.buttonPrev.Location = new System.Drawing.Point(158, 33);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(62, 44);
            this.buttonPrev.TabIndex = 26;
            this.buttonPrev.Text = "<";
            this.toToolTip.SetToolTip(this.buttonPrev, "Go to previous member");
            this.buttonPrev.UseVisualStyleBackColor = false;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFirst.AutoSize = true;
            this.buttonFirst.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonFirst.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.buttonFirst.Location = new System.Drawing.Point(58, 33);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(66, 44);
            this.buttonFirst.TabIndex = 25;
            this.buttonFirst.Text = "|<";
            this.toToolTip.SetToolTip(this.buttonFirst, "Go to first member");
            this.buttonFirst.UseVisualStyleBackColor = false;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // labelLocation
            // 
            this.labelLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLocation.AutoSize = true;
            this.labelLocation.BackColor = System.Drawing.Color.Transparent;
            this.labelLocation.Location = new System.Drawing.Point(56, 348);
            this.labelLocation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(94, 25);
            this.labelLocation.TabIndex = 35;
            this.labelLocation.Text = "Location";
            // 
            // labelContent
            // 
            this.labelContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelContent.AutoSize = true;
            this.labelContent.BackColor = System.Drawing.Color.Transparent;
            this.labelContent.Location = new System.Drawing.Point(62, 302);
            this.labelContent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(87, 25);
            this.labelContent.TabIndex = 34;
            this.labelContent.Text = "Content";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLocation.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBoxLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDocument, "Location", true));
            this.textBoxLocation.Location = new System.Drawing.Point(162, 345);
            this.textBoxLocation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(272, 31);
            this.textBoxLocation.TabIndex = 33;
            this.toToolTip.SetToolTip(this.textBoxLocation, "Location of member that can be changed");
            this.textBoxLocation.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLocation_Validating);
            // 
            // textBoxContent
            // 
            this.textBoxContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxContent.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBoxContent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDocument, "Content", true));
            this.textBoxContent.Location = new System.Drawing.Point(162, 298);
            this.textBoxContent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(272, 31);
            this.textBoxContent.TabIndex = 32;
            this.toToolTip.SetToolTip(this.textBoxContent, "Text content of the member that can be eddited");
            // 
            // listBoxDoc
            // 
            this.listBoxDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxDoc.BackColor = System.Drawing.Color.PaleTurquoise;
            this.listBoxDoc.DataSource = this.bsDocument;
            this.listBoxDoc.FormattingEnabled = true;
            this.listBoxDoc.ItemHeight = 25;
            this.listBoxDoc.Location = new System.Drawing.Point(58, 100);
            this.listBoxDoc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxDoc.Name = "listBoxDoc";
            this.listBoxDoc.Size = new System.Drawing.Size(458, 179);
            this.listBoxDoc.TabIndex = 36;
            this.toToolTip.SetToolTip(this.listBoxDoc, "Member\'s of the Document");
            // 
            // groupBoxDisplayMember
            // 
            this.groupBoxDisplayMember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDisplayMember.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBoxDisplayMember.Controls.Add(this.radioButtonBackgroundColor);
            this.groupBoxDisplayMember.Controls.Add(this.radioButtonTextColor);
            this.groupBoxDisplayMember.Controls.Add(this.radioButtonTextFont);
            this.groupBoxDisplayMember.Controls.Add(this.radioButtonZOrder);
            this.groupBoxDisplayMember.Controls.Add(this.radioButtonLocation);
            this.groupBoxDisplayMember.Controls.Add(this.radioButtonName);
            this.groupBoxDisplayMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDisplayMember.Location = new System.Drawing.Point(562, 106);
            this.groupBoxDisplayMember.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxDisplayMember.Name = "groupBoxDisplayMember";
            this.groupBoxDisplayMember.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxDisplayMember.Size = new System.Drawing.Size(332, 173);
            this.groupBoxDisplayMember.TabIndex = 37;
            this.groupBoxDisplayMember.TabStop = false;
            this.groupBoxDisplayMember.Text = "Display Member";
            // 
            // radioButtonBackgroundColor
            // 
            this.radioButtonBackgroundColor.AutoSize = true;
            this.radioButtonBackgroundColor.Location = new System.Drawing.Point(164, 116);
            this.radioButtonBackgroundColor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButtonBackgroundColor.Name = "radioButtonBackgroundColor";
            this.radioButtonBackgroundColor.Size = new System.Drawing.Size(148, 29);
            this.radioButtonBackgroundColor.TabIndex = 6;
            this.radioButtonBackgroundColor.TabStop = true;
            this.radioButtonBackgroundColor.Text = "Back Color";
            this.radioButtonBackgroundColor.UseVisualStyleBackColor = false;
            this.radioButtonBackgroundColor.CheckedChanged += new System.EventHandler(this.radioButtonBackgroundColor_CheckedChanged);
            // 
            // radioButtonTextColor
            // 
            this.radioButtonTextColor.AutoSize = true;
            this.radioButtonTextColor.Location = new System.Drawing.Point(12, 116);
            this.radioButtonTextColor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButtonTextColor.Name = "radioButtonTextColor";
            this.radioButtonTextColor.Size = new System.Drawing.Size(142, 29);
            this.radioButtonTextColor.TabIndex = 5;
            this.radioButtonTextColor.TabStop = true;
            this.radioButtonTextColor.Text = "Text Color";
            this.radioButtonTextColor.UseVisualStyleBackColor = false;
            this.radioButtonTextColor.CheckedChanged += new System.EventHandler(this.radioButtonTextColor_CheckedChanged);
            // 
            // radioButtonTextFont
            // 
            this.radioButtonTextFont.AutoSize = true;
            this.radioButtonTextFont.Location = new System.Drawing.Point(164, 75);
            this.radioButtonTextFont.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButtonTextFont.Name = "radioButtonTextFont";
            this.radioButtonTextFont.Size = new System.Drawing.Size(134, 29);
            this.radioButtonTextFont.TabIndex = 4;
            this.radioButtonTextFont.TabStop = true;
            this.radioButtonTextFont.Text = "Text Font";
            this.radioButtonTextFont.UseVisualStyleBackColor = false;
            this.radioButtonTextFont.CheckedChanged += new System.EventHandler(this.radioButtonTextFont_CheckedChanged);
            // 
            // radioButtonZOrder
            // 
            this.radioButtonZOrder.AutoSize = true;
            this.radioButtonZOrder.Location = new System.Drawing.Point(164, 31);
            this.radioButtonZOrder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButtonZOrder.Name = "radioButtonZOrder";
            this.radioButtonZOrder.Size = new System.Drawing.Size(110, 29);
            this.radioButtonZOrder.TabIndex = 3;
            this.radioButtonZOrder.TabStop = true;
            this.radioButtonZOrder.Text = "ZOrder";
            this.radioButtonZOrder.UseVisualStyleBackColor = false;
            this.radioButtonZOrder.CheckedChanged += new System.EventHandler(this.radioButtonZOrder_CheckedChanged);
            // 
            // radioButtonLocation
            // 
            this.radioButtonLocation.AutoSize = true;
            this.radioButtonLocation.Location = new System.Drawing.Point(12, 75);
            this.radioButtonLocation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButtonLocation.Name = "radioButtonLocation";
            this.radioButtonLocation.Size = new System.Drawing.Size(125, 29);
            this.radioButtonLocation.TabIndex = 2;
            this.radioButtonLocation.TabStop = true;
            this.radioButtonLocation.Text = "Location";
            this.radioButtonLocation.UseVisualStyleBackColor = false;
            this.radioButtonLocation.CheckedChanged += new System.EventHandler(this.radioButtonLocation_CheckedChanged);
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(10, 31);
            this.radioButtonName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(118, 29);
            this.radioButtonName.TabIndex = 1;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "Content";
            this.radioButtonName.UseVisualStyleBackColor = true;
            this.radioButtonName.CheckedChanged += new System.EventHandler(this.radioButtonName_CheckedChanged);
            // 
            // buttonSendToBack
            // 
            this.buttonSendToBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSendToBack.AutoSize = true;
            this.buttonSendToBack.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSendToBack.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bsDocument, "ZOrder", true));
            this.buttonSendToBack.Location = new System.Drawing.Point(86, 496);
            this.buttonSendToBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonSendToBack.Name = "buttonSendToBack";
            this.buttonSendToBack.Size = new System.Drawing.Size(168, 49);
            this.buttonSendToBack.TabIndex = 40;
            this.buttonSendToBack.Text = "Send to Back";
            this.buttonSendToBack.UseVisualStyleBackColor = false;
            this.buttonSendToBack.Click += new System.EventHandler(this.buttonSendToBack_Click);
            // 
            // buttonBringToFront
            // 
            this.buttonBringToFront.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBringToFront.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonBringToFront.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bsDocument, "ZOrder", true));
            this.buttonBringToFront.Location = new System.Drawing.Point(266, 496);
            this.buttonBringToFront.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonBringToFront.Name = "buttonBringToFront";
            this.buttonBringToFront.Size = new System.Drawing.Size(168, 49);
            this.buttonBringToFront.TabIndex = 41;
            this.buttonBringToFront.Text = "Bring to Front";
            this.buttonBringToFront.UseVisualStyleBackColor = false;
            this.buttonBringToFront.Click += new System.EventHandler(this.buttonBringToFront_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationLabel.AutoSize = true;
            this.locationLabel.BackColor = System.Drawing.Color.Transparent;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(156, 446);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(125, 33);
            this.locationLabel.TabIndex = 42;
            this.locationLabel.Text = "Z-Order";
            // 
            // textColorButton
            // 
            this.textColorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textColorButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", this.bsDocument, "Color", true));
            this.textColorButton.Location = new System.Drawing.Point(556, 377);
            this.textColorButton.Name = "textColorButton";
            this.textColorButton.Size = new System.Drawing.Size(154, 70);
            this.textColorButton.TabIndex = 43;
            this.textColorButton.Text = "Text Color";
            this.textColorButton.UseVisualStyleBackColor = true;
            this.textColorButton.Click += new System.EventHandler(this.textColorButton_Click);
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backgroundColorButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", this.bsDocument, "BackgroundColor", true));
            this.backgroundColorButton.Location = new System.Drawing.Point(712, 377);
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(154, 70);
            this.backgroundColorButton.TabIndex = 44;
            this.backgroundColorButton.Text = "Background Color";
            this.backgroundColorButton.UseVisualStyleBackColor = true;
            this.backgroundColorButton.Click += new System.EventHandler(this.backgroundColorButton_Click);
            // 
            // textFontButton
            // 
            this.textFontButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textFontButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", this.bsDocument, "Font", true));
            this.textFontButton.Location = new System.Drawing.Point(612, 298);
            this.textFontButton.Name = "textFontButton";
            this.textFontButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textFontButton.Size = new System.Drawing.Size(202, 77);
            this.textFontButton.TabIndex = 45;
            this.textFontButton.Text = "Text Font";
            this.textFontButton.UseVisualStyleBackColor = true;
            this.textFontButton.Click += new System.EventHandler(this.textFontButton_Click);
            // 
            // OkOptionsButton
            // 
            this.OkOptionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkOptionsButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.OkOptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkOptionsButton.Location = new System.Drawing.Point(567, 494);
            this.OkOptionsButton.Name = "OkOptionsButton";
            this.OkOptionsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OkOptionsButton.Size = new System.Drawing.Size(146, 53);
            this.OkOptionsButton.TabIndex = 46;
            this.OkOptionsButton.Text = "Apply";
            this.OkOptionsButton.UseVisualStyleBackColor = false;
            this.OkOptionsButton.Click += new System.EventHandler(this.OkOptionsButton_Click);
            // 
            // cancelOptionsButton
            // 
            this.cancelOptionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelOptionsButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cancelOptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOptionsButton.Location = new System.Drawing.Point(723, 494);
            this.cancelOptionsButton.Name = "cancelOptionsButton";
            this.cancelOptionsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cancelOptionsButton.Size = new System.Drawing.Size(146, 53);
            this.cancelOptionsButton.TabIndex = 47;
            this.cancelOptionsButton.Text = "Cancel";
            this.cancelOptionsButton.UseVisualStyleBackColor = false;
            this.cancelOptionsButton.Click += new System.EventHandler(this.cancelOptionsButton_Click);
            // 
            // ZOrderTextBox
            // 
            this.ZOrderTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ZOrderTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ZOrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDocument, "ZOrder", true));
            this.ZOrderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZOrderTextBox.Location = new System.Drawing.Point(292, 446);
            this.ZOrderTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ZOrderTextBox.Name = "ZOrderTextBox";
            this.ZOrderTextBox.ReadOnly = true;
            this.ZOrderTextBox.Size = new System.Drawing.Size(67, 31);
            this.ZOrderTextBox.TabIndex = 48;
            this.ZOrderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // preferencesErrorProvider
            // 
            this.preferencesErrorProvider.ContainerControl = this;
            // 
            // labelRotation
            // 
            this.labelRotation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRotation.AutoSize = true;
            this.labelRotation.BackColor = System.Drawing.Color.Transparent;
            this.labelRotation.Location = new System.Drawing.Point(57, 400);
            this.labelRotation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRotation.Name = "labelRotation";
            this.labelRotation.Size = new System.Drawing.Size(92, 25);
            this.labelRotation.TabIndex = 49;
            this.labelRotation.Text = "Rotation";
            // 
            // rotationTextBox
            // 
            this.rotationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rotationTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rotationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDocument, "Rotation", true));
            this.rotationTextBox.Location = new System.Drawing.Point(162, 394);
            this.rotationTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.rotationTextBox.Name = "rotationTextBox";
            this.rotationTextBox.Size = new System.Drawing.Size(272, 31);
            this.rotationTextBox.TabIndex = 50;
            this.toToolTip.SetToolTip(this.rotationTextBox, "Location of member that can be changed");
            // 
            // TextOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(916, 594);
            this.Controls.Add(this.rotationTextBox);
            this.Controls.Add(this.labelRotation);
            this.Controls.Add(this.ZOrderTextBox);
            this.Controls.Add(this.cancelOptionsButton);
            this.Controls.Add(this.OkOptionsButton);
            this.Controls.Add(this.textFontButton);
            this.Controls.Add(this.backgroundColorButton);
            this.Controls.Add(this.textColorButton);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.buttonBringToFront);
            this.Controls.Add(this.buttonSendToBack);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximumSize = new System.Drawing.Size(1392, 974);
            this.MinimumSize = new System.Drawing.Size(926, 613);
            this.Name = "TextOptions";
            this.Text = "Text Options";
            this.MouseEnter += new System.EventHandler(this.TextOptions_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).EndInit();
            this.groupBoxDisplayMember.ResumeLayout(false);
            this.groupBoxDisplayMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preferencesErrorProvider)).EndInit();
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
        public System.Windows.Forms.ListBox listBoxDoc;
        private System.Windows.Forms.GroupBox groupBoxDisplayMember;
        private System.Windows.Forms.RadioButton radioButtonLocation;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.Button buttonSendToBack;
        private System.Windows.Forms.Button buttonBringToFront;
        private System.Windows.Forms.BindingSource bsDocument;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Button textColorButton;
        private System.Windows.Forms.Button backgroundColorButton;
        private System.Windows.Forms.Button textFontButton;
        private System.Windows.Forms.Button OkOptionsButton;
        private System.Windows.Forms.Button cancelOptionsButton;
        private System.Windows.Forms.TextBox ZOrderTextBox;
        private System.Windows.Forms.RadioButton radioButtonZOrder;
        private System.Windows.Forms.RadioButton radioButtonBackgroundColor;
        private System.Windows.Forms.RadioButton radioButtonTextColor;
        private System.Windows.Forms.RadioButton radioButtonTextFont;
        private System.Windows.Forms.ToolTip toToolTip;
        private System.Windows.Forms.ErrorProvider preferencesErrorProvider;
        private System.Windows.Forms.TextBox rotationTextBox;
        private System.Windows.Forms.Label labelRotation;
        //private System.Collections.Generic.List<Storage.Text> textDoc = new System.Collections.Generic.List<Storage.Text>();


    }
}