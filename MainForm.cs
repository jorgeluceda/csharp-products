using System;
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

namespace SingleDocumentInterface
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        // The Document itself
        protected Documents.Drivers.FileSystemDocument document = new Documents.Drivers.FileSystemDocument();

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documents.Drivers.FileSystemDocument document = new Documents.Drivers.FileSystemDocument();
            this.document = document;
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
                    this.Location = document.DocumentLocation;
                    this.Text = document.DocumentTitle;

                    // Set this instance of the application's document properties to the ones just retrieved from
                    // deserialization - needed for detecting if a file has been saved before in File->Save
                    this.document = document;
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
            if(string.IsNullOrEmpty(this.document.DocumentTitle) || string.IsNullOrWhiteSpace(this.document.DocumentTitle))
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
                        document.DocumentLocation = this.Location;
                        document.DocumentTitle = Path.GetFileName(dlg.FileName);
                        document.FilePath = dlg.FileName;

                        formatter.Serialize(stream, document);
                        this.document = document;
                    }

                }

                this.Text = this.document.DocumentTitle;
            }
            // If the document not new, and has been saved before
            else
            {
                using(Stream stream = new FileStream(this.document.FilePath, FileMode.Create, FileAccess.Write))
                {
                    IFormatter formatter = new BinaryFormatter();

                    this.document.Text = this.TextBox.Text;
                    this.document.DocumentLocation = this.Location;
                    this.document.DocumentTitle = Path.GetFileName(document.FilePath);

                    formatter.Serialize(stream, document);
                }

                this.Text = this.document.DocumentTitle;
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
                    this.document.DocumentLocation = this.Location;
                    this.document.DocumentTitle = Path.GetFileName(dlg.FileName);
                    this.document.FilePath = dlg.FileName;

                    formatter.Serialize(stream, this.document);
                }
            }

            this.Text = this.document.DocumentTitle;
        }

        /**
         *  Click handler for the Preferences -> Font MainMenu item. Opens an instance of the FontDialog class
         *  provided by .NET. Sets the document's Font property to whichever Font is set in the FontDialog.
         */
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FontDialog dlg = new FontDialog())
            {
                dlg.ShowColor = true;
                dlg.Font = document.Font;

                if (dlg.ShowDialog() != DialogResult.Cancel)
                {
                    document.Font = dlg.Font;
                }
            }
        }

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

            Clipboard.SetText(this.TextBox.Text);       // Set the clipboard text to the text editor's text
            this.TextBox.Text = "";                     // Empty the text in the text editor
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If the text editor is empty
            if (string.IsNullOrWhiteSpace(this.TextBox.Text) || string.IsNullOrEmpty(this.TextBox.Text))
            {
                return;
            }

            Clipboard.SetText(this.TextBox.Text);       // Set the clipboard text to the text editor's text
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If the clipboard is empty, return
            if (!Clipboard.ContainsText())
            {
                return;
            }

            this.TextBox.Text = Clipboard.GetText();        // Set the text editor's text to the clipboard's text
        }
    }
}
