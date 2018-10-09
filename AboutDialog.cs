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
    public partial class AboutDialog : BaseDialogForm
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        //Method to change the border rectangle of the client
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //Creating the LinearGradientBrush to be use
            ColorBlend blend = new ColorBlend();
            blend.Colors = new Color[] { Color.OrangeRed, Color.SkyBlue, Color.SeaGreen };
            blend.Positions = new float[] { 0.0f, 0.5f, 1.0f };
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.OrangeRed, Color.SeaGreen, LinearGradientMode.Horizontal);
            brush.InterpolationColors = blend;
            Pen pen = new Pen(brush);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
    }
}
