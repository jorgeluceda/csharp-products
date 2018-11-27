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
            Contact cutContact = new Contact();
            cutContact.FirstName = this.firstNameTextBox.Text;
            cutContact.LastName = this.lastNameTextBox.Text;
            cutContact.CellPhone = this.cellPhoneTextBox.Text;
            cutContact.HomePhone = this.homeTextBox.Text;
            cutContact.Address1 = this.address1TextBox.Text;
            cutContact.Address2 = this.address2TextBox.Text;
            cutContact.City = this.cityTextBox.Text;
            cutContact.State = this.stateTextBox.Text;
            cutContact.Zip = this.zipTextBox.Text;
            cutContact.Country = this.countryTextBox.Text;

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

            Contact x = (Contact)cutContact.Clone();

            using (Stream stream = new FileStream(defaultPath, FileMode.Create, FileAccess.Write))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, x);
            }
        }

        private void copyContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 'Cut' the contact
            Contact cutContact = new Contact();
            cutContact.FirstName = this.firstNameTextBox.Text;
            cutContact.LastName = this.lastNameTextBox.Text;
            cutContact.CellPhone = this.cellPhoneTextBox.Text;
            cutContact.HomePhone = this.homeTextBox.Text;
            cutContact.Address1 = this.address1TextBox.Text;
            cutContact.Address2 = this.address2TextBox.Text;
            cutContact.City = this.cityTextBox.Text;
            cutContact.State = this.stateTextBox.Text;
            cutContact.Zip = this.zipTextBox.Text;
            cutContact.Country = this.countryTextBox.Text;

            Contact x = (Contact)cutContact.Clone();

            using (Stream stream = new FileStream(defaultPath, FileMode.Create, FileAccess.Write))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, x);
            }
        }

        private void pasteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Stream stream = new FileStream(defaultPath, FileMode.Open, FileAccess.Read))
            {
                IFormatter formatter = new BinaryFormatter();
                Contact x = (Contact)formatter.Deserialize(stream);

                this.firstNameTextBox.Text = x.FirstName;
                this.lastNameTextBox.Text = x.LastName;
                this.cellPhoneTextBox.Text = x.CellPhone;
                this.homeTextBox.Text = x.HomePhone;
                this.address1TextBox.Text = x.Address1;
                this.address2TextBox.Text = x.Address2;
                this.cityTextBox.Text = x.City;
                this.stateTextBox.Text = x.State;
                this.zipTextBox.Text = x.Zip;
                this.countryTextBox.Text = x.Country;
            }
        }

        private static string[] parseString(string s)
        {
            string[] tokens = s.Split('\\');
            return tokens;
        }

        private void ContactDetailsForm_DragDrop(object sender, DragEventArgs e)
        {

            string sourceText = (string)e.Data.GetData(typeof(string));
            string[] terms = sourceText.Split('\n');

            //make new contacts object and add it to bindingSource
            Contact newContact = new Contact();
            this.firstNameTextBox.Text = (terms.Length >= 1) ? terms[0].Split(' ')[0] : newContact.FirstName;
            this.lastNameTextBox.Text = (terms.Length >= 1) ? (terms[0].Split(' ').Length > 1) ? terms[0].Split(' ')[1] : newContact.LastName : newContact.LastName;
            this.cellPhoneTextBox.Text = (terms.Length >= 2) ? terms[1] : newContact.CellPhone;
            this.homeTextBox.Text = (terms.Length >= 3) ? terms[2] : newContact.HomePhone;
            this.address1TextBox.Text = (terms.Length >= 4) ? terms[3] : newContact.Address1;
            this.cityTextBox.Text = (terms.Length >= 5) ? terms[4] : newContact.City;
            this.stateTextBox.Text = (terms.Length >= 6) ? terms[5] : newContact.State;
            this.zipTextBox.Text = (terms.Length >= 7) ? terms[6] : newContact.Zip;
            this.countryTextBox.Text = (terms.Length >= 8) ? terms[7] : newContact.Country;

        }

        private void ContactDetailsForm_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Copy;

            }
            else
            {
                e.Effect = DragDropEffects.None;

            }
        }

        private void firstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(firstNameTextBox.Text, "^[a-zA-Z ]"))
            {
                this.errorProvider1.SetError(this.firstNameTextBox, "Please only enter alphabetical charecters");
                firstNameTextBox.Text.Remove(firstNameTextBox.Text.Length - 1);
            }
            else
            {
                this.errorProvider1.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.closeAccept = true;
            this.Close();
        }

        private void lastNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(firstNameTextBox.Text, "^[a-zA-Z ]"))
            {
                this.errorProvider1.SetError(this.firstNameTextBox, "Please only enter alphabetical charecters");
                firstNameTextBox.Text.Remove(firstNameTextBox.Text.Length - 1);
            }
            else
            {
                this.errorProvider1.Dispose();
            }
        }
    }
}
