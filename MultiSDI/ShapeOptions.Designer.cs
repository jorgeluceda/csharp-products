namespace MultiSDI
{
    partial class ShapeOptions
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
            this.penColorButton = new System.Windows.Forms.Button();
            this.brushColorButton = new System.Windows.Forms.Button();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.shapeHeightTextBox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.shapeYTextBox = new System.Windows.Forms.TextBox();
            this.shapeWidthTextBox = new System.Windows.Forms.TextBox();
            this.shapeXTextBox = new System.Windows.Forms.TextBox();
            this.shapeSizeLabel = new System.Windows.Forms.Label();
            this.shapeLocationLabel = new System.Windows.Forms.Label();
            this.shapeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.brushTypeComboBox = new System.Windows.Forms.ComboBox();
            this.penTypeComboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.shapeTypeLabel = new System.Windows.Forms.Label();
            this.brushTypeLabel = new System.Windows.Forms.Label();
            this.penTypeLabel = new System.Windows.Forms.Label();
            this.shapeOptionsErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.optionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapeOptionsErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // penColorButton
            // 
            this.penColorButton.Location = new System.Drawing.Point(89, 135);
            this.penColorButton.Name = "penColorButton";
            this.penColorButton.Size = new System.Drawing.Size(100, 30);
            this.penColorButton.TabIndex = 1;
            this.penColorButton.Text = "Pen Color";
            this.penColorButton.UseVisualStyleBackColor = true;
            this.penColorButton.Click += new System.EventHandler(this.penColorButton_Click);
            // 
            // brushColorButton
            // 
            this.brushColorButton.Location = new System.Drawing.Point(243, 135);
            this.brushColorButton.Name = "brushColorButton";
            this.brushColorButton.Size = new System.Drawing.Size(100, 30);
            this.brushColorButton.TabIndex = 2;
            this.brushColorButton.Text = "Brush Color";
            this.brushColorButton.UseVisualStyleBackColor = true;
            this.brushColorButton.Click += new System.EventHandler(this.brushColorButton_Click);
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Controls.Add(this.heightLabel);
            this.optionsGroupBox.Controls.Add(this.shapeHeightTextBox);
            this.optionsGroupBox.Controls.Add(this.widthLabel);
            this.optionsGroupBox.Controls.Add(this.yLabel);
            this.optionsGroupBox.Controls.Add(this.xLabel);
            this.optionsGroupBox.Controls.Add(this.shapeYTextBox);
            this.optionsGroupBox.Controls.Add(this.shapeWidthTextBox);
            this.optionsGroupBox.Controls.Add(this.shapeXTextBox);
            this.optionsGroupBox.Controls.Add(this.shapeSizeLabel);
            this.optionsGroupBox.Controls.Add(this.shapeLocationLabel);
            this.optionsGroupBox.Controls.Add(this.shapeTypeComboBox);
            this.optionsGroupBox.Controls.Add(this.brushTypeComboBox);
            this.optionsGroupBox.Controls.Add(this.penTypeComboBox);
            this.optionsGroupBox.Controls.Add(this.cancelButton);
            this.optionsGroupBox.Controls.Add(this.okButton);
            this.optionsGroupBox.Controls.Add(this.shapeTypeLabel);
            this.optionsGroupBox.Controls.Add(this.brushTypeLabel);
            this.optionsGroupBox.Controls.Add(this.penTypeLabel);
            this.optionsGroupBox.Controls.Add(this.brushColorButton);
            this.optionsGroupBox.Controls.Add(this.penColorButton);
            this.optionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(452, 444);
            this.optionsGroupBox.TabIndex = 3;
            this.optionsGroupBox.TabStop = false;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(377, 92);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(49, 17);
            this.heightLabel.TabIndex = 20;
            this.heightLabel.Text = "Height";
            // 
            // shapeHeightTextBox
            // 
            this.shapeHeightTextBox.Location = new System.Drawing.Point(305, 87);
            this.shapeHeightTextBox.Name = "shapeHeightTextBox";
            this.shapeHeightTextBox.Size = new System.Drawing.Size(66, 22);
            this.shapeHeightTextBox.TabIndex = 19;
            this.shapeHeightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.shapeHeightTextBox_Validating);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(242, 92);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(44, 17);
            this.widthLabel.TabIndex = 18;
            this.widthLabel.Text = "Width";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(377, 33);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(17, 17);
            this.yLabel.TabIndex = 17;
            this.yLabel.Text = "Y";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(242, 33);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(17, 17);
            this.xLabel.TabIndex = 16;
            this.xLabel.Text = "X";
            // 
            // shapeYTextBox
            // 
            this.shapeYTextBox.Location = new System.Drawing.Point(305, 30);
            this.shapeYTextBox.Name = "shapeYTextBox";
            this.shapeYTextBox.Size = new System.Drawing.Size(66, 22);
            this.shapeYTextBox.TabIndex = 15;
            this.shapeYTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.shapeYTextBox_Validating);
            // 
            // shapeWidthTextBox
            // 
            this.shapeWidthTextBox.Location = new System.Drawing.Point(170, 89);
            this.shapeWidthTextBox.Name = "shapeWidthTextBox";
            this.shapeWidthTextBox.Size = new System.Drawing.Size(66, 22);
            this.shapeWidthTextBox.TabIndex = 14;
            this.shapeWidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.shapeWidthTextBox_Validating);
            // 
            // shapeXTextBox
            // 
            this.shapeXTextBox.Location = new System.Drawing.Point(170, 30);
            this.shapeXTextBox.Name = "shapeXTextBox";
            this.shapeXTextBox.Size = new System.Drawing.Size(66, 22);
            this.shapeXTextBox.TabIndex = 13;
            this.shapeXTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.shapeXTextBox_Validating);
            // 
            // shapeSizeLabel
            // 
            this.shapeSizeLabel.AutoSize = true;
            this.shapeSizeLabel.Location = new System.Drawing.Point(42, 92);
            this.shapeSizeLabel.Name = "shapeSizeLabel";
            this.shapeSizeLabel.Size = new System.Drawing.Size(84, 17);
            this.shapeSizeLabel.TabIndex = 12;
            this.shapeSizeLabel.Text = "Shape Size:";
            // 
            // shapeLocationLabel
            // 
            this.shapeLocationLabel.AutoSize = true;
            this.shapeLocationLabel.Location = new System.Drawing.Point(42, 33);
            this.shapeLocationLabel.Name = "shapeLocationLabel";
            this.shapeLocationLabel.Size = new System.Drawing.Size(111, 17);
            this.shapeLocationLabel.TabIndex = 11;
            this.shapeLocationLabel.Text = "Shape Location:";
            // 
            // shapeTypeComboBox
            // 
            this.shapeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shapeTypeComboBox.FormattingEnabled = true;
            this.shapeTypeComboBox.Items.AddRange(new object[] {
            "Ellipse",
            "Rectangle",
            "Custom"});
            this.shapeTypeComboBox.Location = new System.Drawing.Point(170, 306);
            this.shapeTypeComboBox.Name = "shapeTypeComboBox";
            this.shapeTypeComboBox.Size = new System.Drawing.Size(173, 24);
            this.shapeTypeComboBox.TabIndex = 10;
            // 
            // brushTypeComboBox
            // 
            this.brushTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brushTypeComboBox.FormattingEnabled = true;
            this.brushTypeComboBox.Items.AddRange(new object[] {
            "Solid",
            "Linear Gradient",
            "Hatched"});
            this.brushTypeComboBox.Location = new System.Drawing.Point(170, 245);
            this.brushTypeComboBox.Name = "brushTypeComboBox";
            this.brushTypeComboBox.Size = new System.Drawing.Size(173, 24);
            this.brushTypeComboBox.TabIndex = 9;
            // 
            // penTypeComboBox
            // 
            this.penTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.penTypeComboBox.FormattingEnabled = true;
            this.penTypeComboBox.Items.AddRange(new object[] {
            "Solid",
            "Dashed",
            "Compound"});
            this.penTypeComboBox.Location = new System.Drawing.Point(170, 189);
            this.penTypeComboBox.Name = "penTypeComboBox";
            this.penTypeComboBox.Size = new System.Drawing.Size(173, 24);
            this.penTypeComboBox.TabIndex = 8;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(305, 372);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 30);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(188, 372);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 30);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // shapeTypeLabel
            // 
            this.shapeTypeLabel.AutoSize = true;
            this.shapeTypeLabel.Location = new System.Drawing.Point(42, 309);
            this.shapeTypeLabel.Name = "shapeTypeLabel";
            this.shapeTypeLabel.Size = new System.Drawing.Size(89, 17);
            this.shapeTypeLabel.TabIndex = 5;
            this.shapeTypeLabel.Text = "Shape Type:";
            // 
            // brushTypeLabel
            // 
            this.brushTypeLabel.AutoSize = true;
            this.brushTypeLabel.Location = new System.Drawing.Point(42, 248);
            this.brushTypeLabel.Name = "brushTypeLabel";
            this.brushTypeLabel.Size = new System.Drawing.Size(85, 17);
            this.brushTypeLabel.TabIndex = 4;
            this.brushTypeLabel.Text = "Brush Type:";
            // 
            // penTypeLabel
            // 
            this.penTypeLabel.AutoSize = true;
            this.penTypeLabel.Location = new System.Drawing.Point(42, 192);
            this.penTypeLabel.Name = "penTypeLabel";
            this.penTypeLabel.Size = new System.Drawing.Size(73, 17);
            this.penTypeLabel.TabIndex = 3;
            this.penTypeLabel.Text = "Pen Type:";
            // 
            // shapeOptionsErrorProvider
            // 
            this.shapeOptionsErrorProvider.ContainerControl = this;
            // 
            // ShapeOptions
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(452, 444);
            this.Controls.Add(this.optionsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShapeOptions";
            this.ShowIcon = false;
            this.Text = "Shape Options";
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapeOptionsErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button penColorButton;
        private System.Windows.Forms.Button brushColorButton;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.ComboBox shapeTypeComboBox;
        private System.Windows.Forms.ComboBox brushTypeComboBox;
        private System.Windows.Forms.ComboBox penTypeComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label shapeTypeLabel;
        private System.Windows.Forms.Label brushTypeLabel;
        private System.Windows.Forms.Label penTypeLabel;
        private System.Windows.Forms.TextBox shapeWidthTextBox;
        private System.Windows.Forms.TextBox shapeXTextBox;
        private System.Windows.Forms.Label shapeSizeLabel;
        private System.Windows.Forms.Label shapeLocationLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox shapeYTextBox;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox shapeHeightTextBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.ErrorProvider shapeOptionsErrorProvider;
    }
}