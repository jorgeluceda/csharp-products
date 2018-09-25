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
    public partial class MainForm : Form, ITeam3Interface
    {
        public int ShapeWidth { get; set; }
        public int ShapeHeight { get; set; }
        public float ShapeRatio { get; set; }
        public event EventHandler Apply;
        public Color ellipseColor;
        public Color rectangleColor;
        public Color customColor;
        private Ellipse ellipsetest;

        public bool ShowLogin
        {
            get
            {
                return Properties.Settings.Default.ShowLogin;
            }
            set
            {
                Properties.Settings.Default.ShowLogin = value;
                Properties.Settings.Default.Save();
            }
        }

        private PreferencesDialog preferencesDialog = null;


        public MainForm()
        {
            InitializeComponent();
        }

        void preferences_Apply(object sender, EventArgs e)
        {
            ITeam3Interface preferencesDlg = sender as ITeam3Interface;
            this.ShapeWidth = preferencesDlg.ShapeWidth;
            this.ShapeHeight = preferencesDlg.ShapeHeight;
            this.ShapeRatio = preferencesDlg.ShapeRatio;
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ellipse ellipse = new Ellipse(this.ShapeRatio, this.ShapeWidth);
            ellipse.MdiParent = this;
            ellipseColor = ellipse.BackColor;
            ellipse.Activated += ellipseActivatedHandler;
            ellipse.Show();
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rectangular rectangle = new Rectangular(this.ShapeRatio, this.ShapeHeight);
            rectangle.MdiParent = this;
            rectangleColor = rectangle.BackColor;
            rectangle.Activated += rectangleActivatedHandler;
            rectangle.Show();
        }

        private void closeRectanglesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?",
                "Closing Application", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openPreferencesModallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.preferencesDialog = new PreferencesDialog();

            // Update the properties for the dialog before it's shown
            this.preferencesDialog.ShapeHeight = this.ShapeHeight;
            this.preferencesDialog.ShapeWidth = this.ShapeWidth;
            this.preferencesDialog.ShapeRatio = this.ShapeRatio;

            // Open Modally
            DialogResult result = this.preferencesDialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                this.ShapeRatio = this.preferencesDialog.ShapeRatio;
                this.ShapeHeight = this.preferencesDialog.ShapeHeight;
                this.ShapeWidth = this.preferencesDialog.ShapeWidth;
            }
        }

        private void openPreferencesModelesslyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.preferencesDialog = new PreferencesDialog();

            // Update the properties for the dialog before it's shown
            this.preferencesDialog.ShapeHeight = this.ShapeHeight;
            this.preferencesDialog.ShapeWidth = this.ShapeWidth;
            this.preferencesDialog.ShapeRatio = this.ShapeRatio;

            // Subscribe to the dialog's Apply event
            this.preferencesDialog.Apply += preferences_Apply;

            // Open Modelessly
            this.preferencesDialog.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutDialog dlg = new AboutDialog();
            dlg.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OathDialog dlg = new OathDialog();
            dlg.Show();
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            if (this.preferencesDialog != null)
            {
                this.preferencesDialog.Opacity = 0.5;
            }

        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (this.preferencesDialog != null)
            {
               // this.preferencesDialog.Opacity = 1;
            }
        }

        private void showLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowLogin = true;
        }

        private void hideLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowLogin = false;
        }

        //Oath Menu item
        private void helpMenuOath_Click(object sender, EventArgs e)
        {
            OathDialog oathDlg = new OathDialog();
            oathDlg.Location = new Point (this.Location.X + this.ClientSize.Width, this.Location.Y);    //Position of the dialog for start up
            oathDlg.StartPosition = FormStartPosition.Manual;
            oathDlg.ShowDialog();
            this.AddOwnedForm(oathDlg);
        }

        //About Menu item
        AboutDialog aboutDlg;
        private void helpMenuAbout_Click(object sender, EventArgs e)
        {
            //To allow one About form to display.
            if (!this.OwnedForms.Contains(aboutDlg)) {
                aboutDlg = new AboutDialog();
                aboutDlg.Location = new Point(this.Location.X, this.Location.Y + this.Height);    //Position of the dialog for start up, GOES TOO LOW
                aboutDlg.StartPosition = FormStartPosition.Manual;
                aboutDlg.Show();
                this.AddOwnedForm(aboutDlg);
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        void ellipseActivatedHandler(object sender, EventArgs e)
        {
            StatusLabel.Text = "Ellipse";
            StatusLabel.BackColor = this.ActiveMdiChild.BackColor;
        }

        private void closeAllChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChildForm in MdiChildren)
            {
                mdiChildForm.Close();
            }
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomForm custom = new CustomForm(this.ShapeRatio, this.ShapeWidth);
            custom.MdiParent = this;
            customColor = custom.BackColor;
            custom.Activated += customActivatedHandler;
            custom.Show();
        }

        void rectangleActivatedHandler(object sender, EventArgs e)
        {
            StatusLabel.Text = "Rectangle";
            StatusLabel.BackColor = this.ActiveMdiChild.BackColor;

        }
        
        void customActivatedHandler(object sender, EventArgs e)
        {
            StatusLabel.Text = "Custom";
            StatusLabel.BackColor = this.ActiveMdiChild.BackColor;
        }
    }
}
