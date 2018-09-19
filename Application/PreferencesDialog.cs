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

namespace Application
{
    public partial class PreferencesDialog : BaseForm, ITeam3Interface
    {
        public float ShapeRatio { get; set; }
        public int ShapeWidth { get; set; }
        public int ShapeHeight { get; set; }
        public event EventHandler Apply;        // Event to fire when Apply is pressed

        public PreferencesDialog()
        {
            InitializeComponent();
        }

        /**
         *  OK button click handler for PreferencesDialog
         */
        private void preferencesOkButton_Click(object sender, EventArgs e)
        {
            if (this.Modal)
            {
                this.DialogResult = DialogResult.OK;
                ShapeHeight = int.Parse(this.preferencesHeightTextBox.Text);
                ShapeWidth = int.Parse(this.preferencesWidthTextBox.Text);
                ShapeRatio = float.Parse(this.preferencesRatioTextBox.Text);
            }
            else
            {
                preferencesApplyButton_Click(sender, e);
                this.Close();
            }
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
                    ShapeHeight = int.Parse(this.preferencesHeightTextBox.Text);
                    ShapeWidth = int.Parse(this.preferencesWidthTextBox.Text);
                    ShapeRatio = float.Parse(this.preferencesRatioTextBox.Text);
                    Apply(this, EventArgs.Empty);
                }
            }
        }

        /**
         *  Cancel button click handler for PreferencesDialog 
         */
        private void preferencesCancelButton_Click(object sender, EventArgs e)
        {
            if (this.Modal)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                this.Close();
            }
        }

        public void setRatio()
        {
            String width = this.preferencesWidthTextBox.Text;
            String height = this.preferencesHeightTextBox.Text;

            if ( (width != null && width.All(char.IsDigit) && width.Length != 0) &&
                 (height != null && height.All(char.IsDigit) && height.Length != 0) )
                ShapeRatio = float.Parse(width) / float.Parse(height);
        }

        //public void SetDimensions()
        //{
        //    String width = this.preferencesWidthTextBox.Text;
        //    String height = this.preferencesHeightTextBox.Text;

        //    if (width != null && width.All(char.IsDigit) && width.Length != 0)
        //    {
        //        Width = int.Parse(width);

        //    }
        //    else if(height != null && height.All(char.IsDigit) && height.Length != 0)
        //    {
        //        Height = int.Parse(height);

        //    }

        //}

        //private void preferencesHeightTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    if(this.preferencesWidthTextBox.Text.Length != 0 && this.preferencesRatioTextBox.Text.Length == 0)
        //    {
        //        // update ratio text box
        //    }
        //    if(this.preferencesWidthTextBox.Text.Length == 0 && this.preferencesRatioTextBox.Text.Length != 0)
        //    {
        //        // update width text box
        //    }
        //}

        //private void preferencesWidthTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    if (this.preferencesHeightTextBox.Text.Length != 0 && this.preferencesRatioTextBox.Text.Length == 0)
        //    {
        //        // update ratio text box
        //    }
        //    if (this.preferencesHeightTextBox.Text.Length == 0 && this.preferencesRatioTextBox.Text.Length != 0)
        //    {
        //        // update height text box
        //    }
        //}

        //private void preferencesRatioTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    if (this.preferencesHeightTextBox.Text.Length != 0 && this.preferencesWidthTextBox.Text.Length == 0)
        //    {
        //        // update width text box
        //    }
        //    if (this.preferencesHeightTextBox.Text.Length == 0 && this.preferencesWidthTextBox.Text.Length != 0)
        //    {
        //        // update height text box
        //    }
        //}

        //private int calculateWidth()
        //{
        //    int height = int.Parse(this.preferencesHeightTextBox.Text);     // Grab the height from the textbox
        //    float ratio = float.Parse(this.preferencesRatioTextBox.Text);   // Grab the ratio from the textbox


        //    return 
        //}

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

        private void preferencesWidthTextBox_Validating(object sender, CancelEventArgs e)
        {
            validateNumberField(preferencesWidthTextBox, e, 10, 700);
        }

        private void preferencesHeightTextBox_Validating(object sender, CancelEventArgs e)
        {
            validateNumberField(preferencesHeightTextBox, e, 10, 700);
        }

        private void preferencesRatioTextBox_Validating(object sender, CancelEventArgs e)
        {
            validateNumberField(preferencesRatioTextBox, e, 0.1, 100);
        }

        private void PreferencesDialog_Load(object sender, EventArgs e)
        {
            if (this.Modal)
            {
                this.preferencesApplyButton.Visible = false;
            }
        }

        private void PreferencesDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }
    }
}
