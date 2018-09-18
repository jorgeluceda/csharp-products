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
        public Rectangular(float perm, int width)
        {
            InitializeComponent();
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, width, (int)perm*width);
            path.AddRectangle(rect);
            this.Region = new Region(path);
        }
    }
}
