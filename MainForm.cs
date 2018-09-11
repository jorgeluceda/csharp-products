using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application
{
    /*
    The MainForm partial class called in Program.cs
    Contains our form, event handlers, initialization, 
    and validation.
    */
    public partial class MainForm : Form
    {
        private const int MAX_NAME_LENGTH = 15;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;

        // MainForm constructor, do not modify InitializeComponent()
        public MainForm()
        {
            InitializeComponent();
        }

        #region Listeners

        // Our main loading method, modify customInitialization
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.CustomInitialization();
        }

        // Click event handler for add name button
        private void btnAddName_Click(object sender, EventArgs e)
        {
            AddNameToListView();
            textBox1.Focus(); // allow focus change on button click

        }

        // Form closing handler that displays message box
        private void MainForm_FormClosing(object sender, CancelEventArgs e)
        {

            if (lvNamesList.Items.Count >= 1)
            {
                DialogResult result = MessageBox.Show("The list has been updated, are you sure you want to quit?", 
                                        "", MessageBoxButtons.OKCancel);
                e.Cancel = (result == DialogResult.Cancel);
            }
        }

        // Hides our form when it is called (usually when out of focus)
        private void MainForm_Deactivate(object sender, System.EventArgs e)
        {
            this.Hide();
        }

        // NotifyIcon handler for when it is clicked
        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            this.Show(); //show the form
            this.Activate(); //activate the form

        }
        #endregion

        #region Helpers
        //custonInitialization() to be used instead of InitializeComponent()
        //as our custom way of Initializing our component.
        private void CustomInitialization()
        {

            //create container component
            this.components = new System.ComponentModel.Container();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();

            ColumnHeader header = new ColumnHeader
            {
                Text = "",
                Name = "col1"
            };

            //set the client size and with based on custom user settings if needed.
            this.ClientSize = new Size(CustomUserSettings.MainFormClientSizeWidth, CustomUserSettings.MainFormClientSizeHeight);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(CustomUserSettings.MainFormLocationX, CustomUserSettings.MainFormLocationY);

            
            //notifyIcon setup
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon1.Icon = Properties.Resources.Notify3Icon;
            this.notifyIcon1.ContextMenu = this.contextMenu1;
            this.notifyIcon1.Text = "User Settings";
            this.notifyIcon1.Visible = true;

            //nameErrorProvider
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider();
            this.nameErrorProvider.SetIconAlignment(this.textBox1, ErrorIconAlignment.MiddleRight);
            this.nameErrorProvider.SetIconPadding(this.textBox1, 2);
            this.nameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;

            //validating textbox
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);

            //lvNamesList
            this.lvNamesList.Scrollable = true;
            this.lvNamesList.View = View.Details;
            this.lvNamesList.Columns.Add(header);
            this.lvNamesList.HeaderStyle = ColumnHeaderStyle.None;

            //button click handlers
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            this.btnSaveSize.Click += new System.EventHandler(this.btnSaveSize_Click);
            this.btnResetSettings.Click += new System.EventHandler(this.btnResetSettings_Click);
            this.btnSaveLocation.Click += new System.EventHandler(this.btnSaveLocation_Click);
            this.notifyIcon1.Click += new System.EventHandler(this.NotifyIcon_Click);
        }

        // adds a name to our list view if correctly validated
        private void AddNameToListView()
        {
            bool bValidName = ValidateName();
            if (bValidName)
            {
                lvNamesList.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }

        }
        #endregion

        // called our validation method for the textbox when CancelEventArgs is handled
        #region Validation
        protected void textBox1_Validating(object sender,
           System.ComponentModel.CancelEventArgs e)
        {
            ValidateName();
        }

        // Validates a name based on the guidelines provided
        protected bool ValidateName()
        {
            bool validNameStatus = true;

            if (textBox1.Text == "")
            {
                nameErrorProvider.SetError(textBox1, "Please Enter Your Name");
                validNameStatus = false;
            }
            else if (textBox1.Text.Length > MAX_NAME_LENGTH)
            {
                nameErrorProvider.SetError(textBox1, "Please Enter A Name No Longer Than 15 Characters");
                validNameStatus = false;
            }
            else if (textBox1.Text.Contains(" "))
            {
                nameErrorProvider.SetError(textBox1, "Please Enter a Name Without Spaces");
                validNameStatus = false;
            } else
            {
                nameErrorProvider.SetError(textBox1, "");
                validNameStatus = true;
            }
            return validNameStatus;
        }
        #endregion

        #region Button Save and Reset
        // saves the our form client width and height based on handler
        private void btnSaveSize_Click(object sender, EventArgs e)
        {
            CustomUserSettings.MainFormClientSizeWidth = this.ClientSize.Width;
            CustomUserSettings.MainFormClientSizeHeight = this.ClientSize.Height;
            Properties.Settings.Default.Save();
        }

        // resets all of our custom form settings based on handler
        private void btnResetSettings_Click(object sender, EventArgs e)
        {
            int defaultWidth = 321;
            int defaultHeight = 300;
            int defaultX = 0;
            int defaultY = 0;

            this.ClientSize = new Size(defaultWidth, defaultHeight);
            this.DesktopLocation = new Point(defaultX, defaultY);

            CustomUserSettings.MainFormClientSizeWidth = defaultWidth;
            CustomUserSettings.MainFormClientSizeHeight = defaultHeight;
            CustomUserSettings.MainFormLocationX = defaultX;
            CustomUserSettings.MainFormLocationY = defaultY;
            Properties.Settings.Default.Save();
        }

        // saves the location of our form client based on its desktop location
        // using handler
        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            CustomUserSettings.MainFormLocationX = this.DesktopLocation.X;
            CustomUserSettings.MainFormLocationY = this.DesktopLocation.Y;
            Properties.Settings.Default.Save();
        }
        #endregion

    }
}
