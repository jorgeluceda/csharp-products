﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SingleDocumentInterface;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using CoreLibrary;

namespace SingleDocumentInterface
{
    public partial class MainForm : BaseMainForm
    {
        // The Document itself
        protected Documents.Drivers.FileSystemDocument document = new Documents.Drivers.FileSystemDocument();
        private bool changedText = false;
        protected PreferencesDialog prefDialog = null;

        public MainForm()
        {
            InitializeComponent();

        }

        #region FileMainMenuItems

        /**
         *  Click handler for the File -> New MainMenu item. Implements creating a new file/document by creating a 
         *  new instance of the FileSystemDocument class and setting this application's document to the newly 
         *  created document. The current application insance's TextBox and Text (title bar) are reset. Setting this
         *  application insance's document to the newly created document also resets the FilePath associated with the
         *  document.
         */
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documents.Drivers.FileSystemDocument document = new Documents.Drivers.FileSystemDocument();
            this.document = document;
            this.TextBox.Text = this.document.Text;
            this.Text = "Notepad--";
            this.StatusLabel.Text = "New file";
            this.TextBox.BackColor = this.document.BackColor;
            this.TextBox.ForeColor = this.document.TextColor;
            this.TextBox.Font = this.document.Font;
        }

        /**
         *  Click handler for the File -> Open MainMenu item. Implements opening a file using the built in 
         *  OpenFileDialog provided by .NET. The deserialized file is loaded into a FileSystemDocument object, and
         *  then our MainForm's properties are set using the FileSystemDocument's properties.
         */
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;
                using (Stream stream =
                    new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                {
                    IFormatter formatter = new BinaryFormatter();

                    Documents.Drivers.FileSystemDocument document =
                        (Documents.Drivers.FileSystemDocument)formatter.Deserialize(stream);

                    document.FilePath = dlg.FileName;

                    this.TextBox.Text = document.Text;
                    this.TextBox.BackColor = document.BackColor;
                    this.TextBox.ForeColor = document.TextColor;
                    this.TextBox.Font = document.Font;
                    this.Location = document.DocumentLocation;
                    this.Text = document.DocumentTitle;

                    // Set this instance of the application's document properties to the ones just retrieved from
                    // deserialization - needed for detecting if a file has been saved before in File->Save
                    this.document = document;
                    this.StatusLabel.Text = "Opened file: " + this.document.DocumentTitle;
                }
            }
        }

        /**
         *  Click handler for the File -> Save MainMenu item. Implements saving a file using the built in 
         *  SaveFileDialog provided by .NET. The FileSystemDocument properties are set, and then once set we pass
         *  the stream and the document to Serialize to serialize the document's members.
         */
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If the document is new, i.e. has never been saved before
            if (string.IsNullOrEmpty(this.document.DocumentTitle) || string.IsNullOrWhiteSpace(this.document.DocumentTitle))
            {
                using (SaveFileDialog dlg = new SaveFileDialog())
                {
                    if (dlg.ShowDialog() != DialogResult.OK) return;

                    using (Stream stream =
                        new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
                    {
                        IFormatter formatter = new BinaryFormatter();

                        Documents.Drivers.FileSystemDocument document = new Documents.Drivers.FileSystemDocument();

                        document.Text = this.TextBox.Text;
                        document.BackColor = this.TextBox.BackColor;
                        document.TextColor = this.TextBox.ForeColor;
                        document.Font = this.TextBox.Font;
                        document.DocumentLocation = this.Location;
                        document.DocumentTitle = Path.GetFileName(dlg.FileName);
                        document.DocumentSize = this.Size;
                        document.FilePath = dlg.FileName;

                        formatter.Serialize(stream, document);
                        this.document = document;
                        changedText = false;
                        this.StatusLabel.Text = "Saved";
                    }

                }

                this.Text = this.document.DocumentTitle;
            }
            // If the document not new, and has been saved before
            else
            {
                using (Stream stream = new FileStream(this.document.FilePath, FileMode.Create, FileAccess.Write))
                {
                    IFormatter formatter = new BinaryFormatter();

                    this.document.Text = this.TextBox.Text;
                    this.document.BackColor = this.TextBox.BackColor;
                    this.document.TextColor = this.TextBox.ForeColor;
                    this.document.Font = this.TextBox.Font;
                    this.document.DocumentSize = this.Size;
                    this.document.DocumentLocation = this.Location;
                    this.document.DocumentTitle = Path.GetFileName(document.FilePath);

                    formatter.Serialize(stream, document);
                }
                changedText = false;
                this.Text = this.document.DocumentTitle;

                this.StatusLabel.Text = "Saved";
            }

        }

        /**
         *  Click handler for the File -> Save MainMenu item. Implements saving a file using the built in 
         *  SaveFileDialog provided by .NET. The FileSystemDocument properties are set, and then once set we pass
         *  the stream and the document to Serialize to serialize the document's members.
         */
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;

                using (Stream stream =
                    new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
                {
                    IFormatter formatter = new BinaryFormatter();

                    // Before serializing, set this app instance's document properties, then serialize
                    this.document.Text = this.TextBox.Text;
                    this.document.BackColor = this.TextBox.BackColor;
                    this.document.TextColor = this.TextBox.ForeColor;
                    this.document.Font = this.TextBox.Font;
                    this.document.DocumentSize = this.Size;
                    this.document.DocumentLocation = this.Location;
                    this.document.DocumentTitle = Path.GetFileName(document.FilePath);

                    changedText = false;
                    formatter.Serialize(stream, this.document);
                }
            }

            this.Text = this.document.DocumentTitle;
            this.StatusLabel.Text = "Saved";
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region EditMainMenuItems

        /**
         * Click handler for the Edit -> Cut MainMenu item. Implements cutting text from the text editor into the
         * Clipboard.
         */
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If the text editor is empty
            if (string.IsNullOrWhiteSpace(this.TextBox.Text) || string.IsNullOrEmpty(this.TextBox.Text))
            {
                return;
            }

            if(this.TextBox.SelectionLength > 0)
            {
                int start = this.TextBox.SelectionStart;
                int length = this.TextBox.SelectionLength;

                Clipboard.SetText(this.TextBox.SelectedText);
                this.TextBox.Text = this.TextBox.Text.Remove(start, length);
                this.TextBox.SelectionStart = start;
            }
            else
            {
                Clipboard.SetText(this.TextBox.Text);       // Set the clipboard text to the text editor's text
                this.TextBox.Text = "";                     // Empty the text in the text editor
            }

            this.StatusLabel.Text = "Cut";
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If the text editor is empty
            if (string.IsNullOrWhiteSpace(this.TextBox.Text) || string.IsNullOrEmpty(this.TextBox.Text))
            {
                return;
            }

            if(this.TextBox.SelectionLength > 0)
            {
                Clipboard.SetText(this.TextBox.SelectedText);
            }
            else
            {
                Clipboard.SetText(this.TextBox.Text);       // Set the clipboard text to the text editor's text
                
            }

            this.StatusLabel.Text = "Copied";
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If the clipboard is empty, return
            if (!Clipboard.ContainsText())
            {
                return;
            }

            int tempStart = this.TextBox.SelectionStart;
           
            this.TextBox.Text = this.TextBox.Text.Insert(this.TextBox.SelectionStart, Clipboard.GetText());
            this.TextBox.SelectionStart = tempStart;
            
            this.StatusLabel.Text = "Pasted";
        }

        #endregion

        #region PreferencesMenuItems

        /**
         *  Click handler for the Preferences -> Font MainMenu item. Opens an instance of the FontDialog class
         *  provided by .NET. Sets the document's Font property to whichever Font is set in the FontDialog.
         */
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog dlg = new FontDialog())
            {
                dlg.ShowColor = true;
                dlg.Font = document.Font;

                if (dlg.ShowDialog() != DialogResult.Cancel)
                {
                    document.Font = dlg.Font;
                }
            }
        }
        
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Undo();
        }

        #endregion


        /**
         *  Handler for TextChanged event for the text editor. Tacks an asterisk onto the application's Title Bar Text.
         */
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.document.DocumentTitle) || string.IsNullOrWhiteSpace(this.document.DocumentTitle))
            {
                this.Text = "Notepad-- *";
            }
            else
            {
                this.Text = this.document.DocumentTitle + "*";
            }

            changedText = true;
        }

        #region Preferences Dialog items and events
        private void openModelesslyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.prefDialog = new PreferencesDialog();

            // Update the properties for the dialog before it's shown


            this.prefDialog.BackColor =TextBox.BackColor;
            this.prefDialog.TextColor = TextBox.ForeColor;
            this.prefDialog.Font = TextBox.Font;
            this.prefDialog.DocumentSize = Size;
            this.prefDialog.DocumentLocation = Location;
            this.prefDialog.DocumentTitle = Text;

            // Subscribe to the dialog's Apply event
            this.prefDialog.Apply += preferences_Apply;

            // Open Modelessly
            this.prefDialog.Show(this);
        }

        void preferences_Apply(object sender, EventArgs e)
        {
            PreferencesDialog preferencesDlg = sender as PreferencesDialog;

            //save changes in document
            this.document.BackColor = this.prefDialog.BackColor;
            this.document.Font = this.prefDialog.Font;
            this.document.TextColor = this.prefDialog.TextColor;
            this.document.DocumentSize = this.prefDialog.DocumentSize;
            this.document.DocumentLocation = this.prefDialog.DocumentLocation;
            this.document.DocumentTitle = this.prefDialog.DocumentTitle;


            //apply changes in document
            this.TextBox.Font = this.document.Font;
            this.TextBox.BackColor = this.document.BackColor;
            this.TextBox.ForeColor = this.document.TextColor;
            this.Size = this.document.DocumentSize;
            this.Location = this.document.DocumentLocation;
            this.Text = this.document.DocumentTitle;
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(changedText && !string.IsNullOrEmpty(this.TextBox.Text))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit the application without saving?",
                    "Closing Application", MessageBoxButtons.YesNo);

                if(result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OathDialog dlg = new OathDialog();
            dlg.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog dlg = new AboutDialog();
            dlg.Show();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            Form helpDialog = new HelpDialog();
            helpDialog.Show();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form helpDialog = new HelpDialog();
            helpDialog.Show();
        }
    }
}
