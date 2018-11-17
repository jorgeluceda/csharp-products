using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSDIContact.Services.Entities
{
    public class ContactsCollection
    {
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
    }
}
