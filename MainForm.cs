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
    public partial class MainForm : Form
    {
        private const int MAX_NAME_LENGTH = 15;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Listeners

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.CustomInitialization();
        }
        private void btnAddName_Click(object sender, EventArgs e)
        {
            AddNameToListView();
            textBox1.Focus(); // allow focus change on button click

        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            this.Show(); //show the form
            this.Activate(); //activate the form

        }

        private void MainForm_FormClosing(object sender, EventArgs e)
        {
            Form testForm = new Form();
            testForm.ShowDialog();
            Console.WriteLine("works");
        }

        #endregion

        #region Helpers

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

            this.ClientSize = new Size(CustomUserSettings.MainFormClientSizeWidth, CustomUserSettings.MainFormClientSizeHeight);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(CustomUserSettings.MainFormLocationX, CustomUserSettings.MainFormLocationY);

            
            //notifyIcon setup
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon1.Icon = Properties.Resources.Notify3Icon;
            this.notifyIcon1.ContextMenu = this.contextMenu1;
            this.notifyIcon1.Text = "Form1 (NotifyIcon example)";
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

        private void AddNameToListView()
        {
            bool bValidName = ValidateName();
            if (bValidName)
            {
                lvNamesList.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }

        }

        void MainForm_FormClosingEvent(object sender, FormClosedEventArgs e)
        {
            // Do stuff here
        }
        #endregion

        #region Validation
        protected void textBox1_Validating(object sender,
           System.ComponentModel.CancelEventArgs e)
        {
            ValidateName();
        }

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
            }
            else
            {
                nameErrorProvider.SetError(textBox1, "");
                validNameStatus = true;
            }
            return validNameStatus;
        }
        #endregion

        #region Button Save and Reset
        private void btnSaveSize_Click(object sender, EventArgs e)
        {
            CustomUserSettings.MainFormClientSizeWidth = this.ClientSize.Width;
            CustomUserSettings.MainFormClientSizeHeight = this.ClientSize.Height;
            Properties.Settings.Default.Save();
        }

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

        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            CustomUserSettings.MainFormLocationX = this.DesktopLocation.X;
            CustomUserSettings.MainFormLocationY = this.DesktopLocation.Y;
            Properties.Settings.Default.Save();
        }
        #endregion

    }
}
