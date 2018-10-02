using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleDocumentInterface
{
    public partial class HelpDialog : Form
    {
        public Dictionary<String, String> helpItems = new Dictionary<String, String>();

        public HelpDialog()
        {
            InitializeComponent();
            InitializeElements();
        }

        public void InitializeElements()
        {

           

            helpItems.Add("New File Button", "Creates a New Blank Document. The New Document will open in a new Windows.");
            helpItems.Add("Open File Button", "Allows opening an existing Document. It will pop up a Modal Window from where the user selects the file to open. ");
            helpItems.Add("Save File Button", "It will save the current Document. It asks location and name of the file ");
            helpItems.Add("Print File Button", "Opens the Print Dialog. ");
            helpItems.Add("Cut Text Button", "Cuts selected text from the document. It can be pasted by using the 'Paste Text Button' or the 'Paste' menu under the 'Edit Menu' ");
            helpItems.Add("Paste Text Button", "Pastes text from the clipboard into the active Document");
            helpItems.Add("Help Tooltip Button", "help tooltip description");
            helpItems.Add("File Menu ", "Provide some File related options like; New, Open, Save, Save As, Close ");
            helpItems.Add("Edit Menu ", "Provides options to edit the Document like; Cut, Copy and Paste");
            helpItems.Add("Preferences Menu ", "Provides multiple options to modify the Document like; Font, Background Color, Text Color, Document Size, Document Location, Document Title.");
            helpItems.Add("Help Menu ", "Opens Menu Dialog. It provides details regard the multiple actions the application performs in the Document");

            LoadHelpItems("all");



        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void openFileLabel_Click(object sender, EventArgs e)
        {

        }

        private void saveFileLabel_Click(object sender, EventArgs e)
        {

        }

        private void printFileLabel_Click(object sender, EventArgs e)
        {

        }

        private void cutTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void pasteTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void LabelClicked(object sender, EventArgs e)
        {
            MessageBox.Show("text", "title");
        }

        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {


            String keyword = searchTextBox.Text;

            if(keyword.CompareTo("") == 0)
            {
                LoadHelpItems("all");
            }
            else
            {
                LoadHelpItems(keyword);
            }


        }

        private void ClearHelpItems()
        {
            helpFlowLayoutPanel.SuspendLayout();

            if (helpFlowLayoutPanel.Controls.Count > 0)
            {
                for (int i = (helpFlowLayoutPanel.Controls.Count - 1); i >= 0; i--)
                {
                    Control c = helpFlowLayoutPanel.Controls[i];
                    c.Dispose();
                }
                GC.Collect();
            }

            helpFlowLayoutPanel.ResumeLayout();
        }

        private void LoadHelpItems(String term)
        {

            ClearHelpItems();
            Boolean process = false;
            String[] terms = term.ToLower().Split(' ');

           

            foreach (KeyValuePair<string, string> entry in helpItems)
            {
                //processing Help Items


                if(term.CompareTo("all") == 0)
                {
                    process = true;
                }
                else
                {
                    foreach (String trm in terms)
                    {
                        if (entry.Key.ToLower().Contains(trm))
                        {
                            process = true;
                            break;
                        }

                    }
                }

                if (process)
                {
                    Label newLabel = new Label();
                    newLabel.Text = entry.Key;

                    newLabel.Click += (object s, EventArgs ev) => {
                        //your code; 
                        resultTextBox.Text = entry.Value;

                    };

                    helpFlowLayoutPanel.Controls.Add(newLabel);

                }


                process = false;

            }

        }
    }
}
