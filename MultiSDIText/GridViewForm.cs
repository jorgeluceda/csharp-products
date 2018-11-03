using MultiSDIText.Storage;
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

            InitializeManualBindings();
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
        }

        private Color? ShowColorDialog()
        {
            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                return dlg.Color;
            }

            return null;
        }

        #endregion

        private void btnColor_Click(object sender, EventArgs e)
        {
            var color = this.ShowColorDialog();

            if(color != null)
            {
                this.btnColor.BackColor = (Color)color;
            }
        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {
            var color = this.ShowColorDialog();

            if (color != null)
            {
                this.btnBackgroundColor.BackColor = (Color)color;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Font font = dlg.Font;

                var text = (Text)this.BindingManager.Current;
                text.Font = font;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var text = new Text();
            text.Content = "text";

            this.DataBindingSource.Add(text);
        }
    }
}
