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
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void btnPenColor_Click(object sender, EventArgs e)
        {
            if(this.colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                Shape shape = (Shape)this.bsShape.Current;
                shape.PenColor = this.colorDialog.Color;
            }
        }

        private void btnBrushColor_Click(object sender, EventArgs e)
        {
            if (this.colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                Shape shape = (Shape)this.bsShape.Current;
                shape.BrushColor = this.colorDialog.Color;
            }
        }
    }
}
