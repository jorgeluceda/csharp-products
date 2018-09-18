using CoreLibrary;

namespace Application
{
    partial class TestingForm: BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /*protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            base.SuspendLayout();
            // 
            // TestingForm
            // 
            base.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new System.Drawing.Size(284, 261);
            base.Name = "TestingForm";
            base.Text = "TestingForm";
            base.Load += new System.EventHandler(this.TestingForm_Load);
            base.ResumeLayout(false);

        }

        #endregion
    }
}