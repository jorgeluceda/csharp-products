using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using CoreLibrary;

namespace Application
{
    public partial class Rectangular : BaseForm
    {
        public Rectangular(float perm, int height)
        {
            InitializeComponent();
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, height, (int)perm*height);
            path.AddRectangle(rect);
            this.Region = new Region(path);
        }

        private void Rectangular_Activated(object sender, EventArgs e)
        {

        }
    }
}
