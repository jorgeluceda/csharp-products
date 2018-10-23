using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using CoreLibrary;

namespace MultiSDIText
{
    public partial class TopLevelForm : Form
    {
        #region Member Variables and Properties
        string fileName;

        //Document doc = new Document();
        //OptionsForm optionsForm = new OptionsForm();


        // Read Only FileName property
        string FileName
        {
            get { return this.fileName; }
        }
        #endregion
        #region Constructor
        public TopLevelForm()
        {
            InitializeComponent();

            // When an instance of TopLevelForm is created, add it to the MultiSDIApplication context
            MultiSDITextApplication.Application.AddTopLevelForm(this);

            MultiSDITextApplication.Application.AddWindowMenu(this.windowToolStripMenuItem);
        }
        #endregion
        #region Helper Methods
        /**
         *  CreateTopLevelWindow implements creating a new form. This is the real 'constructor'. 
         *  First, we check if the fileName matches any of the Open Forms in the MultiSDIApplication. If it
         *  does, we just activate that form. If it doesn't we create a new one using OpenFile, a method found
         *  in this class (TopLevelForm) to open a file, then we activate the new window.
         */
        public static TopLevelForm CreateTopLevelWindow(string fileName)
        {
            // If fileName is not empty
            if (!string.IsNullOrEmpty(fileName))
            {
                // Loop through the open forms in MultiSDIApplication 
                foreach (TopLevelForm openForm in Application.OpenForms)
                {
                    // If the file we're trying to open is already open, i.e. file names match
                    if (string.Compare(openForm.fileName, fileName, true) == 0)
                    {
                        // Bring form to top
                        openForm.Activate();
                        return openForm;
                    }
                }
            }
            // Otherwise, create a new one with the given fileName
            TopLevelForm form = new TopLevelForm();
            form.OpenFile(fileName);
            form.Show();

            // Bring form to top
            form.Activate();
            return form;
        }
        /**
         *  OpenFile opens a file given it's fileName. Sets this top level form's file name to the fileName passed
         *  in the call, and then populates this form with the contents of the document.
         */
        void OpenFile(string fileName)
        {
            this.fileName = fileName;
            // TODO: Implement populating the TopLevelForm with the shapes from the saved document. This part will differ
            // from the book, which reads text into the top level forms textbox. We, however, are not dealing with text, but
            //  with shapes
            // If fileName is not empty
            if (!string.IsNullOrEmpty(fileName))
            {
                // Populate this Window with the shapes from the document tied to fileName
            }
            else
            {

            }
        }
        #endregion

        private void TopLevelForm_Load(object sender, EventArgs e)
        {
            //todo: handle menu merging
            //ToolStripManager.Merge(BaseMenu, MainMenu);

        }

        
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If the document is new, i.e. has never been saved before
            //if (string.IsNullOrEmpty(this.document.DocumentTitle) || string.IsNullOrWhiteSpace(this.document.DocumentTitle))
            //{
            //    using (SaveFileDialog dlg = new SaveFileDialog())
            //    {
            //        if (dlg.ShowDialog() != DialogResult.OK) return;

            //        using (Stream stream =
            //            new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
            //        {
            //            IFormatter formatter = new BinaryFormatter();

            //            Documents.Drivers.FileSystemDocument document = new Documents.Drivers.FileSystemDocument();

            //            document.Text = this.TextBox.Text;
            //            document.BackColor = this.TextBox.BackColor;
            //            document.TextColor = this.TextBox.ForeColor;
            //            document.Font = this.TextBox.Font;
            //            document.DocumentLocation = this.Location;
            //            document.DocumentTitle = Path.GetFileName(dlg.FileName);
            //            document.DocumentSize = this.Size;
            //            document.FilePath = dlg.FileName;

            //            formatter.Serialize(stream, document);
            //            this.document = document;
            //            changedText = false;
            //            this.StatusLabel.Text = "Saved";
            //        }

            //    }

            //    this.Text = this.document.DocumentTitle;
            //}
            //// If the document not new, and has been saved before
            //else
            //{
            //    using (Stream stream = new FileStream(this.document.FilePath, FileMode.Create, FileAccess.Write))
            //    {
            //        IFormatter formatter = new BinaryFormatter();

            //        this.document.Text = this.TextBox.Text;
            //        this.document.BackColor = this.TextBox.BackColor;
            //        this.document.TextColor = this.TextBox.ForeColor;
            //        this.document.Font = this.TextBox.Font;
            //        this.document.DocumentSize = this.Size;
            //        this.document.DocumentLocation = this.Location;
            //        this.document.DocumentTitle = Path.GetFileName(document.FilePath);

            //        formatter.Serialize(stream, document);
            //    }
            //    changedText = false;
            //    this.Text = this.document.DocumentTitle;

            //    this.StatusLabel.Text = "Saved";
            //}
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDialog dlg = new SearchDialog();
            dlg.Show();
        }
    }
}
