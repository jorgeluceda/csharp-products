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
            this.shapeOptionsErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            locationXLabel = new System.Windows.Forms.Label();
            locationYLabel = new System.Windows.Forms.Label();
            sizeHLabel = new System.Windows.Forms.Label();
            sizeWLabel = new System.Windows.Forms.Label();
            brushTypeLabel = new System.Windows.Forms.Label();
            penTypeLabel = new System.Windows.Forms.Label();
            shapeTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsShape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeOptionsErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // locationXLabel
            // 
            locationXLabel.AutoSize = true;
            locationXLabel.Location = new System.Drawing.Point(16, 11);
            locationXLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            locationXLabel.Name = "locationXLabel";
            locationXLabel.Size = new System.Drawing.Size(120, 25);
            locationXLabel.TabIndex = 0;
            locationXLabel.Text = "Location X:";
            // 
            // locationYLabel
            // 
            locationYLabel.AutoSize = true;
            locationYLabel.Location = new System.Drawing.Point(340, 11);
            locationYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            locationYLabel.Name = "locationYLabel";
            locationYLabel.Size = new System.Drawing.Size(121, 25);
            locationYLabel.TabIndex = 2;
            locationYLabel.Text = "Location Y:";
            // 
            // sizeHLabel
            // 
            sizeHLabel.AutoSize = true;
            sizeHLabel.Location = new System.Drawing.Point(54, 59);
            sizeHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sizeHLabel.Name = "sizeHLabel";
            sizeHLabel.Size = new System.Drawing.Size(81, 25);
            sizeHLabel.TabIndex = 4;
            sizeHLabel.Text = "Size H:";
            // 
            // sizeWLabel
            // 
            sizeWLabel.AutoSize = true;
            sizeWLabel.Location = new System.Drawing.Point(374, 59);
            sizeWLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sizeWLabel.Name = "sizeWLabel";
            sizeWLabel.Size = new System.Drawing.Size(86, 25);
            sizeWLabel.TabIndex = 6;
            sizeWLabel.Text = "Size W:";
            // 
            // brushTypeLabel
            // 
            brushTypeLabel.AutoSize = true;
            brushTypeLabel.Location = new System.Drawing.Point(10, 114);
            brushTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            brushTypeLabel.Name = "brushTypeLabel";
            brushTypeLabel.Size = new System.Drawing.Size(128, 25);
            brushTypeLabel.TabIndex = 8;
            brushTypeLabel.Text = "Brush Type:";
            // 
            // penTypeLabel
            // 
            penTypeLabel.AutoSize = true;
            penTypeLabel.Location = new System.Drawing.Point(354, 114);
            penTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            penTypeLabel.Name = "penTypeLabel";
            penTypeLabel.Size = new System.Drawing.Size(110, 25);
            penTypeLabel.TabIndex = 10;
            penTypeLabel.Text = "Pen Type:";
            // 
            // shapeTypeLabel
            // 
            shapeTypeLabel.AutoSize = true;
            shapeTypeLabel.Location = new System.Drawing.Point(4, 177);
            shapeTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            shapeTypeLabel.Name = "shapeTypeLabel";
            shapeTypeLabel.Size = new System.Drawing.Size(134, 25);
            shapeTypeLabel.TabIndex = 12;
            shapeTypeLabel.Text = "Shape Type:";
            // 
            // locationXTextBox
            // 
            this.locationXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "LocationX", true));
            this.locationXTextBox.Location = new System.Drawing.Point(142, 8);
            this.locationXTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.locationXTextBox.Name = "locationXTextBox";
            this.locationXTextBox.Size = new System.Drawing.Size(160, 31);
            this.locationXTextBox.TabIndex = 1;
            this.locationXTextBox.TextChanged += new System.EventHandler(this.locationXTextBox_TextChanged);
            this.locationXTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.locationXTextBox_Validating);
            // 
            // bsShape
            // 
            this.bsShape.DataSource = typeof(MultiSDI.Shape);
            // 
            // locationYTextBox
            // 
            this.locationYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "LocationY", true));
            this.locationYTextBox.Location = new System.Drawing.Point(466, 8);
            this.locationYTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.locationYTextBox.Name = "locationYTextBox";
            this.locationYTextBox.Size = new System.Drawing.Size(160, 31);
            this.locationYTextBox.TabIndex = 3;
            this.locationYTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.locationYTextBox_Validating);
            // 
            // sizeHTextBox
            // 
            this.sizeHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "SizeH", true));
            this.sizeHTextBox.Location = new System.Drawing.Point(142, 56);
            this.sizeHTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sizeHTextBox.Name = "sizeHTextBox";
            this.sizeHTextBox.Size = new System.Drawing.Size(160, 31);
            this.sizeHTextBox.TabIndex = 5;
            this.sizeHTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.sizeHTextBox_Validating);
            // 
            // sizeWTextBox
            // 
            this.sizeWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "SizeW", true));
            this.sizeWTextBox.Location = new System.Drawing.Point(466, 56);
            this.sizeWTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sizeWTextBox.Name = "sizeWTextBox";
            this.sizeWTextBox.Size = new System.Drawing.Size(160, 31);
            this.sizeWTextBox.TabIndex = 7;
            this.sizeWTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.sizeWTextBox_Validating);
            // 
            // brushTypeComboBox
            // 
            this.brushTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "BrushType", true));
            this.brushTypeComboBox.FormattingEnabled = true;
            this.brushTypeComboBox.Location = new System.Drawing.Point(142, 109);
            this.brushTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.brushTypeComboBox.Name = "brushTypeComboBox";
            this.brushTypeComboBox.Size = new System.Drawing.Size(160, 33);
            this.brushTypeComboBox.TabIndex = 9;
            // 
            // penTypeComboBox
            // 
            this.penTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "PenType", true));
            this.penTypeComboBox.FormattingEnabled = true;
            this.penTypeComboBox.Location = new System.Drawing.Point(466, 109);
            this.penTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.penTypeComboBox.Name = "penTypeComboBox";
            this.penTypeComboBox.Size = new System.Drawing.Size(160, 33);
            this.penTypeComboBox.TabIndex = 11;
            // 
            // shapeTypeComboBox
            // 
            this.shapeTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "ShapeType", true));
            this.shapeTypeComboBox.FormattingEnabled = true;
            this.shapeTypeComboBox.Location = new System.Drawing.Point(142, 173);
            this.shapeTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shapeTypeComboBox.Name = "shapeTypeComboBox";
            this.shapeTypeComboBox.Size = new System.Drawing.Size(484, 33);
            this.shapeTypeComboBox.TabIndex = 13;
            // 
            // btnPenColor
            // 
            this.btnPenColor.Location = new System.Drawing.Point(10, 244);
            this.btnPenColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPenColor.Name = "btnPenColor";
            this.btnPenColor.Size = new System.Drawing.Size(294, 53);
            this.btnPenColor.TabIndex = 14;
            this.btnPenColor.Text = "Pen Color";
            this.btnPenColor.UseVisualStyleBackColor = true;
            this.btnPenColor.Click += new System.EventHandler(this.btnPenColor_Click);
            // 
            // btnBrushColor
            // 
            this.btnBrushColor.Location = new System.Drawing.Point(312, 244);
            this.btnBrushColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrushColor.Name = "btnBrushColor";
            this.btnBrushColor.Size = new System.Drawing.Size(316, 53);
            this.btnBrushColor.TabIndex = 15;
            this.btnBrushColor.Text = "Brush Color";
            this.btnBrushColor.UseVisualStyleBackColor = true;
            this.btnBrushColor.Click += new System.EventHandler(this.btnBrushColor_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(434, 341);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(194, 50);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // shapeOptionsErrorProvider
            // 
            this.shapeOptionsErrorProvider.ContainerControl = this;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 406);
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
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsShape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeOptionsErrorProvider)).EndInit();
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
        private System.Windows.Forms.ErrorProvider shapeOptionsErrorProvider;
    }
}