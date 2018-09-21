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
            ellipse.Show();
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rectangular rectangle = new Rectangular(this.ShapeRatio, this.ShapeHeight);
            rectangle.Show();
        }

        private void closeRectanglesToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

            // Update the properties for the dialog before it's shown
            dlg.ShapeHeight = this.ShapeHeight;
            dlg.ShapeWidth = this.ShapeWidth;
            dlg.ShapeRatio = this.ShapeRatio;

            // Open Modally
            DialogResult result = dlg.ShowDialog();

            if(result == DialogResult.OK)
            {
                this.ShapeRatio = dlg.ShapeRatio;
                this.ShapeHeight = dlg.ShapeHeight;
                this.ShapeWidth = dlg.ShapeWidth;
            }
        }

        private void openPreferencesModelesslyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferencesDialog dlg = new PreferencesDialog();

            // Update the properties for the dialog before it's shown
            dlg.ShapeHeight = this.ShapeHeight;
            dlg.ShapeWidth = this.ShapeWidth;
            dlg.ShapeRatio = this.ShapeRatio;

            // Subscribe to the dialog's Apply event
            dlg.Apply += preferences_Apply;

            // Open Modelessly
            dlg.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            TestBaseDialog dlg = new TestBaseDialog();
            dlg.Show();
        }
    }
}
