using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiSDIText;
using MultiSDIText.Storage;

namespace MultiSDIText
{
    public partial class PlainTextDialog : Form
    {
        public PlainTextDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets a string and returns an array of Text object representing each word.
        /// </summary>
        /// <param name="p">The string to split into words</param>
        /// <returns>An array of words as Text object</returns>
        public List<Text> TurnIntoTextObjects(String s)
        {
            String[] words = s.Split(' ');
            List<Text> texts = new List<Text>();
            for (int i = 0; i < words.Length; i++)
            {
                Text text = new Text();
                text.Content = words[i];
                texts.Add(text);
            }
            return texts;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTextButton_Click(object sender, EventArgs e)
        {
            List<Text> list = TurnIntoTextObjects(this.PlainTextTextBox.Text);
            Document doc = new Document(list);
        }

        private void PlainTextDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!String.IsNullOrEmpty(this.PlainTextTextBox.Text) || !String.IsNullOrWhiteSpace(this.PlainTextTextBox.Text))
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
