using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiSDIText;
using MultiSDIText.Storage;

namespace MultiSDIText
{
    public partial class PlainTextDialog : Form
    {
        public Document plainTextDoc;
        public bool closeAccept = false;


        public PlainTextDialog()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            closeAccept = false;
            this.Close();
        }

        private void AddTextButton_Click(object sender, EventArgs e)
        {
            plainTextDoc = new Document(PlainTextTextBox.Text);
            closeAccept = true;
            this.Close();
        }

        private void PlainTextDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeAccept == false)
            {
                if (!String.IsNullOrEmpty(this.PlainTextTextBox.Text) || !String.IsNullOrWhiteSpace(this.PlainTextTextBox.Text))
                {
                    DialogResult result = MessageBox.Show("There's some text in the window, are you sure you'd" +
                        "like to close?", "Text Present", MessageBoxButtons.YesNo);

                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }

        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            PlainTextTextBox.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            PlainTextTextBox.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            PlainTextTextBox.Paste();
        }
    }
}
