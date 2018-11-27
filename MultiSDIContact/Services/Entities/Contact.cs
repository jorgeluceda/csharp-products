using MultiSDIContact.Services.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MultiSDIContact.Services.Entities
{
    [Serializable]
    public class Contact: BaseEntity, ISerializable, ICloneable
    {
        #region Constructor

        /// <summary>
        /// Simple constrcutor so complex databinding works well
        /// </summary>
        public Contact()
        {
            this.FirstName = DefaultValues.FirstName;
            this.LastName = DefaultValues.LastName;
            this.CellPhone = "";
            this.HomePhone = "";
            this.Address1 = "";
            this.Address2 = "";
            this.City = "";
            this.State = "";
            this.Zip = "";
            this.Country = "";
        }

        #endregion

        #region Properties

        #region FirstName

        /// <summary>
        /// Contact's first name
        /// </summary>
        private string firstName;

        /// <summary>
        /// Contact's first name
        /// </summary>
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                this.firstName = value;
                this.PropertyChange("FirstName");
            }
        }

        #endregion

        #region LastName

        /// <summary>
        /// Contact's last name
        /// </summary>
        private string lastName;

        /// <summary>
        /// Contact's last name
        /// </summary>
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                this.lastName = value;
                this.PropertyChange("LastName");
            }
        }

        #endregion

        #region CellPhone

        /// <summary>
        /// Contact's cell phone
        /// </summary>
        private string cellPhone;

        /// <summary>
        /// Contact's cell phone
        /// </summary>
        public string CellPhone
        {
            get { return this.cellPhone; }
            set
            {
                this.cellPhone = value;
                this.PropertyChange("CellPhone");
            }
        }

        #endregion

        #region HomePhone

        /// <summary>
        /// Contact's home phone
        /// </summary>
        private string homePhone;

        /// <summary>
        /// Contact's home phone
        /// </summary>
        public string HomePhone
        {
            get { return this.homePhone; }
            set
            {
                this.homePhone = value;
                this.PropertyChange("HomePhone");
            }
        }

        #endregion

        #region Address1

        /// <summary>
        /// Contact's address 1
        /// </summary>
        private string address1;

        /// <summary>
        /// Contact's address 1
        /// </summary>
        public string Address1
        {
            get { return this.address1; }
            set
            {
                this.address1 = value;
                this.PropertyChange("Address1");
            }
        }

        #endregion

        #region Address2

        /// <summary>
        /// Contact's address 2
        /// </summary>
        private string address2;

        /// <summary>
        /// Contact's address 2
        /// </summary>
        public string Address2
        {
            get { return this.address2; }
            set
            {
                this.address2 = value;
                this.PropertyChange("Address2");
            }
        }

        #endregion

        #region City

        /// <summary>
        /// Contact's city
        /// </summary>
        private string city;

        /// <summary>
        /// Contact's city
        /// </summary>
        public string City
        {
            get { return this.city; }
            set
            {
                this.city = value;
                this.PropertyChange("City");
            }
        }

        #endregion

        #region State

        /// <summary>
        /// Contact's State
        /// </summary>
        private string state;

        /// <summary>
        /// Contact's State
        /// </summary>
        public string State
        {
            get { return this.state; }
            set
            {
                this.state = value;
                this.PropertyChange("State");
            }
        }

        #endregion

        #region Zip

        /// <summary>
        /// Contact's Zip
        /// </summary>
        private string zip;

        /// <summary>
        /// Contact's Zip
        /// </summary>
        public string Zip
        {
            get { return this.zip; }
            set
            {
                this.zip = value;
                this.PropertyChange("Zip");
            }
        }

        #endregion

        #region Country

        /// <summary>
        /// Contact's Country
        /// </summary>
        private string country;

        /// <summary>
        /// Contact's Country
        /// </summary>
        public string Country
        {
            get { return this.country; }
            set
            {
                this.country = value;
                this.PropertyChange("Country");
            }
        }

        #endregion

        #endregion

        #region ISerializable

        /// <summary>
        /// Desirializes the object
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected Contact(SerializationInfo info, StreamingContext context)
        {
            this.firstName = info.GetString("firstName");
            this.lastName = info.GetString("lastName");
            this.cellPhone = info.GetString("cellPhone");
            this.homePhone = info.GetString("homePhone");
            this.address1 = info.GetString("address1");
            this.address2 = info.GetString("address2");
            this.city = info.GetString("city");
            this.state = info.GetString("state");
            this.zip = info.GetString("zip");
            this.country = info.GetString("country");
        }

        /// <summary>
        /// Serializes the object
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("firstName", this.firstName);
            info.AddValue("lastName", this.lastName);
            info.AddValue("cellPhone", this.cellPhone);
            info.AddValue("homePhone", this.homePhone);
            info.AddValue("address1", this.address1);
            info.AddValue("address2", this.address2);
            info.AddValue("city", this.city);
            info.AddValue("state", this.state);
            info.AddValue("zip", this.zip);
            info.AddValue("country", this.country);
        }

        #endregion

        public override string ToString()
        {
            return "Full Name: " + this.FirstName + " " + this.LastName + "\n" +
                "Cell Phone: " + (this.CellPhone.Length > 0 ? this.CellPhone : "N/A") + " - Home Phone: " + (this.HomePhone.Length > 0 ? this.HomePhone : "N/A") + "\n" +
                "Address 1: " + (this.Address1.Length > 0 ? this.Address1 : "N/A") + "\n" +
                "Address 2: " + (this.Address2.Length > 0 ? this.Address2 : "N/A") + "\n" +
                "City: " + (this.City.Length > 0 ? this.City : "N/A") + " - State: " + (this.State.Length > 0 ? this.State : "N/A") + " - Zip: " + (this.Zip.Length > 0 ? this.Zip : "N/A") + "\n" +
                "Country: " + (this.Country.Length > 0 ? this.Country : "N/A");
        }

        #region ICloneable
        public object Clone()
        {
            Contact x = new Contact();
            x.FirstName = this.FirstName;
            x.LastName = this.LastName;
            x.CellPhone = this.CellPhone;
            x.HomePhone = this.HomePhone;
            x.Address1 = this.Address1;
            x.Address2 = this.Address2;
            x.City = this.City;
            x.State = this.State;
            x.Country = this.Country;
            x.Zip = this.Zip;

            return x;
        }
        #endregion
    }
}
