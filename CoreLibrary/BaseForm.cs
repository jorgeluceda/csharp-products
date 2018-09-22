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
        Point downPoint = Point.Empty;

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

        /*
         *  The following three event handlers implement drag and click functionality on our BaseForm.
         *  Implementation is taken straight from the book.
         */
        private void BaseForm_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left) return;   // If the event is not a left mousen click event, exit
            downPoint = new Point(e.X, e.Y);            // Store the X, Y coordinates of the event
        }
        
        private void BaseForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty) return;       // Check for empty downPoint (anomaly case)

            // Store new location of the mouse. One way to calculate it is to add the Left coordinate of the BaseForm (this)
            // to the event's X coordinate (where the mouse currently is, remember, this is the MouseMove event)
            Point location = new Point(this.Left + e.X - downPoint.X, this.Top + e.Y - downPoint.Y);    
            this.Location = location;
        }

        private void BaseForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            downPoint = Point.Empty;
        }
    }
}
