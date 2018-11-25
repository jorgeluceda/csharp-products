using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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

        Contact contactBuffer;

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
            //if there are more than 0 objects, enable delete and edit buttons
            this.deleteButton.Enabled = this.BindingManager.Count > 0;
            this.editButton.Enabled = this.BindingManager.Count > 0;
        }
        
        #endregion

        #region Getters/Setters

        // Read Only FileName property
        string FileName
        {
            get { return this.fileName; }
        }

        Contact ContactBuffer
        {
            get { return this.contactBuffer; }
            set { this.contactBuffer = value; }
        }
        #endregion

        #region Constructor
        public ContactDIrectoryForm()
        {
            InitializeComponent();

            RefreshItems(); //refresh items on construction

            InitializePrintingFunctionality();
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
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                //
                if (dlg.FileName == this.Text) return;
                dlg.Filter = "Contact List Files|*.clf";
                int currentLoadingContact = 0;
                if (dlg.ShowDialog() != DialogResult.OK) return;
                using (Stream stream =
                   new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                {
                    IFormatter formatter = new BinaryFormatter();
                    Contact[] contactList = (Contact[])formatter.Deserialize(stream);
                    ContactDIrectoryForm form = CreateContactDirectoryWindow(dlg.FileName);
                    form.Text = dlg.FileName;
                    //Check first to see if DataBindingSource count 0, as in the file is not open
                    if (form.DataBindingSource.Count == 0)
                    {
                        while (currentLoadingContact < contactList.Length)
                        {
                            form.DataBindingSource.Add(contactList[currentLoadingContact]);
                            currentLoadingContact++;
                        }
                    }
                }
            }
        }

        //To save a string text of the contact list as a csv
        private void rawMenuItem_Click(object sender, EventArgs e)
        {
            //Collect all the contacts to save
            StringBuilder csv = new StringBuilder();
            csv.AppendLine("");
            int currentSavingContact = 0;
            Contact[] contactList = new Contact[this.bsContacts.Count];
            while (currentSavingContact < this.bsContacts.Count)
            {
                contactList[currentSavingContact] = (Contact)this.bsContacts[currentSavingContact];
                string firstname = contactList[currentSavingContact].FirstName;
                string lastname = contactList[currentSavingContact].LastName;
                string cellphone = contactList[currentSavingContact].CellPhone;
                string homephone = contactList[currentSavingContact].HomePhone;
                string address1 = contactList[currentSavingContact].Address1;
                string address2 = contactList[currentSavingContact].Address2;
                string city = contactList[currentSavingContact].City;
                string state = contactList[currentSavingContact].State;
                string zip = contactList[currentSavingContact].Zip;
                string country = contactList[currentSavingContact].Country;
                var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", firstname, lastname,
                    cellphone, homephone, address1, address2, city, state, zip, country);
                csv.AppendLine(newLine);
                currentSavingContact++;
            }

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "Comma-Separated Values|*.csv";
                if (dlg.ShowDialog() != DialogResult.OK) return;
                using (Stream stream = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, csv.ToString());
                }
            }
        }

        //To save contact list
        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            //Collect all the contacts to save
            int currentSavingContact = 0;
            Contact[] contactList = new Contact[this.bsContacts.Count];
            while (currentSavingContact < this.bsContacts.Count)
            {
                contactList[currentSavingContact] = (Contact)this.bsContacts[currentSavingContact];
                currentSavingContact++;
            }

            if (this.Text != "Contact Directory")
            {
                using (Stream stream = new FileStream(this.Text, FileMode.Create, FileAccess.Write))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, contactList);
                }
            }
            else
            {
                using (SaveFileDialog dlg = new SaveFileDialog())
                {
                    dlg.Filter = "Contact List Files|*.clf";
                    if (dlg.ShowDialog() != DialogResult.OK) return;

                    using (Stream stream = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(stream, contactList);
                        this.Text = dlg.FileName;
                    }
                }
            }
        }
        //To new save contact list
        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            //Collect all the contacts to save
            int currentSavingContact = 0;
            Contact[] contactList = new Contact[this.bsContacts.Count];
            while (currentSavingContact < this.bsContacts.Count)
            {
                contactList[currentSavingContact] = (Contact)this.bsContacts[currentSavingContact];
                currentSavingContact++;
            }
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "Contact List Files|*.clf";
                if (dlg.ShowDialog() != DialogResult.OK) return;

                using (Stream stream = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, contactList);
                    this.Text = dlg.FileName;
                }
            }
        }
        #endregion

        #region Print

        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private PrintDialog printDialog;

        private Font printBodyFont;
        private Font printHeaderFont;
        private Font printFooterFont;
        private int currentPrintingContact = 0;
        private int currentPrintingPage = 1;

        private void printMenuItem_Click(object sender, EventArgs e)
        {
            this.printDialog.Document = this.printDocument;
            if (this.printDialog.ShowDialog() == DialogResult.OK)
            {
                this.printDocument.DocumentName = this.fileName;
                this.printDocument.Print();
            }
        }

        private void printPreviewMenuItem_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.ShowDialog();
        }

        private void InitializePrintingFunctionality()
        {
            this.printPreviewDialog = new PrintPreviewDialog();
            this.printDialog = new PrintDialog();
            this.printDocument = new PrintDocument();

            this.printDocument.BeginPrint += PrintDocument_BeginPrint;
            this.printDocument.EndPrint += PrintDocument_EndPrint;
            this.printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void PrintDocument_BeginPrint(object sender, PrintEventArgs e)
        {
            this.printBodyFont = new Font("Arial", 16);
            this.printHeaderFont = new Font("Arial", 25);
            this.printFooterFont = new Font("Arial", 12);
            this.currentPrintingContact = 0;
            this.currentPrintingPage = 1;

            if (this.bsContacts.Count < 1)
                e.Cancel = true;
        }

        private void PrintDocument_EndPrint(object sender, PrintEventArgs e)
        {
            this.printBodyFont.Dispose();
            this.printHeaderFont.Dispose();
            this.printFooterFont.Dispose();

            this.printBodyFont = null;
            this.printHeaderFont = null;
            this.printFooterFont = null;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Draw to the e.Graphics object that wraps the print target 
            Graphics g = e.Graphics;
            Rectangle printableArea = e.MarginBounds;

            // START - Print page header
            if (this.currentPrintingPage == 1)
            {
                string headerText = "Contacts Directory\n\n";
                SizeF headerPrintSize = g.MeasureString(headerText, this.printHeaderFont, printableArea.Width);
                using (StringFormat format = new StringFormat())
                {
                    format.Alignment = StringAlignment.Center;
                    g.DrawString(headerText, this.printHeaderFont, Brushes.Black, printableArea, format);
                }
                printableArea.Y += (int)headerPrintSize.Height;
                printableArea.Height -= (int)headerPrintSize.Height;
            }
            // END - Print page body

            // START - Print page footer
            string footerText = "Page " + this.currentPrintingPage;
            SizeF footerPrintSize = g.MeasureString(footerText, this.printFooterFont, printableArea.Width);
            RectangleF footerArea = new RectangleF(printableArea.Left, printableArea.Bottom - (int)footerPrintSize.Height, printableArea.Width, footerPrintSize.Height);
            using (StringFormat format = new StringFormat())
            {
                format.Alignment = StringAlignment.Far;
                g.DrawString(footerText, this.printFooterFont, Brushes.Black, footerArea, format);
            }
            printableArea.Height -= (int)footerPrintSize.Height;
            // END - Print page footer

            // START - Print page body
            while (this.currentPrintingContact < this.bsContacts.Count)
            {
                Contact currentContact = (Contact)this.bsContacts[this.currentPrintingContact];
                string line = currentContact.ToString() + "\n\n";

                // Get size for word wrap
                SizeF printSize = g.MeasureString(line, this.printBodyFont, printableArea.Width);

                if (printableArea.Height > printSize.Height)
                { // Print line
                    g.DrawString(line, this.printBodyFont, Brushes.Black, printableArea);
                    // Calculate and reduce remaining printable area 
                    printableArea.Y += (int)printSize.Height;
                    printableArea.Height -= (int)printSize.Height;

                    this.currentPrintingContact++;
                }
                else
                    break;
            }
            // END - Print page body
            
            this.currentPrintingPage++;
            e.HasMorePages = (this.currentPrintingContact < this.bsContacts.Count);
        }

        #endregion

        private void addButton_Click(object sender, EventArgs e) {

            //make new contacts object and add it to bindingSource
            Contact newContact = new Contact();
            ContactDetailsForm dirForm = new ContactDetailsForm();

            // META data binding source - modify newContact without the 
            // need to pass it directly ;)
            dirForm.DataBindingSource.DataSource = newContact;
            dirForm.canDelete = false;
            dirForm.ShowDialog(); //show model contact details form
            
            if(dirForm.closeAccept == true)
            {
                DataBindingSource.Add(newContact);
                RefreshItems(); //since new contact added, refresh the items in grid view
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Int32 selectedIndex = contactDataGrid.CurrentRow.Index;

            Contact currentContact = (Contact)contactDataGrid.CurrentRow.DataBoundItem;

            ContactDetailsForm dirForm = new ContactDetailsForm();
            
            // META data binding source - modify newContact without the 
            // need to pass it directly ;)
            dirForm.DataBindingSource.DataSource = currentContact;
            dirForm.canDelete = true;
            dirForm.ShowDialog(); //show model contact details form
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Int32 selectedIndex = contactDataGrid.CurrentRow.Index;

            DataBindingSource.RemoveAt(selectedIndex);

            // refresh items in case item count is 0 
            // to disable the edit and delete buttons
            RefreshItems(); 
        }

        private void ContactDIrectoryForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                directoryNotifyIcon.Visible = true;
            }

            if (WindowState == FormWindowState.Normal)
            {
                directoryNotifyIcon.Visible = false;
            }

        }
    }
}
