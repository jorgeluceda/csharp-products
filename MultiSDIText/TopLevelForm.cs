﻿using System;
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
    public partial class TopLevelForm : BaseMainForm
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
            // Set the application's WindowMenu
            //MultiSDIApplication.Application.WindowMenu = this.windowToolStripMenuItem;
            // Add the handler for the DropDownOpening event to the application's window menu
            //MultiSDIApplication.Application.WindowMenu.DropDownOpening += MultiSDIApplication.Application.windowMenu_DropDownOpening;
            //InitializeSubmenuEvents();
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
    }
}
