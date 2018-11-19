using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiSDIContact.Services.Entities;


namespace MultiSDIContact
{
    public partial class ContactDetailsForm : Form, IBindingSource
    {
        public bool deleteClicked = false;
        public bool canDelete = false;
        public bool closeAccept = false;

        #region Data Binding
        public BindingSource DataBindingSource
        {
            get { return this.contactBindingSource; }
            set { this.contactBindingSource = value; }
        }

        void InitializeManualBindings()
        {
            this.firstNameTextBox.DataBindings.Add("Text", this.contactBindingSource, "firstName");
            this.lastNameTextBox.DataBindings.Add("Text", this.contactBindingSource, "lastName");
            this.address1TextBox.DataBindings.Add("Text", this.contactBindingSource, "address1");
            this.address2TextBox.DataBindings.Add("Text", this.contactBindingSource, "address2");
            this.homeTextBox.DataBindings.Add("Text", this.contactBindingSource, "homePhone");
            this.cellPhoneTextBox.DataBindings.Add("Text", this.contactBindingSource, "cellPhone");
            this.cityTextBox.DataBindings.Add("Text", this.contactBindingSource, "city");
            this.stateTextBox.DataBindings.Add("Text", this.contactBindingSource, "state");
            this.zipTextBox.DataBindings.Add("Text", this.contactBindingSource, "zip");
            this.countryTextBox.DataBindings.Add("Text", this.contactBindingSource, "country");
        } 
        #endregion

        #region Contructor

        public ContactDetailsForm()
        {

            InitializeComponent();

            //two modes - edit or add mode
            //add mode cannot delete a contact
            //allow deletion based on mode
            deleteButton.Enabled = canDelete;

            InitializeManualBindings();
        }
        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {
            this.closeAccept = true;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            closeAccept = false;
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteClicked = true;
            this.Close();
        }
    }
}
