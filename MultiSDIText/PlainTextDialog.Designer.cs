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
            this.components = new System.ComponentModel.Container();
            this.AddTextButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PlainTextTextBox = new System.Windows.Forms.TextBox();
            this.bsDocument = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTextButton
            // 
            this.AddTextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTextButton.Location = new System.Drawing.Point(568, 498);
            this.AddTextButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddTextButton.Name = "AddTextButton";
            this.AddTextButton.Size = new System.Drawing.Size(192, 59);
            this.AddTextButton.TabIndex = 0;
            this.AddTextButton.Text = "Add Text";
            this.AddTextButton.UseVisualStyleBackColor = true;
            this.AddTextButton.Click += new System.EventHandler(this.AddTextButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(789, 498);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(192, 59);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PlainTextTextBox
            // 
            this.PlainTextTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDocument, "Content", true));
            this.PlainTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlainTextTextBox.Location = new System.Drawing.Point(18, 19);
            this.PlainTextTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlainTextTextBox.Multiline = true;
            this.PlainTextTextBox.Name = "PlainTextTextBox";
            this.PlainTextTextBox.Size = new System.Drawing.Size(974, 446);
            this.PlainTextTextBox.TabIndex = 2;
            // 
            // bsDocument
            // 
            this.bsDocument.DataSource = typeof(MultiSDIText.Storage.Text);
            // 
            // PlainTextDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 577);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddTextButton);
            this.Controls.Add(this.PlainTextTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PlainTextDialog";
            this.Text = "PlainTextDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlainTextDialog_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTextButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox PlainTextTextBox;
        private System.Windows.Forms.BindingSource bsDocument;
    }
}