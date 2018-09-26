using CoreLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application
{
    public partial class CustomForm : BaseForm
    {
        public CustomForm()
        {
            InitializeComponent();
        }

        public CustomForm(float firstParameter, int secondParameter)
        {
            InitializeComponent();
            InitializeShapes( firstParameter,  secondParameter);
        }

        public void InitializeShapes(float ratio, int totalWidth)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, totalWidth, (int)(ratio * totalWidth));

            Rectangle rect = new Rectangle(0, 0, totalWidth, (int)ratio * totalWidth);
            path.AddRectangle(rect);

            this.Region = new Region(path);
        }

    }
}
