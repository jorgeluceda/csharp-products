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

        private void MainForm_FormClosing(object sender, EventArgs e)
        {
            MessageBox.Show("hi");
        }
        private void btnAddName_Click(object sender, System.EventArgs e)
        {
            AddNameToListView();
            textBox1.Focus(); // allow focus change on button click

        }

        #endregion

        #region Helpers

        private void CustomInitialization()
        {
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";


            this.ClientSize = new Size(CustomUserSettings.MainFormClientSizeWidth, CustomUserSettings.MainFormClientSizeHeight);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(CustomUserSettings.MainFormLocationX, CustomUserSettings.MainFormLocationY);

            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider();
            this.nameErrorProvider.SetIconAlignment(this.textBox1, ErrorIconAlignment.MiddleRight);
            this.nameErrorProvider.SetIconPadding(this.textBox1, 2);
            this.nameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;

            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            this.lvNamesList.Scrollable = true;
            this.lvNamesList.View = View.Details;
            this.lvNamesList.Columns.Add(header);
            this.lvNamesList.HeaderStyle = ColumnHeaderStyle.None;

            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
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
    }
}
