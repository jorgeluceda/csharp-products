using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreLibrary
{
    public partial class Oath: UserControl
    {
        public Oath()
        {
            InitializeComponent();
        }

        [
           Category("Appearance"),
           Browsable(true),
           Description("ContainerColor"),
           DesignerSerializationVisibility(DesignerSerializationVisibility.Content)
        ]
        public Color ContainerColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }


        private Color textColor = Color.White;
        [
           Category("Appearance"),
           Browsable(true),
           Description("TextColor"),
           DesignerSerializationVisibility(DesignerSerializationVisibility.Content)
        ]
        public Color TextColor
        {
            get { return this.textColor; }
            set
            {
                this.textColor = value;
                this.lblOath.ForeColor = this.textColor;
            }
        }

        private void TextColor_Load(object sender, EventArgs e)
        {
            if (this.Parent == null)
                return;

            /* Use background color and background image of parent control */
            this.BackColor = this.Parent.BackColor;
            this.BackgroundImage = this.Parent.BackgroundImage;
        }
    }
}
