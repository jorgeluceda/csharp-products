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
            this.ClientSize = new Size(CustomUserSettings.MainFormClientSizeWidth, CustomUserSettings.MainFormClientSizeHeight);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(CustomUserSettings.MainFormLocationX, CustomUserSettings.MainFormLocationY);
        }

        #endregion

        private void btnSaveSize_Click(object sender, EventArgs e)
        {
            CustomUserSettings.MainFormClientSizeWidth = this.ClientSize.Width;
            CustomUserSettings.MainFormClientSizeHeight = this.ClientSize.Height;
            Properties.Settings.Default.Save();
        }

        private void btnResetSettings_Click(object sender, EventArgs e)
        {
            int defaultWidth = 321;
            int defaultHeight = 300;
            int defaultX = 0;
            int defaultY = 0;

            this.ClientSize = new Size(defaultWidth, defaultHeight);
            this.DesktopLocation = new Point(defaultX, defaultY);

            CustomUserSettings.MainFormClientSizeWidth = defaultWidth;
            CustomUserSettings.MainFormClientSizeHeight = defaultHeight;
            CustomUserSettings.MainFormLocationX = defaultX;
            CustomUserSettings.MainFormLocationY = defaultY;
            Properties.Settings.Default.Save();
        }

        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            CustomUserSettings.MainFormLocationX = this.DesktopLocation.X;
            CustomUserSettings.MainFormLocationY = this.DesktopLocation.Y;
            Properties.Settings.Default.Save();
        }
    }
}
