using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MultiSDIContact.Services.Entities
{
    [Serializable]
    public class ContactsCollection: ISerializable
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public ContactsCollection(BindingList<Contact> contacts)
        {
            this.Contacts = contacts;
            this.InitializePrintingfunctionality();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public ContactsCollection() : this(new BindingList<Contact>())
        {

        }

        #endregion

        #region Constacts

        /// <summary>
        /// The contacts list
        /// </summary>
        private BindingList<Contact> contacts;

        /// <summary>
        /// The contacts list
        /// </summary>
        public BindingList<Contact> Contacts
        {
            get { return this.contacts; }
            set { this.contacts = value; }
        }

        #endregion

        #region ISerializable

        /// <summary>
        /// Desirializes the object
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected ContactsCollection(SerializationInfo info, StreamingContext context)
        {
            this.contacts = (BindingList<Contact>)info.GetValue("contacts", typeof(BindingList<Contact>));
            this.InitializePrintingfunctionality();
        }

        /// <summary>
        /// Serializes the object
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("contacts", this.contacts, typeof(List<Contact>));
        }

        #endregion

        #region Print

        private PrintDocument printDocument;
        private int currentContact = 0;
        private int contactsPerPage = 10;
        private int startPage = 0;
        private int endPage = 0;
        private string fileName = "contacts.txt";

        public void Print()
        {

        }

        private void InitializePrintingfunctionality()
        {
            this.printDocument = new PrintDocument();

            this.printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Draw to the e.Graphics object that wraps the print target 
            Graphics g = e.Graphics;

            using (Font font = new Font("Arial", 16))
            {
                string contact = "";

                contact += "";

                g.DrawString("Hello,\nPrinter", font, Brushes.Black, g.VisibleClipBounds);
            }
        }

        #endregion
    }
}
