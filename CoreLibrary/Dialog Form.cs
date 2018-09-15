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
    public partial class Dialog_Form : Form
    {
        public Dialog_Form()
        {
            InitializeComponent();
            FillPanel.BackColor = BaseForm.DefaultBackColor;
        }
    }
}
