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
            this.penColorButton = new System.Windows.Forms.Button();
            this.colorsLabel = new System.Windows.Forms.Label();
            this.brushColorButton = new System.Windows.Forms.Button();
            this.brushTypeLabel = new System.Windows.Forms.Label();
            this.brushTypeComboBox = new System.Windows.Forms.ComboBox();
            this.penTypeLabel = new System.Windows.Forms.Label();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.penTypeComboBox = new System.Windows.Forms.ComboBox();
            this.shapeTypeLabel = new System.Windows.Forms.Label();
            this.shapeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.optionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // penColorButton
            // 
            this.penColorButton.Location = new System.Drawing.Point(93, 40);
            this.penColorButton.Name = "penColorButton";
            this.penColorButton.Size = new System.Drawing.Size(100, 30);
            this.penColorButton.TabIndex = 0;
            this.penColorButton.Text = "Pen Color";
            this.penColorButton.UseVisualStyleBackColor = true;
            this.penColorButton.Click += new System.EventHandler(this.penColorButton_Click);
            // 
            // colorsLabel
            // 
            this.colorsLabel.AutoSize = true;
            this.colorsLabel.Location = new System.Drawing.Point(21, 47);
            this.colorsLabel.Name = "colorsLabel";
            this.colorsLabel.Size = new System.Drawing.Size(52, 17);
            this.colorsLabel.TabIndex = 1;
            this.colorsLabel.Text = "Colors:";
            // 
            // brushColorButton
            // 
            this.brushColorButton.Location = new System.Drawing.Point(213, 40);
            this.brushColorButton.Name = "brushColorButton";
            this.brushColorButton.Size = new System.Drawing.Size(100, 30);
            this.brushColorButton.TabIndex = 2;
            this.brushColorButton.Text = "Brush Color";
            this.brushColorButton.UseVisualStyleBackColor = true;
            this.brushColorButton.Click += new System.EventHandler(this.brushColorButton_Click);
            // 
            // brushTypeLabel
            // 
            this.brushTypeLabel.AutoSize = true;
            this.brushTypeLabel.Location = new System.Drawing.Point(21, 103);
            this.brushTypeLabel.Name = "brushTypeLabel";
            this.brushTypeLabel.Size = new System.Drawing.Size(85, 17);
            this.brushTypeLabel.TabIndex = 3;
            this.brushTypeLabel.Text = "Brush Type:";
            // 
            // brushTypeComboBox
            // 
            this.brushTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brushTypeComboBox.FormattingEnabled = true;
            this.brushTypeComboBox.Items.AddRange(new object[] {
            "Solid",
            "Linear Gradient",
            "Hatched"});
            this.brushTypeComboBox.Location = new System.Drawing.Point(133, 100);
            this.brushTypeComboBox.Name = "brushTypeComboBox";
            this.brushTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.brushTypeComboBox.TabIndex = 4;
            // 
            // penTypeLabel
            // 
            this.penTypeLabel.AutoSize = true;
            this.penTypeLabel.Location = new System.Drawing.Point(21, 149);
            this.penTypeLabel.Name = "penTypeLabel";
            this.penTypeLabel.Size = new System.Drawing.Size(73, 17);
            this.penTypeLabel.TabIndex = 5;
            this.penTypeLabel.Text = "Pen Type:";
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Controls.Add(this.cancelButton);
            this.optionsGroupBox.Controls.Add(this.okButton);
            this.optionsGroupBox.Controls.Add(this.brushColorButton);
            this.optionsGroupBox.Controls.Add(this.brushTypeLabel);
            this.optionsGroupBox.Controls.Add(this.penColorButton);
            this.optionsGroupBox.Controls.Add(this.colorsLabel);
            this.optionsGroupBox.Controls.Add(this.penTypeLabel);
            this.optionsGroupBox.Controls.Add(this.shapeTypeComboBox);
            this.optionsGroupBox.Controls.Add(this.shapeTypeLabel);
            this.optionsGroupBox.Controls.Add(this.brushTypeComboBox);
            this.optionsGroupBox.Controls.Add(this.penTypeComboBox);
            this.optionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(387, 329);
            this.optionsGroupBox.TabIndex = 6;
            this.optionsGroupBox.TabStop = false;
            // 
            // penTypeComboBox
            // 
            this.penTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.penTypeComboBox.FormattingEnabled = true;
            this.penTypeComboBox.Items.AddRange(new object[] {
            "Solid",
            "Dashed",
            "Compound"});
            this.penTypeComboBox.Location = new System.Drawing.Point(133, 146);
            this.penTypeComboBox.Name = "penTypeComboBox";
            this.penTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.penTypeComboBox.TabIndex = 0;
            // 
            // shapeTypeLabel
            // 
            this.shapeTypeLabel.AutoSize = true;
            this.shapeTypeLabel.Location = new System.Drawing.Point(21, 196);
            this.shapeTypeLabel.Name = "shapeTypeLabel";
            this.shapeTypeLabel.Size = new System.Drawing.Size(89, 17);
            this.shapeTypeLabel.TabIndex = 1;
            this.shapeTypeLabel.Text = "Shape Type:";
            // 
            // shapeTypeComboBox
            // 
            this.shapeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shapeTypeComboBox.FormattingEnabled = true;
            this.shapeTypeComboBox.Items.AddRange(new object[] {
            "Ellipse",
            "Rectangle",
            "Custom"});
            this.shapeTypeComboBox.Location = new System.Drawing.Point(133, 193);
            this.shapeTypeComboBox.Name = "shapeTypeComboBox";
            this.shapeTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.shapeTypeComboBox.TabIndex = 5;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(93, 273);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 30);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(213, 273);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 30);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ShapeOptions
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(387, 329);
            this.Controls.Add(this.optionsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShapeOptions";
            this.ShowIcon = false;
            this.Text = "Shape Options";
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button penColorButton;
        private System.Windows.Forms.Label colorsLabel;
        private System.Windows.Forms.Button brushColorButton;
        private System.Windows.Forms.Label brushTypeLabel;
        private System.Windows.Forms.ComboBox brushTypeComboBox;
        private System.Windows.Forms.Label penTypeLabel;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.ComboBox penTypeComboBox;
        private System.Windows.Forms.ComboBox shapeTypeComboBox;
        private System.Windows.Forms.Label shapeTypeLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}