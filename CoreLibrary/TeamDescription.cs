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
    public partial class TeamDescription: UserControl
    {
        public TeamDescription()
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
                this.lblTeamNumber.ForeColor = this.textColor;
                this.teamMembers.ForeColor = this.textColor;
                this.alejandro.ForeColor = this.textColor;
                this.darien.ForeColor = this.textColor;
                this.emmanuel.ForeColor = this.textColor;
                this.jorge.ForeColor = this.textColor;
                this.mohammed.ForeColor = this.textColor;
            }
        }
    }
}
