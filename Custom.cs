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
    public partial class Custom : CoreLibrary.BaseForm
    {
        public Custom(Point point, float perm, int width)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(point.X, point.Y, width, (int)(perm * width));

            Rectangle rect = new Rectangle(point.X, point.Y, width, (int)(perm * width));
            path.AddRectangle(rect);
       
            this.Region = new Region(path);
        }
    }
}