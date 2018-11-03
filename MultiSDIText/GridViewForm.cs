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

        #region Helpers

        void InitializeManualBindings()
        {
            this.btnColor.DataBindings.Add("BackColor", this.DataBindingSource, "Color");
            this.btnBackgroundColor.DataBindings.Add("BackColor", this.DataBindingSource, "BackgroundColor");
            this.btnFont.DataBindings.Add("Font", this.DataBindingSource, "Font");
        }

        #endregion
    }
}
