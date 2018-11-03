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

            RefreshItems();
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
            this.txtContent.DataBindings.Add("Text", this.DataBindingSource, "Content");
            this.btnColor.DataBindings.Add("BackColor", this.DataBindingSource, "Color");
            this.btnBackgroundColor.DataBindings.Add("BackColor", this.DataBindingSource, "BackgroundColor");
            this.txtZOrder.DataBindings.Add("Text", this.DataBindingSource, "ZOrder");
            this.txtLocation.DataBindings.Add("Text", this.DataBindingSource, "Location");
            this.txtRotation.DataBindings.Add("Text", this.DataBindingSource, "Rotation");
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

        void RefreshItems()
        {
            this.btnDelete.Enabled = this.BindingManager.Count > 0;
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
            text.Color = Color.Blue;

            this.DataBindingSource.Add(text);
            RefreshItems();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.DataBindingSource.Remove((Text)this.BindingManager.Current);
            RefreshItems();
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            int[] textMatches = new int[0];

            try {
                textMatches = Array.ConvertAll<string, int>(this.txtLocation.Text.Split(','), Convert.ToInt32);
            }
            catch (FormatException) {
                this.gridViewErrorProvider.SetError(this.txtLocation, "Please, enter a valid pair of coordinates: X, Y");
            }

            if (this.txtLocation.Text == null || textMatches.Count() < 2 || textMatches.Count() > 2)
            {
                this.gridViewErrorProvider.SetError(this.txtLocation, "Please, enter a valid pair of coordinates: X, Y");
            }
        }
    }
}
