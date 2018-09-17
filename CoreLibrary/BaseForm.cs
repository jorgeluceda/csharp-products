using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreLibrary
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        //Closing with File
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Colors
        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BackgroundColor.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = BackgroundColor.Color;
            }
        }

        //Dragging
        private Point mouseDownLocation;    //to save original position where mouse was clicked so that it does not
                                            //cause the MouseMove to go crazy with where the mouse is position.
        private void BaseForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
        }
        //For moving the form in client area
        private void BaseForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X + this.Left - mouseDownLocation.X;
                this.Top = e.Y + this.Top - mouseDownLocation.Y;

            }
        }
    }
}
