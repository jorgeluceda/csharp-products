using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MultiSDIText.Storage;

namespace MultiSDIText
{
    public partial class TextOptions : Form, IBindingSource 
    {
        /* Supposed to use the document inside toplevelform */
        List<Text> textDoc = new List<Text>();
        

        public BindingSource DataBindingSource
        {
            get { return this.bsDocument; }
            set { this.bsDocument = value; }
        }
        /*
        BindingManagerBase BindingManager
        {
        
            get {
                return this.BindingContext[this.bsDocument];
            }
        }
        */

        public TextOptions()
        {
            InitializeComponent();

            radioButtonDefault.Checked = true;
            this.listBoxDoc.DisplayMember = "Content";

            RefreshItems();
        }

        void RefreshItems()
        {
            int count = this.DataBindingSource.Count;
            int pos = this.DataBindingSource.Position + 1;

            this.labelCount.Text = count.ToString();
            this.labelPosition.Text = pos.ToString();

            this.buttonFirst.Enabled = (pos > 1);
            this.buttonPrev.Enabled = (pos > 1);
            this.buttonNext.Enabled = (pos < count);
            this.buttonLast.Enabled = (pos < count);
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            this.DataBindingSource.Position = 0;
            RefreshItems();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            --this.DataBindingSource.Position;
            RefreshItems();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            ++this.DataBindingSource.Position;
            RefreshItems();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            this.DataBindingSource.Position = this.DataBindingSource.Count - 1;
            RefreshItems();
        }

        private void radioButtonDefault_CheckedChanged(object sender, EventArgs e)
        {
            listBoxDoc.DisplayMember = "";
        }

        private void radioButtonName_CheckedChanged(object sender, EventArgs e)
        {
            listBoxDoc.DisplayMember = "Content";
        }

        private void radioButtonZOrder_CheckedChanged(object sender, EventArgs e)
        {
            listBoxDoc.DisplayMember = "Location";
        }
    }
}