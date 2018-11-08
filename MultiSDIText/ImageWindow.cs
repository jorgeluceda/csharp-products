using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        ChangeColorOptions colorChange = new ChangeColorOptions();

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
        

        private void imgPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Bitmap bmp = new Bitmap(@"" + this.fileName))
            {
                //Code taken from example Image code given in video lecture
                // Set the image attribute's color mappings
                ColorMap[] colorMap = new ColorMap[1];
                colorMap[0] = new ColorMap();
                //
                colorMap[0].OldColor = this.colorChange.oldColorButton.BackColor;
                //colorMap[0].OldColor = Color.Blue;
                //colorMap[0].NewColor = Color.Red;
                colorMap[0].NewColor = this.colorChange.newColorButton.BackColor;
                ImageAttributes attr = new ImageAttributes();
                attr.SetRemapTable(colorMap);
                // Draw using the color map
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                g.DrawImage(bmp, rect, 0, 0, rect.Width, rect.Height, GraphicsUnit.Pixel, attr);
            }


        }
        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            Point clickPoint = control.PointToScreen(new Point(e.X, e.Y));
            Point formPoint = PointToClient(clickPoint);
        }

        private void saveViewAsImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColorOptions colorChange = new ChangeColorOptions();

            if (colorChange.ShowDialog() == DialogResult.OK)
            {
                    this.Invalidate();
            }

        }
    }
}
