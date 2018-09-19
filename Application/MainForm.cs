using Application;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /*
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

            Form preferences = new PreferencesDialog();
            preferences.Show();

        }

        */
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Paint += MainForm_Paint;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form preferences = new PreferencesDialog();
            preferences.Show();
            //OnPaint();
            this.Invalidate();


        }

      

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {



            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Blue, 5);
            g.DrawRectangle(pen, new Rectangle(150,150,100,200) );
            //g.Dispose();
            this.Invalidate();

          /*  g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rec = this.ClientRectangle;
            int cx = rec.Width;
            int cy = rec.Height;
            float scale = (float)cy / (float)cx;

            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Empty, Color.Empty, 45);

            try
            {

                ColorBlend blend = new ColorBlend();
                blend.Colors = new Color[] { Color.Red, Color.Green, Color.Blue };

                blend.Positions = new float[] { 0, 0.5f, 1 };

                brush.InterpolationColors = blend;
                Pen pen = new Pen(brush);

                try
                {
                    for (int i = 0; i < cx; i+=7)
                    {
                        g.DrawLine(pen, 0, i*scale, cx - i, 0);
                        g.DrawLine(pen, 0, (cx -i) * scale, cx - i, cx * scale);
                        g.DrawLine(pen, cx - i, 0 * scale, cx, (cx - i)  * scale);
                        g.DrawLine(pen, cx - i, cx * scale, cx, i * scale);

                    }
                }
                finally
                {
                    pen.Dispose();
                }

                StringFormat format = new StringFormat();

                try
                {
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;
                    String s = "It works!";
                    g.DrawString(s, this.Font, brush, rec, format);
                }
                finally
                {
                    format.Dispose();
                }

            }
            finally
            {
                brush.Dispose();
            }*/
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
