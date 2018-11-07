using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiSDIText
{
    public partial class ImageWindow : Form
    {
        private String fileName;
        Point clickedPoint;

        public String FileName
        {
            get { return this.fileName; }
            set { this.fileName = value; }
        }

        public ImageWindow()
        {
            InitializeComponent();
        }

        private void ImageWindow_Load(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Bitmap image = new Bitmap(@"" + this.FileName))
            {
                g.DrawImage(image, new Point(0, 0));
            }
        }

        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            Point clickPoint = control.PointToScreen(new Point(e.X, e.Y));
            Point formPoint = PointToClient(clickPoint);
        }
    }
}
