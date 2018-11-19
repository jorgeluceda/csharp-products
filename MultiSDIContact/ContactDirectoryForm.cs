﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiSDIContact.Services.Entities;
namespace MultiSDIContact
{
    public partial class ContactDIrectoryForm : Form, IBindingSource
    {
        #region Member Variables and Properties
        string fileName;


        #endregion

        #region Data Binding
        public BindingSource DataBindingSource
        {
            get { return this.bsContacts; }
            set { bsContacts = value; }
        }

        BindingManagerBase BindingManager
        {

            get
            {
                return this.BindingContext[this.bsContacts];
            }
        }
        void RefreshItems()
        {
            //delete button implementation
            //this.btnDelete.Enabled = this.BindingManager.Count > 0;
        }
        
        #endregion

        #region Getters

        // Read Only FileName property
        string FileName
        {
            get { return this.fileName; }
        }
        #endregion

        #region Constructor
        public ContactDIrectoryForm()
        {
            InitializeComponent();

            RefreshItems(); //refresh items on construction

        }
        
        #endregion

        #region Helper Methods

        /**
         *  CreateContactDirectoryWindow implements creating a new form. This is the real 'constructor'. 
         *  First, we check if the fileName matches any of the Open Forms in the MultiSDIApplication. If it
         *  does, we just activate that form. If it doesn't we create a new one using OpenFile, a method found
         *  in this class (ContactDIrectoryForm) to open a file, then we activate the new window.
         */
        public static ContactDIrectoryForm CreateContactDirectoryWindow(string fileName)
        {
            // If fileName is not empty
            if (!string.IsNullOrEmpty(fileName))
            {
                // Loop through the open forms in MultiSDIApplication 
                foreach (ContactDIrectoryForm openForm in Application.OpenForms)
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
            ContactDIrectoryForm form = new ContactDIrectoryForm();
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

        #region Form Methods

        //Closing the form
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //To display the about dialog
        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            aboutDialog about = new aboutDialog();
            about.Show();
        }

        //To display the help info for this form
        private void helpInfoMenuItem_Click(object sender, EventArgs e)
        {
            HelpDialog help = new HelpDialog();
            help.Show();
        }

        //To dipslay the oath dialog
        private void oathMenuItem_Click(object sender, EventArgs e)
        {
            oathDialog oath = new oathDialog();
            oath.Show();
        }

        //To load contacts
        private void loadMenuItem_Click(object sender, EventArgs e)
        {

        }

        //To display a string text of the contact list
        private void rawMenuItem_Click(object sender, EventArgs e)
        {

        }

        //To save contact list
        private void saveMenuItem_Click(object sender, EventArgs e)
        {

        }

        // To print the contacts list
        private void menuItem1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Print

        /*private PrintDocument printDocument;
        private int currentContact = 0;
        private int contactsPerPage = 10;

        public void Print()
        {

        }

        private void InitializePrintingfunctionality()
        {
            this.printDocument = new PrintDocument();

            this.printDocument.BeginPrint += PrintDocument_BeginPrint;
            this.printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void PrintDocument_BeginPrint(object sender, PrintEventArgs e)
        {
            this.currentContact = 0;

            if (this.Contacts.Count < 1)
                e.Cancel = true;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Draw to the e.Graphics object that wraps the print target 
            Graphics g = e.Graphics;

            using (Font font = new Font("Arial", 16))
            {
                int localCount = 0;

                while (localCount < this.contactsPerPage && this.currentContact < this.Contacts.Count)
                {
                    Contact currentContact = this.Contacts.ElementAt(this.currentContact);

                    g.DrawString(currentContact.ToString(), font, Brushes.Black, g.VisibleClipBounds);

                    this.currentContact++;
                    localCount++;
                }
            }

            e.HasMorePages = (this.currentContact < this.Contacts.Count);
        }*/

        #endregion

        private void addButton_Click(object sender, EventArgs e) {

            //make new contacts object and add it to bindingSource
            Contact newContact = new Contact();
            ContactDetailsForm dirForm = new ContactDetailsForm();

            // META data binding source - modify newContact without the 
            // need to pass it directly ;)
            dirForm.DataBindingSource.DataSource = newContact;
            dirForm.canDelete = true;
            dirForm.ShowDialog(); //show model contact details form
            
            if(dirForm.closeAccept == true)
            {
                DataBindingSource.Add(newContact);
                RefreshItems(); //since new contact added, refresh the items in grid view
            }

        }
    }
}
