namespace MultiSDIText
{
    partial class PlainTextDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlainTextDialog));
            this.AddTextButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PlainTextTextBox = new System.Windows.Forms.TextBox();
            this.plainTextToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.plainTextToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddTextButton
            // 
            this.AddTextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTextButton.Location = new System.Drawing.Point(378, 319);
            this.AddTextButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddTextButton.Name = "AddTextButton";
            this.AddTextButton.Size = new System.Drawing.Size(128, 38);
            this.AddTextButton.TabIndex = 0;
            this.AddTextButton.Text = "Add Text";
            this.AddTextButton.UseVisualStyleBackColor = true;
            this.AddTextButton.Click += new System.EventHandler(this.AddTextButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(526, 319);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(128, 38);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PlainTextTextBox
            // 
            this.PlainTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlainTextTextBox.Location = new System.Drawing.Point(12, 40);
            this.PlainTextTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PlainTextTextBox.Multiline = true;
            this.PlainTextTextBox.Name = "PlainTextTextBox";
            this.PlainTextTextBox.Size = new System.Drawing.Size(650, 259);
            this.PlainTextTextBox.TabIndex = 2;
            // 
            // plainTextToolStrip
            // 
            this.plainTextToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.plainTextToolStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.plainTextToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1});
            this.plainTextToolStrip.Location = new System.Drawing.Point(0, 0);
            this.plainTextToolStrip.Name = "plainTextToolStrip";
            this.plainTextToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.plainTextToolStrip.Size = new System.Drawing.Size(674, 25);
            this.plainTextToolStrip.TabIndex = 3;
            this.plainTextToolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // PlainTextDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 369);
            this.Controls.Add(this.plainTextToolStrip);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddTextButton);
            this.Controls.Add(this.PlainTextTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "PlainTextDialog";
            this.Text = "PlainTextDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlainTextDialog_FormClosing);
            this.plainTextToolStrip.ResumeLayout(false);
            this.plainTextToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTextButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ToolStrip plainTextToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        public System.Windows.Forms.TextBox PlainTextTextBox;
    }
}