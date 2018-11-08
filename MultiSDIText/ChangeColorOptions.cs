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
    public partial class ChangeColorOptions : Form
    {
        public bool closeAccept = false;
        public ChangeColorOptions()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#C9D9EB");
            this.arrowTextBox.BackColor = ColorTranslator.FromHtml("#C9D9EB");
       
        }

        private void oldColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Color backColor = dlg.Color;

                //edit current text color here;
                //this.shapeData.PenColor = penColor;

                if (backColor.GetBrightness() < 0.5)
                {
                    this.oldColorButton.ForeColor = Color.White;
                }
                else
                {
                    this.oldColorButton.ForeColor = Color.Black;
                }

                this.oldColorButton.BackColor = backColor;
            }
        }

        private void newColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Color backColor = dlg.Color;

                //edit current text color here;
                //this.shapeData.PenColor = penColor;

                if (backColor.GetBrightness() < 0.5)
                {
                    this.newColorButton.ForeColor = Color.White;
                }
                else
                {
                    this.newColorButton.ForeColor = Color.Black;
                }

                this.newColorButton.BackColor = backColor;
                this.arrowTextBox.ForeColor = backColor;
            }
        }

        private void okOptionsButton_Click(object sender, EventArgs e)
        {
            
            closeAccept = true;
            this.Close();
        }

        private void cancelOptionsButton_Click(object sender, EventArgs e)
        {
            closeAccept = false;
            this.Close();
        }
    }
}
