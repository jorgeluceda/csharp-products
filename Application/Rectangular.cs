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

namespace Application
{
    public partial class Rectangular : Form, BaseForm
    {
        public Rectangular(float perm, int width)
        {
            InitializeComponent();
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle();
            rect.Height = width * (int)perm;
            rect.Width = rect.Width * rect.Height;
            path.AddRectangle(rect);
            Region region = new Region(path);
            this.Region = region;

        }
    }
}
