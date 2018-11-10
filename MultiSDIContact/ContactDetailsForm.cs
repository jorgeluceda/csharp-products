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
    public partial class ContactDetailsForm : Form
    {
        #region Variables

        #endregion

        #region Contructor
        public ContactDetailsForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Drawing Background

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //Creating the LinearGradientBrush to be use
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.OrangeRed, Color.SeaGreen, LinearGradientMode.ForwardDiagonal))
            {
                ColorBlend blend = new ColorBlend();
                blend.Colors = new Color[] { Color.Red, Color.Orange, Color.Yellow };
                blend.Positions = new float[] { 0.0f, 0.5f, 1.0f };
                brush.InterpolationColors = blend;
                Pen pen = new Pen(brush, 30.0f);
                e.Graphics.FillRectangle(new SolidBrush(Color.LightSteelBlue), this.ClientRectangle);
                e.Graphics.DrawRectangle(pen, this.ClientRectangle);
            }
        }
        #endregion

    }
}
