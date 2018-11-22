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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace MultiSDIContact
{
    public partial class ContactDetailsForm : Form, IBindingSource
    {
        public bool deleteClicked = false;
        public bool canDelete = false;
        public bool closeAccept = false;
        string defaultPath = "C:\\buffer";

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

        private void cutContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 'Cut' the contact
            string rawContactData =
                   "" + this.firstNameTextBox.Text + "\\"
                   + this.lastNameTextBox.Text + "\\"
                   + this.cellPhoneTextBox.Text + "\\"
                   + this.homeTextBox.Text + "\\"
                   + this.address1TextBox.Text + "\\"
                   + this.address2TextBox.Text + "\\"
                   + this.cityTextBox.Text + "\\"
                   + this.stateTextBox.Text + "\\"
                   + this.zipTextBox.Text + "\\"
                   + this.countryTextBox.Text;

            this.firstNameTextBox.Text = "";
            this.lastNameTextBox.Text = "";
            this.cellPhoneTextBox.Text = "";
            this.homeTextBox.Text = "";
            this.address1TextBox.Text = "";
            this.address2TextBox.Text = "";
            this.cityTextBox.Text = "";
            this.stateTextBox.Text = "";
            this.zipTextBox.Text = "";
            this.countryTextBox.Text = "";

            using (Stream stream = new FileStream(defaultPath, FileMode.Create, FileAccess.Write))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, rawContactData);
            }
        }

        private void copyContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 'Cut' the contact
            string rawContactData =
                   "" + this.firstNameTextBox.Text + "\\"
                   + this.lastNameTextBox.Text + "\\"
                   + this.cellPhoneTextBox.Text + "\\"
                   + this.homeTextBox.Text + "\\"
                   + this.address1TextBox.Text + "\\"
                   + this.address2TextBox.Text + "\\"
                   + this.cityTextBox.Text + "\\"
                   + this.stateTextBox.Text + "\\"
                   + this.zipTextBox.Text + "\\"
                   + this.countryTextBox.Text;

            using (Stream stream = new FileStream(defaultPath, FileMode.Create, FileAccess.Write))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, rawContactData);
            }
        }

        private void pasteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Stream stream = new FileStream(defaultPath, FileMode.Open, FileAccess.Read))
            {
                IFormatter formatter = new BinaryFormatter();
                string rawContactData = (string)formatter.Deserialize(stream);

                string[] contactData = parseString(rawContactData);

                this.firstNameTextBox.Text = contactData[0];
                this.lastNameTextBox.Text = contactData[1];
                this.cellPhoneTextBox.Text = contactData[2];
                this.homeTextBox.Text = contactData[3];
                this.address1TextBox.Text = contactData[4];
                this.address2TextBox.Text = contactData[5];
                this.cityTextBox.Text = contactData[6];
                this.stateTextBox.Text = contactData[7];
                this.zipTextBox.Text = contactData[8];
                this.countryTextBox.Text = contactData[9];
            }
        }

        private static string[] parseString(string s)
        {
            string[] tokens = s.Split('\\');
            return tokens;
        }
    }
}
