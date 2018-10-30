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
        public Document plainTextDoc = new Document();
        public bool closeAccept = false;


        public PlainTextDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets a string and returns an array of Text object representing each word.
        /// </summary>
        /// <param name="p">The string to split into words</param>
        /// <returns>An array of words as Text object</returns>
        public BindingList<Text> TurnIntoTextObjects(String s)
        {
            String[] words = Regex.Split(s, "\\s+");
            BindingList<Text> texts = new BindingList<Text>();

            int locationx = 50;
            int locationy = 50;
            for (int i = 0; i < words.Length; i++)
            {
                Text text = new Text();
                text.Content = words[i];
                text.Location = new Point(locationx, locationy);
                locationx += 30;
                locationy += 30;
                texts.Add(text);
            }
            return texts;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            closeAccept = false;
            this.Close();
        }

        private void AddTextButton_Click(object sender, EventArgs e)
        {
            plainTextDoc.content = TurnIntoTextObjects(PlainTextTextBox.Text);

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
    }
}
