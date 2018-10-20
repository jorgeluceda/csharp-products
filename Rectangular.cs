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

namespace SingleDocumentInterface
{
    public partial class Rectangular : BaseForm
    {
        public Rectangular(Point location, float perm, int height)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(location.X, location.Y, height, (int)perm * height);
            path.AddRectangle(rect);
            this.Region = new Region(path);
        }
    }
}