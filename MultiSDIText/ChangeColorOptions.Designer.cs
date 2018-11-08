using System.Windows.Forms;

namespace MultiSDIText
{
    partial class ChangeColorOptions
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
            this.oldColorButton = new System.Windows.Forms.Button();
            this.newColorButton = new System.Windows.Forms.Button();
            this.okOptionsButton = new System.Windows.Forms.Button();
            this.cancelOptionsButton = new System.Windows.Forms.Button();
            this.arrowTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // oldColorButton
            // 
            this.oldColorButton.Location = new System.Drawing.Point(52, 161);
            this.oldColorButton.Name = "oldColorButton";
            this.oldColorButton.Size = new System.Drawing.Size(136, 68);
            this.oldColorButton.TabIndex = 0;
            this.oldColorButton.Text = "Old Color";
            this.oldColorButton.UseVisualStyleBackColor = true;
            this.oldColorButton.Click += new System.EventHandler(this.oldColorButton_Click);
            // 
            // newColorButton
            // 
            this.newColorButton.Location = new System.Drawing.Point(274, 161);
            this.newColorButton.Name = "newColorButton";
            this.newColorButton.Size = new System.Drawing.Size(136, 68);
            this.newColorButton.TabIndex = 1;
            this.newColorButton.Text = "New Color";
            this.newColorButton.UseVisualStyleBackColor = true;
            this.newColorButton.Click += new System.EventHandler(this.newColorButton_Click);
            // 
            // okOptionsButton
            // 
            this.okOptionsButton.Location = new System.Drawing.Point(137, 298);
            this.okOptionsButton.Name = "okOptionsButton";
            this.okOptionsButton.Size = new System.Drawing.Size(138, 59);
            this.okOptionsButton.TabIndex = 2;
            this.okOptionsButton.Text = "Okay";
            this.okOptionsButton.UseVisualStyleBackColor = true;
            this.okOptionsButton.Click += new System.EventHandler(this.okOptionsButton_Click);
            // 
            // cancelOptionsButton
            // 
            this.cancelOptionsButton.Location = new System.Drawing.Point(300, 298);
            this.cancelOptionsButton.Name = "cancelOptionsButton";
            this.cancelOptionsButton.Size = new System.Drawing.Size(138, 59);
            this.cancelOptionsButton.TabIndex = 3;
            this.cancelOptionsButton.Text = "Cancel";
            this.cancelOptionsButton.UseVisualStyleBackColor = true;
            this.cancelOptionsButton.Click += new System.EventHandler(this.cancelOptionsButton_Click);
            // 
            // arrowTextBox
            // 
            this.arrowTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.arrowTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowTextBox.ForeColor = System.Drawing.Color.IndianRed;
            this.arrowTextBox.Location = new System.Drawing.Point(210, 171);
            this.arrowTextBox.Name = "arrowTextBox";
            this.arrowTextBox.ReadOnly = true;
            this.arrowTextBox.Size = new System.Drawing.Size(41, 44);
            this.arrowTextBox.TabIndex = 4;
            this.arrowTextBox.Text = "→";
            // 
            // ChangeColorOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(462, 390);
            this.Controls.Add(this.arrowTextBox);
            this.Controls.Add(this.cancelOptionsButton);
            this.Controls.Add(this.okOptionsButton);
            this.Controls.Add(this.newColorButton);
            this.Controls.Add(this.oldColorButton);
            this.MaximumSize = new System.Drawing.Size(488, 461);
            this.MinimumSize = new System.Drawing.Size(488, 461);
            this.Name = "ChangeColorOptions";
            this.Text = "ChangeColorOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button oldColorButton;
        private System.Windows.Forms.Button newColorButton;
        private System.Windows.Forms.Button okOptionsButton;
        private System.Windows.Forms.Button cancelOptionsButton;
        private TextBox arrowTextBox;
    }
}