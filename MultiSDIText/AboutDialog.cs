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
    public partial class aboutDialog : BaseDialogForm
    {
        public aboutDialog()
        {
            InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //Creating the LinearGradientBrush to be use
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.OrangeRed, Color.SeaGreen, LinearGradientMode.ForwardDiagonal)) {
                ColorBlend blend = new ColorBlend();
                blend.Colors = new Color[] { Color.SeaGreen, Color.RoyalBlue, Color.YellowGreen };
                blend.Positions = new float[] { 0.0f, 0.5f, 1.0f };
                brush.InterpolationColors = blend;
                Pen pen = new Pen(brush, 30.0f);
                e.Graphics.FillRectangle(new SolidBrush(Color.LightSteelBlue), this.ClientRectangle);
                e.Graphics.DrawRectangle(pen, this.ClientRectangle);
            }
        }
    }
}
