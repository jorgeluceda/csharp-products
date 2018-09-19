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
        List<Ellipse> ellipses = new List<Ellipse>();
        List<Rectangular> rectangles = new List<Rectangular>();


        public MainForm()
        {
            ShapeWidth = Properties.Settings.Default.DefaultWidth;
            ShapeHeight = Properties.Settings.Default.DefaultHeight;
            ShapeRatio = Properties.Settings.Default.DefaultRatio;

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
            ellipses.Add(ellipse);
            ellipse.Show();
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rectangular rectangle = new Rectangular(this.ShapeRatio, this.ShapeHeight);
            rectangles.Add(rectangle);
            rectangle.Show();
        }

        private void closeRectanglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Rectangular rect in rectangles)
            {
                rect.Close();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", 
                "Closing Application", MessageBoxButtons.YesNo);

            if(result == DialogResult.No)
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
            PreferencesDialog dlg = new PreferencesDialog();
            dlg.Apply += preferences_Apply;
            dlg.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ellipsesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach(Ellipse elip in ellipses)
            {
                elip.Close();
            }

        }

        private void openModallyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PreferencesDialog dlg = new PreferencesDialog();
            dlg.Apply += preferences_Apply;
            dlg.ShowDialog(this);

        }

        private void openModelesslyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferencesDialog dlg = new PreferencesDialog();
            dlg.Apply += preferences_Apply;
            dlg.Show(this);
        }

        private void openPreferencesModelesslyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferencesDialog dlg = new PreferencesDialog();
            dlg.Apply += preferences_Apply;
            dlg.Show(this);
        }
    }
}
