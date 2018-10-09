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
using CoreLibrary;



namespace SingleDocumentInterface
{
    public partial class OathDialog : BaseDialogForm
    {
        public OathDialog()
        {
            InitializeComponent();
        }

        //Method to change the backgorund of the form
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //Creating the diamond points to be use by the brush
            Point[] diamondPoints = new Point[] { new Point(Width / 16, 0),
                                              new Point(0, Height / 12),
                                              new Point (Width / 16, Height / 6),
                                              new Point (Width / 8, Height / 12)};
            //Creating the PathGradientBrush to fill the background color of the Oath Dialog
            using (PathGradientBrush brush = new PathGradientBrush(diamondPoints))
            {
                Color[] colors = { Color.Blue, Color.Purple, Color.Red };
                brush.CenterColor = Color.Azure;
                brush.SurroundColors = colors;
                brush.WrapMode = WrapMode.TileFlipXY;
                //So the background of the gradient would not be black
                e.Graphics.FillRectangle(new SolidBrush(Color.Orange), this.ClientRectangle);
                //Filling the client area with the PathGradientBrush
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
