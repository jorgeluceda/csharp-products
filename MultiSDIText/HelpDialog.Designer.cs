namespace MultiSDIText
{
    partial class HelpDialog
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.helpFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(13, 22);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.Text = "Search Term";
            this.searchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyUp_1);
            // 
            // helpFlowLayoutPanel
            // 
            this.helpFlowLayoutPanel.AutoScroll = true;
            this.helpFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.helpFlowLayoutPanel.Location = new System.Drawing.Point(13, 60);
            this.helpFlowLayoutPanel.Name = "helpFlowLayoutPanel";
            this.helpFlowLayoutPanel.Size = new System.Drawing.Size(177, 160);
            this.helpFlowLayoutPanel.TabIndex = 1;
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.resultTextBox.Location = new System.Drawing.Point(197, 60);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(246, 160);
            this.resultTextBox.TabIndex = 2;
            // 
            // HelpDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 232);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.helpFlowLayoutPanel);
            this.Controls.Add(this.searchTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpDialog";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.HelpDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.FlowLayoutPanel helpFlowLayoutPanel;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}