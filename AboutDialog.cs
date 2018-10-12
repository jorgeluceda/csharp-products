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

namespace SingleDocumentInterface
{
    public partial class AboutDialog : BaseDialogForm
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //Creating the LinearGradientBrush to be use
            ColorBlend blend = new ColorBlend();
            blend.Colors = new Color[] { Color.OrangeRed, Color.SkyBlue, Color.SeaGreen };
            blend.Positions = new float[] { 0.0f, 0.5f, 1.0f };
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.OrangeRed, Color.SeaGreen, LinearGradientMode.ForwardDiagonal);
            brush.InterpolationColors = blend;
            Pen pen = new Pen(brush, 20.0f);
            e.Graphics.FillRectangle(new SolidBrush(Color.Azure), this.ClientRectangle);
            e.Graphics.DrawRectangle(pen, this.ClientRectangle);
        }

    }
}
