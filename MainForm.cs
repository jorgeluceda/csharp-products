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
            this.Text = "Application";
            this.ClientSize = new Size(CustomUserSettings.MainFormClientSizeWidth, CustomUserSettings.MainFormClientSizeHeight);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(CustomUserSettings.MainFormLocationX, CustomUserSettings.MainFormLocationY);
        }

        #endregion
    }
}
