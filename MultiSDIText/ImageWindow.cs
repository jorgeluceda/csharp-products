using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiSDIText
{
    public partial class ImageWindow : Form
    {
        private String fileName;
        Color oldColor = Color.Black;
        Color newColor = Color.Black;
        Bitmap bmp;

        int bmpWidth;
        int bmpHeight;

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
            //make width and height slightly biggee than image
            bmp = new Bitmap(@"" + this.fileName);
            bmpWidth = bmp.Width + 100;
            bmpHeight = bmp.Height + 100;
            this.MinimumSize = new Size(new Point(bmpWidth, bmpHeight)); this.MinimumSize = new Size(new Point(bmpWidth, bmpHeight));
            this.MaximumSize = new Size(new Point(bmpWidth, bmpHeight)); this.MinimumSize = new Size(new Point(bmpWidth, bmpHeight));
            this.Width = bmpWidth;
            this.Height = bmpHeight;
        }
        

        private void imgPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            using (bmp)
            {
                //Code taken from example Image code given in video lecture
                // Set the image attribute's color mappings
                ColorMap[] colorMap = new ColorMap[1];
                colorMap[0] = new ColorMap();
                
                colorMap[0].OldColor = oldColor;
                colorMap[0].NewColor = newColor;
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
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "PNG Files (*.png) | *.png | JPEG Files (*.jpeg) | *.jpeg | Bitmap Files (*.bmp) | *.bmp";
            dlg.AddExtension = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var extension = Path.GetExtension(dlg.FileName);

                Console.WriteLine(extension);

                if (extension == ".jpeg")
                {
                    SaveImage(dlg.FileName, ImageFormat.Jpeg);
                }
                else if (extension == ".bmp")
                {
                    SaveImage(dlg.FileName, ImageFormat.Bmp);
                }
                else
                {
                    SaveImage(dlg.FileName, ImageFormat.Png);
                }
            }
        }


        private void SaveImage(String fileName, ImageFormat format)
        {
            Rectangle rect = new Rectangle(this.imgPictureBox.ClientRectangle.X, this.imgPictureBox.ClientRectangle.Y,
                this.imgPictureBox.Width, this.imgPictureBox.Height);


            Bitmap image = new Bitmap(this.Width, this.Height);
            this.imgPictureBox.DrawToBitmap(image, rect);

            image.Save(fileName, format);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColorOptions colorChange = new ChangeColorOptions();

            colorChange.ShowDialog();
            if(colorChange.closeAccept == true)
            {
                this.oldColor = colorChange.oldColorButton.BackColor;
                this.newColor = colorChange.newColorButton.BackColor;
                this.imgPictureBox.Invalidate();
            }

        }
    }
}
