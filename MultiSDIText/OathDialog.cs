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

namespace TextMDI
{
    public partial class oathDialog : BaseDialogForm
    {
        public oathDialog()
        {
            InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //Creating the PathGradientBrush to fill the background color of the Oath Dialog
            Point[] diamondPoints = new Point[] {   new Point(30,0),
                                                    new Point(60,60),
                                                    new Point(0,20),
                                                    new Point(60,20),
                                                    new Point(0,60),
                                                    new Point(30,0)};
            using (PathGradientBrush brush = new PathGradientBrush(diamondPoints))
            {
                Color[] colors = { Color.LightSteelBlue, Color.SkyBlue };
                brush.CenterColor = Color.LightSlateGray;
                brush.SurroundColors = colors;
                brush.WrapMode = WrapMode.Tile;
                //So the background of the gradient would not be black
                e.Graphics.FillRectangle(new SolidBrush(Color.PaleGoldenrod), this.ClientRectangle);
                //Filling the client area with the PathGradientBrush
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
