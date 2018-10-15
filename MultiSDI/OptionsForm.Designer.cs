namespace MultiSDI
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
            System.Windows.Forms.Label locationXLabel;
            System.Windows.Forms.Label locationYLabel;
            System.Windows.Forms.Label sizeHLabel;
            System.Windows.Forms.Label sizeWLabel;
            System.Windows.Forms.Label brushTypeLabel;
            System.Windows.Forms.Label penTypeLabel;
            System.Windows.Forms.Label shapeTypeLabel;
            this.bsShape = new System.Windows.Forms.BindingSource(this.components);
            this.locationXTextBox = new System.Windows.Forms.TextBox();
            this.locationYTextBox = new System.Windows.Forms.TextBox();
            this.sizeHTextBox = new System.Windows.Forms.TextBox();
            this.sizeWTextBox = new System.Windows.Forms.TextBox();
            this.brushTypeComboBox = new System.Windows.Forms.ComboBox();
            this.penTypeComboBox = new System.Windows.Forms.ComboBox();
            this.shapeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnPenColor = new System.Windows.Forms.Button();
            this.btnBrushColor = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            locationXLabel = new System.Windows.Forms.Label();
            locationYLabel = new System.Windows.Forms.Label();
            sizeHLabel = new System.Windows.Forms.Label();
            sizeWLabel = new System.Windows.Forms.Label();
            brushTypeLabel = new System.Windows.Forms.Label();
            penTypeLabel = new System.Windows.Forms.Label();
            shapeTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsShape)).BeginInit();
            this.SuspendLayout();
            // 
            // bsShape
            // 
            this.bsShape.DataSource = typeof(MultiSDI.Shape);
            // 
            // locationXLabel
            // 
            locationXLabel.AutoSize = true;
            locationXLabel.Location = new System.Drawing.Point(12, 9);
            locationXLabel.Name = "locationXLabel";
            locationXLabel.Size = new System.Drawing.Size(89, 20);
            locationXLabel.TabIndex = 0;
            locationXLabel.Text = "Location X:";
            // 
            // locationXTextBox
            // 
            this.locationXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "LocationX", true));
            this.locationXTextBox.Location = new System.Drawing.Point(107, 6);
            this.locationXTextBox.Name = "locationXTextBox";
            this.locationXTextBox.Size = new System.Drawing.Size(121, 26);
            this.locationXTextBox.TabIndex = 1;
            // 
            // locationYLabel
            // 
            locationYLabel.AutoSize = true;
            locationYLabel.Location = new System.Drawing.Point(255, 9);
            locationYLabel.Name = "locationYLabel";
            locationYLabel.Size = new System.Drawing.Size(89, 20);
            locationYLabel.TabIndex = 2;
            locationYLabel.Text = "Location Y:";
            // 
            // locationYTextBox
            // 
            this.locationYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "LocationY", true));
            this.locationYTextBox.Location = new System.Drawing.Point(350, 6);
            this.locationYTextBox.Name = "locationYTextBox";
            this.locationYTextBox.Size = new System.Drawing.Size(121, 26);
            this.locationYTextBox.TabIndex = 3;
            // 
            // sizeHLabel
            // 
            sizeHLabel.AutoSize = true;
            sizeHLabel.Location = new System.Drawing.Point(41, 48);
            sizeHLabel.Name = "sizeHLabel";
            sizeHLabel.Size = new System.Drawing.Size(60, 20);
            sizeHLabel.TabIndex = 4;
            sizeHLabel.Text = "Size H:";
            // 
            // sizeHTextBox
            // 
            this.sizeHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "SizeH", true));
            this.sizeHTextBox.Location = new System.Drawing.Point(107, 45);
            this.sizeHTextBox.Name = "sizeHTextBox";
            this.sizeHTextBox.Size = new System.Drawing.Size(121, 26);
            this.sizeHTextBox.TabIndex = 5;
            // 
            // sizeWLabel
            // 
            sizeWLabel.AutoSize = true;
            sizeWLabel.Location = new System.Drawing.Point(281, 48);
            sizeWLabel.Name = "sizeWLabel";
            sizeWLabel.Size = new System.Drawing.Size(63, 20);
            sizeWLabel.TabIndex = 6;
            sizeWLabel.Text = "Size W:";
            // 
            // sizeWTextBox
            // 
            this.sizeWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "SizeW", true));
            this.sizeWTextBox.Location = new System.Drawing.Point(350, 45);
            this.sizeWTextBox.Name = "sizeWTextBox";
            this.sizeWTextBox.Size = new System.Drawing.Size(121, 26);
            this.sizeWTextBox.TabIndex = 7;
            // 
            // brushTypeLabel
            // 
            brushTypeLabel.AutoSize = true;
            brushTypeLabel.Location = new System.Drawing.Point(8, 91);
            brushTypeLabel.Name = "brushTypeLabel";
            brushTypeLabel.Size = new System.Drawing.Size(93, 20);
            brushTypeLabel.TabIndex = 8;
            brushTypeLabel.Text = "Brush Type:";
            // 
            // brushTypeComboBox
            // 
            this.brushTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "BrushType", true));
            this.brushTypeComboBox.FormattingEnabled = true;
            this.brushTypeComboBox.Location = new System.Drawing.Point(107, 88);
            this.brushTypeComboBox.Name = "brushTypeComboBox";
            this.brushTypeComboBox.Size = new System.Drawing.Size(121, 28);
            this.brushTypeComboBox.TabIndex = 9;
            // 
            // penTypeLabel
            // 
            penTypeLabel.AutoSize = true;
            penTypeLabel.Location = new System.Drawing.Point(265, 91);
            penTypeLabel.Name = "penTypeLabel";
            penTypeLabel.Size = new System.Drawing.Size(79, 20);
            penTypeLabel.TabIndex = 10;
            penTypeLabel.Text = "Pen Type:";
            // 
            // penTypeComboBox
            // 
            this.penTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "PenType", true));
            this.penTypeComboBox.FormattingEnabled = true;
            this.penTypeComboBox.Location = new System.Drawing.Point(350, 88);
            this.penTypeComboBox.Name = "penTypeComboBox";
            this.penTypeComboBox.Size = new System.Drawing.Size(121, 28);
            this.penTypeComboBox.TabIndex = 11;
            // 
            // shapeTypeLabel
            // 
            shapeTypeLabel.AutoSize = true;
            shapeTypeLabel.Location = new System.Drawing.Point(3, 141);
            shapeTypeLabel.Name = "shapeTypeLabel";
            shapeTypeLabel.Size = new System.Drawing.Size(98, 20);
            shapeTypeLabel.TabIndex = 12;
            shapeTypeLabel.Text = "Shape Type:";
            // 
            // shapeTypeComboBox
            // 
            this.shapeTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "ShapeType", true));
            this.shapeTypeComboBox.FormattingEnabled = true;
            this.shapeTypeComboBox.Location = new System.Drawing.Point(107, 138);
            this.shapeTypeComboBox.Name = "shapeTypeComboBox";
            this.shapeTypeComboBox.Size = new System.Drawing.Size(364, 28);
            this.shapeTypeComboBox.TabIndex = 13;
            // 
            // btnPenColor
            // 
            this.btnPenColor.Location = new System.Drawing.Point(7, 196);
            this.btnPenColor.Name = "btnPenColor";
            this.btnPenColor.Size = new System.Drawing.Size(221, 43);
            this.btnPenColor.TabIndex = 14;
            this.btnPenColor.Text = "Pen Color";
            this.btnPenColor.UseVisualStyleBackColor = true;
            this.btnPenColor.Click += new System.EventHandler(this.btnPenColor_Click);
            // 
            // btnBrushColor
            // 
            this.btnBrushColor.Location = new System.Drawing.Point(234, 196);
            this.btnBrushColor.Name = "btnBrushColor";
            this.btnBrushColor.Size = new System.Drawing.Size(237, 43);
            this.btnBrushColor.TabIndex = 15;
            this.btnBrushColor.Text = "Brush Color";
            this.btnBrushColor.UseVisualStyleBackColor = true;
            this.btnBrushColor.Click += new System.EventHandler(this.btnBrushColor_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(326, 272);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(145, 40);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 324);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnBrushColor);
            this.Controls.Add(this.btnPenColor);
            this.Controls.Add(shapeTypeLabel);
            this.Controls.Add(this.shapeTypeComboBox);
            this.Controls.Add(penTypeLabel);
            this.Controls.Add(this.penTypeComboBox);
            this.Controls.Add(brushTypeLabel);
            this.Controls.Add(this.brushTypeComboBox);
            this.Controls.Add(sizeWLabel);
            this.Controls.Add(this.sizeWTextBox);
            this.Controls.Add(sizeHLabel);
            this.Controls.Add(this.sizeHTextBox);
            this.Controls.Add(locationYLabel);
            this.Controls.Add(this.locationYTextBox);
            this.Controls.Add(locationXLabel);
            this.Controls.Add(this.locationXTextBox);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            ((System.ComponentModel.ISupportInitialize)(this.bsShape)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsShape;
        private System.Windows.Forms.TextBox locationXTextBox;
        private System.Windows.Forms.TextBox locationYTextBox;
        private System.Windows.Forms.TextBox sizeHTextBox;
        private System.Windows.Forms.TextBox sizeWTextBox;
        private System.Windows.Forms.ComboBox brushTypeComboBox;
        private System.Windows.Forms.ComboBox penTypeComboBox;
        private System.Windows.Forms.ComboBox shapeTypeComboBox;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnPenColor;
        private System.Windows.Forms.Button btnBrushColor;
        private System.Windows.Forms.Button btnOk;
    }
}