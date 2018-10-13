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
    public partial class BaseMainForm : Form
    {
        public BaseMainForm()
        {
            InitializeComponent();
        }

        virtual public void smiOath_Click(object sender, EventArgs e)
        {
            throw new NotSupportedException("The Oath menu item is not implemented");
        }

        private void smiAbout_Click(object sender, EventArgs e)
        {
            throw new NotSupportedException("The About menu item is not implemented");
        }
    }
}
