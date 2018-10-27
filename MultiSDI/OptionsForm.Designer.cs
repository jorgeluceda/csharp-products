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
            locationXLabel.Location = new System.Drawing.Point(11, 7);
            locationXLabel.Name = "locationXLabel";
            locationXLabel.Size = new System.Drawing.Size(79, 17);
            locationXLabel.TabIndex = 0;
            locationXLabel.Text = "Location X:";
            // 
            // locationYLabel
            // 
            locationYLabel.AutoSize = true;
            locationYLabel.Location = new System.Drawing.Point(227, 7);
            locationYLabel.Name = "locationYLabel";
            locationYLabel.Size = new System.Drawing.Size(79, 17);
            locationYLabel.TabIndex = 2;
            locationYLabel.Text = "Location Y:";
            // 
            // sizeHLabel
            // 
            sizeHLabel.AutoSize = true;
            sizeHLabel.Location = new System.Drawing.Point(36, 38);
            sizeHLabel.Name = "sizeHLabel";
            sizeHLabel.Size = new System.Drawing.Size(53, 17);
            sizeHLabel.TabIndex = 4;
            sizeHLabel.Text = "Size H:";
            // 
            // sizeWLabel
            // 
            sizeWLabel.AutoSize = true;
            sizeWLabel.Location = new System.Drawing.Point(249, 38);
            sizeWLabel.Name = "sizeWLabel";
            sizeWLabel.Size = new System.Drawing.Size(56, 17);
            sizeWLabel.TabIndex = 6;
            sizeWLabel.Text = "Size W:";
            // 
            // brushTypeLabel
            // 
            brushTypeLabel.AutoSize = true;
            brushTypeLabel.Location = new System.Drawing.Point(7, 73);
            brushTypeLabel.Name = "brushTypeLabel";
            brushTypeLabel.Size = new System.Drawing.Size(85, 17);
            brushTypeLabel.TabIndex = 8;
            brushTypeLabel.Text = "Brush Type:";
            // 
            // penTypeLabel
            // 
            penTypeLabel.AutoSize = true;
            penTypeLabel.Location = new System.Drawing.Point(236, 73);
            penTypeLabel.Name = "penTypeLabel";
            penTypeLabel.Size = new System.Drawing.Size(73, 17);
            penTypeLabel.TabIndex = 10;
            penTypeLabel.Text = "Pen Type:";
            // 
            // shapeTypeLabel
            // 
            shapeTypeLabel.AutoSize = true;
            shapeTypeLabel.Location = new System.Drawing.Point(3, 113);
            shapeTypeLabel.Name = "shapeTypeLabel";
            shapeTypeLabel.Size = new System.Drawing.Size(89, 17);
            shapeTypeLabel.TabIndex = 12;
            shapeTypeLabel.Text = "Shape Type:";
            // 
            // locationXTextBox
            // 
            this.locationXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "LocationX", true));
            this.locationXTextBox.Location = new System.Drawing.Point(95, 5);
            this.locationXTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.locationXTextBox.Name = "locationXTextBox";
            this.locationXTextBox.Size = new System.Drawing.Size(108, 22);
            this.locationXTextBox.TabIndex = 1;
            this.locationXTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.locationXTextBox_Validating);
            // 
            // bsShape
            // 
            this.bsShape.DataSource = typeof(MultiSDI.Shape);
            // 
            // locationYTextBox
            // 
            this.locationYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "LocationY", true));
            this.locationYTextBox.Location = new System.Drawing.Point(311, 5);
            this.locationYTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.locationYTextBox.Name = "locationYTextBox";
            this.locationYTextBox.Size = new System.Drawing.Size(108, 22);
            this.locationYTextBox.TabIndex = 3;
            this.locationYTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.locationYTextBox_Validating);
            // 
            // sizeHTextBox
            // 
            this.sizeHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "SizeH", true));
            this.sizeHTextBox.Location = new System.Drawing.Point(95, 36);
            this.sizeHTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sizeHTextBox.Name = "sizeHTextBox";
            this.sizeHTextBox.Size = new System.Drawing.Size(108, 22);
            this.sizeHTextBox.TabIndex = 5;
            this.sizeHTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.sizeHTextBox_Validating);
            // 
            // sizeWTextBox
            // 
            this.sizeWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "SizeW", true));
            this.sizeWTextBox.Location = new System.Drawing.Point(311, 36);
            this.sizeWTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sizeWTextBox.Name = "sizeWTextBox";
            this.sizeWTextBox.Size = new System.Drawing.Size(108, 22);
            this.sizeWTextBox.TabIndex = 7;
            this.sizeWTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.sizeWTextBox_Validating);
            // 
            // brushTypeComboBox
            // 
            this.brushTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "BrushType", true));
            this.brushTypeComboBox.FormattingEnabled = true;
            this.brushTypeComboBox.Location = new System.Drawing.Point(95, 70);
            this.brushTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brushTypeComboBox.Name = "brushTypeComboBox";
            this.brushTypeComboBox.Size = new System.Drawing.Size(108, 24);
            this.brushTypeComboBox.TabIndex = 9;
            // 
            // penTypeComboBox
            // 
            this.penTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "PenType", true));
            this.penTypeComboBox.FormattingEnabled = true;
            this.penTypeComboBox.Location = new System.Drawing.Point(311, 70);
            this.penTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.penTypeComboBox.Name = "penTypeComboBox";
            this.penTypeComboBox.Size = new System.Drawing.Size(108, 24);
            this.penTypeComboBox.TabIndex = 11;
            // 
            // shapeTypeComboBox
            // 
            this.shapeTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsShape, "ShapeType", true));
            this.shapeTypeComboBox.FormattingEnabled = true;
            this.shapeTypeComboBox.Location = new System.Drawing.Point(95, 111);
            this.shapeTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shapeTypeComboBox.Name = "shapeTypeComboBox";
            this.shapeTypeComboBox.Size = new System.Drawing.Size(324, 24);
            this.shapeTypeComboBox.TabIndex = 13;
            // 
            // btnPenColor
            // 
            this.btnPenColor.Location = new System.Drawing.Point(7, 156);
            this.btnPenColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPenColor.Name = "btnPenColor";
            this.btnPenColor.Size = new System.Drawing.Size(196, 34);
            this.btnPenColor.TabIndex = 14;
            this.btnPenColor.Text = "Pen Color";
            this.btnPenColor.UseVisualStyleBackColor = true;
            this.btnPenColor.Click += new System.EventHandler(this.btnPenColor_Click);
            // 
            // btnBrushColor
            // 
            this.btnBrushColor.Location = new System.Drawing.Point(208, 156);
            this.btnBrushColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrushColor.Name = "btnBrushColor";
            this.btnBrushColor.Size = new System.Drawing.Size(211, 34);
            this.btnBrushColor.TabIndex = 15;
            this.btnBrushColor.Text = "Brush Color";
            this.btnBrushColor.UseVisualStyleBackColor = true;
            this.btnBrushColor.Click += new System.EventHandler(this.btnBrushColor_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(289, 218);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(129, 32);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 260);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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