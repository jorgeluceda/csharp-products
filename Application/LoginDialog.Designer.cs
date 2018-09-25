namespace Application
{
    partial class LoginDialog
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
            this.loginMessage = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.skipLoginCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // loginMessage
            // 
            this.loginMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginMessage.Location = new System.Drawing.Point(0, 0);
            this.loginMessage.Name = "loginMessage";
            this.loginMessage.Size = new System.Drawing.Size(442, 315);
            this.loginMessage.TabIndex = 0;
            this.loginMessage.Text = "WARNING! You are about to see top secret information.\r\nAfter seeing the contents " +
    "of this application, your life\r\ncould be in danger! Proceed at your own risk. Wo" +
    "uld you\r\nlike to continue?\r\n";
            this.loginMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yesButton
            // 
            this.yesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.yesButton.Location = new System.Drawing.Point(111, 217);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(75, 35);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.noButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.noButton.Location = new System.Drawing.Point(254, 217);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(75, 35);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // skipLoginCheckBox
            // 
            this.skipLoginCheckBox.AutoSize = true;
            this.skipLoginCheckBox.Location = new System.Drawing.Point(111, 269);
            this.skipLoginCheckBox.Name = "skipLoginCheckBox";
            this.skipLoginCheckBox.Size = new System.Drawing.Size(218, 21);
            this.skipLoginCheckBox.TabIndex = 3;
            this.skipLoginCheckBox.Text = "Skip this screen in the future?";
            this.skipLoginCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginDialog
            // 
            this.AcceptButton = this.yesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.noButton;
            this.ClientSize = new System.Drawing.Size(442, 315);
            this.Controls.Add(this.skipLoginCheckBox);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.loginMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginDialog";
            this.ShowIcon = false;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginDialog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginMessage;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        public System.Windows.Forms.CheckBox skipLoginCheckBox;
    }
}