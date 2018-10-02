using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreLibrary;
using SingleDocumentInterface.Documents;

namespace SingleDocumentInterface
{

    public partial class PreferencesDialog : BaseForm
    {
        public Color TextColor { get; set; }
        //Already present in base form
        //Color BackColor { get; set; }
        public Point DocumentLocation { get; set; }
        public string DocumentTitle { get; set; }
        public Size DocumentSize { get; set; }

        //already present in base form
        //Font Font { get; set; }

        int ShapeHeight = 0;
        int ShapeWidth = 0;
        int ShapeRatio = 0;
        String color = "";
        String backgroundColor = "";


        public event EventHandler Apply;        // Event to fire when Apply is pressed

        public PreferencesDialog()
        {
            InitializeComponent();
            
        }


        private void PreferencesDialog_Load(object sender, EventArgs e)
        {
            //initializing values
            //preferencesWidthTextBox.Text = Properties.Settings.Default.PreferredWidth.ToString();
            //preferencesHeightTextBox.Text = Properties.Settings.Default.PreferredHeight.ToString();
            //preferencesRatioTextBox.Text = Properties.Settings.Default.PreferredRatio.ToString();
        }
        /**
         *  OK button click handler for PreferencesDialog
         */
        private void preferencesOkButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                //no need for modal check, is always modeless by design
                preferencesApplyButton_Click(sender, e);
                
            }

            this.Close();
        }

        /**
         *  Apply button click handler for PreferencesDialog 
         */
        private void preferencesApplyButton_Click(object sender, EventArgs e)
        {
            if (Apply != null)
            {
                if (this.ValidateChildren())
                {
                    color = this.preferencesBackColorTextBox.Text;
                    backgroundColor = this.preferencesBackColorTextBox.Text;

                    //not font & background color same allowed
                    if(color.CompareTo(backgroundColor) != 0)
                    
                    if (!this.Modal)
                    {
                        Apply(this, EventArgs.Empty);
                    }
                }
            }
        }

        /**
         *  Cancel button click handler for PreferencesDialog 
         */
        private void preferencesCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setRatio()
        {
            String width = this.preferencesBackColorTextBox.Text;
            String height = this.preferencesFontTextBox.Text;

            //if ( (width != null && width.All(char.IsDigit) && width.Length != 0) &&
              //   (height != null && height.All(char.IsDigit) && height.Length != 0) )
                //ShapeRatio = float.Parse(width) / float.Parse(height);
        }

        private void validateNumberField(TextBox textBox, System.ComponentModel.CancelEventArgs e, double min, double max)
        {
            String checkControl = textBox.Text;
            preferencesErrorProvider.SetError(textBox, "");

            if(checkControl == null || checkControl.Length == 0)
            {
                preferencesErrorProvider.SetError(textBox, "Please enter a value");
                e.Cancel = true;
            }
            else if (!checkControl.All(char.IsDigit))
            {
                preferencesErrorProvider.SetError(textBox, "Please enter numbers only");
                e.Cancel = true;
            }
            else if(double.Parse(checkControl) < min || double.Parse(checkControl) > max)
            {
                preferencesErrorProvider.SetError(textBox, "Please enter a number between " + min + " and " + max + ".");
                e.Cancel = true;
            }
        }

        private void preferencesBackColor_Validating(object sender, CancelEventArgs e)
        {
            validateNumberField(preferencesBackColorTextBox, e, 10, 700);
        }

        private void preferencesFont_Validating(object sender, CancelEventArgs e)
        {
            validateNumberField(preferencesFontTextBox, e, 10, 700);
        }

        private void preferencesTextColor_Validating(object sender, CancelEventArgs e)
        {
            validateNumberField(preferencesTextColorTextBox, e, 0.1, 100);
        }

        private

    }
}