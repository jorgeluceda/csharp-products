using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiSDI
{
    public partial class ShapeOptions : Form
    {
        public ShapeOptions()
        {
            InitializeComponent();
        }

        #region Options

        private void penColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Color penColor = dlg.Color;                 // Get pen color from dialog

                // Check if pen color user picks is light/dark, set button's ForeColor appropriately
                if (penColor.GetBrightness() < 0.5)
                {
                    this.penColorButton.ForeColor = Color.White;
                }
                else
                {
                    this.penColorButton.ForeColor = Color.Black;
                }

                this.penColorButton.BackColor = penColor;   // Change the color of the penColorButton

                // Set pen color in Shape object TODO
            }
        }

        private void brushColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Color brushColor = dlg.Color;                 // Get pen color from dialog

                // Check if pen color user picks is light/dark, set button's ForeColor appropriately
                if (brushColor.GetBrightness() < 0.5)
                {
                    this.brushColorButton.ForeColor = Color.White;
                }
                else
                {
                    this.brushColorButton.ForeColor = Color.Black;
                }

                this.brushColorButton.BackColor = brushColor;   // Change the color of the penColorButton

                // Set pen color in Shape object TODO
            }
        }

        #endregion

        #region Cancel/OK Buttons

        private void okButton_Click(object sender, EventArgs e)
        {
            // Handle Data Exchange here, set properties on Shape
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        
    }
}
