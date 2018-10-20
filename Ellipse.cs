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

namespace MultiSDI
{
    public partial class Ellipse : CoreLibrary.BaseForm
    {
        public Ellipse(Point location, float perm, int width)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(location.X, location.Y, width, 
                                (int)(perm * width));
            this.Region = new Region(path);
        }
    }
}