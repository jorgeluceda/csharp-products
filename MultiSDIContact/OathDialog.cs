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

namespace MultiSDIContact
{
    public partial class oathDialog : Form
    {
        public oathDialog()
        {
            InitializeComponent();
        }

        //For drawing a background
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //Creating the LinearGradientBrush to be use
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Blue, Color.White, LinearGradientMode.Vertical))
            {
                ColorBlend blend = new ColorBlend();
                blend.Colors = new Color[] { Color.Blue, Color.Snow, Color.Purple };
                blend.Positions = new float[] { 0.0f, 0.5f, 1.0f };
                brush.InterpolationColors = blend;
                Pen pen = new Pen(brush, 30.0f);
                e.Graphics.FillRectangle(new SolidBrush(Color.LightBlue), this.ClientRectangle);
                e.Graphics.DrawRectangle(pen, this.ClientRectangle);
            }
        }
    }
}
