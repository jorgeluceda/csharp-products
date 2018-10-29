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
using MultiSDIText.Storage;

namespace MultiSDIText
{
    public partial class TopLevelForm : Form
    {
        #region Member Variables and Properties
        string fileName;

        private SearchDialog dlg;

        public SearchDialog SearchDlg
        {
            get { return this.dlg; }
            set { this.dlg = value; }
        }

        //represents our document (a list of text objects and their functionality)
        Storage.Document doc = new Storage.Document();

        //represents our current text to be added to the document
        //Storage.Text curText = new Storage.Text();
        int Zorder = 0;
        //OptionsForm optionsForm = new OptionsForm();
        TextOptions optionsForm = new TextOptions();


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

            //initializing a current shape
            InitializeDS();
              

            // When an instance of TopLevelForm is created, add it to the MultiSDIApplication context
            MultiSDITextApplication.Application.AddTopLevelForm(this);

            //Set the applications windowmenu
            MultiSDITextApplication.Application.AddWindowMenu(this.windowToolStripMenuItem);
        }
        #endregion

        #region Helper Methods

        private void docPictureBox_Paint(object sender, PaintEventArgs e)
        {

            // Create a local version of the graphics object for the PictureBox.
            Graphics docGraphics = e.Graphics;


            this.doc.Draw(docGraphics);
        }
        private void docPictureBox_Click(object sender, EventArgs e)
        {
            
            Storage.Text curText = new Storage.Text();

            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            curText.ZOrder = Zorder;
            Zorder += 1;
            curText.Content = "hello";

            curText.Location = coordinates;
            curText.Font = new Font("Times New Roman", 12.0f);


            this.doc.Add(curText);
            this.docPictureBox.Invalidate();

        }


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


        private void InitializeDS()
        {

            
            optionsForm.DataBindingSource.DataSource = doc.content;
            //optionsForm.DataBindingSource.DataSource = text;
            docPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.docPictureBox_Paint);
            //dg.DataBindingSource.DataSource = shape;
            //var result = this.optionsForm.ShowDialog();
            //result.Equals("AAAA");
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
            if(dlg == null)
            {
                dlg = new SearchDialog();
                dlg.MainForm = this;
                dlg.Show();
            }
            else
            {
                dlg.BringToFront();
            }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            this.optionsForm.ShowDialog();


        }


    }
}
