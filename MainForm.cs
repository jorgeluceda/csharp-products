using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.ErrorProvider nameErrorProvider;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Listeners

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.CustomInitialization();
        }

        #endregion

        #region Helpers

        private void CustomInitialization()
        {
            this.ClientSize = new Size(CustomUserSettings.MainFormClientSizeWidth, CustomUserSettings.MainFormClientSizeHeight);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(CustomUserSettings.MainFormLocationX, CustomUserSettings.MainFormLocationY);

            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider();
            this.nameErrorProvider.SetIconAlignment(this.textBox1, ErrorIconAlignment.MiddleRight);
            this.nameErrorProvider.SetIconPadding(this.textBox1, 2);
            this.nameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;

            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
        }

        #endregion
        protected void textBox1_Validating(object sender,
           System.ComponentModel.CancelEventArgs e)
        {
            if (textBox1.Text == "")
                nameErrorProvider.SetError(textBox1, "Please Enter Your Name");
            else if (textBox1.Text.Length > 15)
                nameErrorProvider.SetError(textBox1, "Please Enter A Name No Longer Than 15 Characters");
            else if (textBox1.Text.Contains(" "))
                nameErrorProvider.SetError(textBox1, "Please Enter a Name Without Spaces");
            else
                nameErrorProvider.SetError(textBox1, "");
           
        }
    }
}
