using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiSDI
{
    public partial class TopLevelForm : Form
    {
        public TopLevelForm()
        {
            InitializeComponent();
        }

        private void shapeOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapeOptions dlg = new ShapeOptions();
            dlg.Show();
        }
    }
}
