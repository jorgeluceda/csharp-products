using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreLibrary
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BackgroundColor.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = BackgroundColor.Color;
            }
        }
    }
}
