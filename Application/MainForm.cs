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

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ellipse ellipse = new Ellipse();
        }

        private void openModelesslyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferencesDialog dlg = new PreferencesDialog();
            dlg.Apply += preferences_Apply;
            dlg.Show();
        }

        void preferences_Apply(object sender, EventArgs e)
        {
            ITeam3Interface preferencesDlg = sender as ITeam3Interface;
            this.ShapeWidth = preferencesDlg.ShapeWidth;
            this.ShapeHeight = preferencesDlg.ShapeHeight;
            this.ShapeRatio = preferencesDlg.ShapeRatio;
        }
    }
}
