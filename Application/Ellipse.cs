using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreLibrary;
using System.Drawing.Drawing2D;

namespace Application
{
    public partial class Ellipse : CoreLibrary.BaseForm
    {
        public Ellipse(float perm, int width)
        {
            InitializeComponent();
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, width, (int)(perm * width));
            this.Region = new Region(path);
        }
    }
}
