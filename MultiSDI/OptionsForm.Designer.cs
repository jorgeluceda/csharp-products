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
            this.locationXTextBox = new System.Windows.Forms.TextBox();
            this.bsShape = new System.Windows.Forms.BindingSource(this.components);
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
            // locationXLabel
            // 
            locationXLabel.AutoSize = true;
            locationXLabel.Location = new System.Drawing.Point(8, 6);
            locationXLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            locationXLabel.Name = "locationXLabel";
            locationXLabel.Size = new System.Drawing.Size(61, 13);
            locationXLabel.TabIndex = 0;
            locationXLabel.Text = "Location X:";
            // 
            // locationYLabel
            // 
            locationYLabel.AutoSize = true;
            locationYLabel.Location = new System.Drawing.Point(170, 6);
            locationYLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            locationYLabel.Name = "locationYLabel";
            locationYLabel.Size = new System.Drawing.Size(61, 13);
            locationYLabel.TabIndex = 2;
            locationYLabel.Text = "Location Y:";
            // 
            // sizeHLabel
            // 
            sizeHLabel.AutoSize = true;
            sizeHLabel.Location = new System.Drawing.Point(27, 31);
            sizeHLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sizeHLabel.Name = "sizeHLabel";
            sizeHLabel.Size = new System.Drawing.Size(41, 13);
            sizeHLabel.TabIndex = 4;
            sizeHLabel.Text = "Size H:";
            // 
            // sizeWLabel
            // 
            sizeWLabel.AutoSize = true;
            sizeWLabel.Location = new System.Drawing.Point(187, 31);
            sizeWLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sizeWLabel.Name = "sizeWLabel";
            sizeWLabel.Size = new System.Drawing.Size(44, 13);
            sizeWLabel.TabIndex = 6;
            sizeWLabel.Text = "Size W:";
            // 
            // brushTypeLabel
            // 
            brushTypeLabel.AutoSize = true;
            brushTypeLabel.Location = new System.Drawing.Point(5, 59);
            brushTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            brushTypeLabel.Name = "brushTypeLabel";
            brushTypeLabel.Size = new System.Drawing.Size(64, 13);
            brushTypeLabel.TabIndex = 8;
            brushTypeLabel.Text = "Brush Type:";
            // 
            // penTypeLabel
            // 
            penTypeLabel.AutoSize = true;
            penTypeLabel.Location = new System.Drawing.Point(177, 59);
            penTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            penTypeLabel.Name = "penTypeLabel";
            penTypeLabel.Size = new System.Drawing.Size(56, 13);
            penTypeLabel.TabIndex = 10;
            penTypeLabel.Text = "Pen Type:";
            // 
            // shapeTypeLabel
            // 
            shapeTypeLabel.AutoSize = true;
            shapeTypeLabel.Location = new System.Drawing.Point(2, 92);
            shapeTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            shapeTypeLabel.Name = "shapeTypeLabel";
            shapeTypeLabel.Size = new System.Drawing.Size(68, 13);
            shapeTypeLabel.TabIndex = 12;
            shapeTypeLabel.Text = "Shape Type:";
            // 
            // locationXTextBox
            // 
            this.locationXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "LocationX", true));
            this.locationXTextBox.Location = new System.Drawing.Point(71, 4);
            this.locationXTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.locationXTextBox.Name = "locationXTextBox";
            this.locationXTextBox.Size = new System.Drawing.Size(82, 20);
            this.locationXTextBox.TabIndex = 1;
            // 
            // bsShape
            // 
            this.bsShape.DataSource = typeof(MultiSDI.Shape);
            // 
            // locationYTextBox
            // 
            this.locationYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "LocationY", true));
            this.locationYTextBox.Location = new System.Drawing.Point(233, 4);
            this.locationYTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.locationYTextBox.Name = "locationYTextBox";
            this.locationYTextBox.Size = new System.Drawing.Size(82, 20);
            this.locationYTextBox.TabIndex = 3;
            // 
            // sizeHTextBox
            // 
            this.sizeHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "SizeH", true));
            this.sizeHTextBox.Location = new System.Drawing.Point(71, 29);
            this.sizeHTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sizeHTextBox.Name = "sizeHTextBox";
            this.sizeHTextBox.Size = new System.Drawing.Size(82, 20);
            this.sizeHTextBox.TabIndex = 5;
            // 
            // sizeWTextBox
            // 
            this.sizeWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "SizeW", true));
            this.sizeWTextBox.Location = new System.Drawing.Point(233, 29);
            this.sizeWTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sizeWTextBox.Name = "sizeWTextBox";
            this.sizeWTextBox.Size = new System.Drawing.Size(82, 20);
            this.sizeWTextBox.TabIndex = 7;
            // 
            // brushTypeComboBox
            // 
            this.brushTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "BrushType", true));
            this.brushTypeComboBox.FormattingEnabled = true;
            this.brushTypeComboBox.Location = new System.Drawing.Point(71, 57);
            this.brushTypeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brushTypeComboBox.Name = "brushTypeComboBox";
            this.brushTypeComboBox.Size = new System.Drawing.Size(82, 21);
            this.brushTypeComboBox.TabIndex = 9;
            // 
            // penTypeComboBox
            // 
            this.penTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "PenType", true));
            this.penTypeComboBox.FormattingEnabled = true;
            this.penTypeComboBox.Location = new System.Drawing.Point(233, 57);
            this.penTypeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.penTypeComboBox.Name = "penTypeComboBox";
            this.penTypeComboBox.Size = new System.Drawing.Size(82, 21);
            this.penTypeComboBox.TabIndex = 11;
            // 
            // shapeTypeComboBox
            // 
            this.shapeTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "ShapeType", true));
            this.shapeTypeComboBox.FormattingEnabled = true;
            this.shapeTypeComboBox.Location = new System.Drawing.Point(71, 90);
            this.shapeTypeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.shapeTypeComboBox.Name = "shapeTypeComboBox";
            this.shapeTypeComboBox.Size = new System.Drawing.Size(244, 21);
            this.shapeTypeComboBox.TabIndex = 13;
            // 
            // btnPenColor
            // 
            this.btnPenColor.Location = new System.Drawing.Point(5, 127);
            this.btnPenColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPenColor.Name = "btnPenColor";
            this.btnPenColor.Size = new System.Drawing.Size(147, 28);
            this.btnPenColor.TabIndex = 14;
            this.btnPenColor.Text = "Pen Color";
            this.btnPenColor.UseVisualStyleBackColor = true;
            this.btnPenColor.Click += new System.EventHandler(this.btnPenColor_Click);
            // 
            // btnBrushColor
            // 
            this.btnBrushColor.Location = new System.Drawing.Point(156, 127);
            this.btnBrushColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrushColor.Name = "btnBrushColor";
            this.btnBrushColor.Size = new System.Drawing.Size(158, 28);
            this.btnBrushColor.TabIndex = 15;
            this.btnBrushColor.Text = "Brush Color";
            this.btnBrushColor.UseVisualStyleBackColor = true;
            this.btnBrushColor.Click += new System.EventHandler(this.btnBrushColor_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(217, 177);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(97, 26);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 211);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsShape)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox locationXTextBox;
        private System.Windows.Forms.TextBox locationYTextBox;
        private System.Windows.Forms.TextBox sizeHTextBox;
        private System.Windows.Forms.TextBox sizeWTextBox;
        private System.Windows.Forms.ComboBox brushTypeComboBox;
        private System.Windows.Forms.ComboBox penTypeComboBox;
        private System.Windows.Forms.ComboBox shapeTypeComboBox;
        private System.Windows.Forms.Button btnPenColor;
        private System.Windows.Forms.Button btnBrushColor;
        private System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.BindingSource bsShape;
        public System.Windows.Forms.ColorDialog colorDialog;
    }
}