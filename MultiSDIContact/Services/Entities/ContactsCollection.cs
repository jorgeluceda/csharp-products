using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public ContactsCollection() : this(new BindingList<Contact>())
        {

        }

        #endregion

        #region Contacts

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

        
    }
}
