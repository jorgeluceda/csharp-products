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
    public partial class LoginDialog : Form
    {
        public LoginDialog()
        {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void LoginDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.skipLoginCheckBox.Checked)
            {
                Properties.Settings.Default.ShowLogin = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.ShowLogin = true;
                Properties.Settings.Default.Save();

            }
        }
    }
}
