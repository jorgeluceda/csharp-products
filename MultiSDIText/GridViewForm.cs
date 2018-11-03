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
    public partial class GridViewForm : Form, IBindingSource
    {
        public GridViewForm()
        {
            InitializeComponent();
        }

        public BindingSource DataBindingSource
        {
            get { return this.documentBindingSource; }
            set { this.documentBindingSource = value; }
        }

        BindingManagerBase BindingManager
        {

            get
            {
                return this.BindingContext[this.documentBindingSource];
            }
        }
    }
}
