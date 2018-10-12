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
    public partial class BaseDialogForm : Form
    {
        public BaseDialogForm()
        {
            InitializeComponent();
            this.middlePanel.BackColor = this.BackColor;                // Middle panel should show background color of parent
            this.middlePanel.BackgroundImage = this.BackgroundImage;    // Middle panel should show background image of parent
        }
    }
}
