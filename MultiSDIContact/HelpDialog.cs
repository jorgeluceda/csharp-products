using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiSDIContact
{
    public partial class HelpDialog : Form
    {
        public Dictionary<String, String> helpItems = new Dictionary<String, String>();

        public HelpDialog()
        {
            InitializeComponent();
        }

        public void InitializeElements()
        {
            //Menu
            helpItems.Add("File Menu ", "Provide some File related options: Save, Load, Raw, and Close ");
            helpItems.Add("Help Menu ", "Provide details regarding the multiple actions the application performs");

            //ToolBar
            helpItems.Add("Add", "Adds a contact to the contact list");
            helpItems.Add("Edit", "Edits an existing contact");
            helpItems.Add("Delete", "Removes a contact from the list");
            helpItems.Add("Print", "Pastes text from the clipboard into the active Document");

            //File Submenu
            helpItems.Add("Save Submenu", "It will save the current contact list");
            helpItems.Add("Load Submenu", "It will load a contact list");
            helpItems.Add("Raw Submenu", "It will display the contact list as a text string");
            helpItems.Add("Close Submenu", "It will close the directory");

            //Help Submenu
            helpItems.Add("Oath","Oath information");
            helpItems.Add("About","Information about the application and developers");

            LoadHelpItems("all");

        }
        
        private void LabelClicked(object sender, EventArgs e)
        {
            MessageBox.Show("text", "title");
        }

        private void searchTextBox_KeyUp_1(object sender, KeyEventArgs e)
        {
            String keyword = searchTextBox.Text;

            if (keyword.CompareTo("") == 0)
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
            ClearResultText();
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

        private void ClearResultText()
        {
            resultTextBox.Text = "";
        }

        private void LoadHelpItems(String term)
        {
            ClearHelpItems();
            Boolean process = false;
            String[] terms = term.ToLower().Split(' ');

            foreach (KeyValuePair<string, string> entry in helpItems)
            {
                //processing Help Items
                if (term.CompareTo("all") == 0)
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

        private void HelpDialog_Load(object sender, EventArgs e)
        {
            InitializeElements();
        }
    }
}
