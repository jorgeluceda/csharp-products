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
    public partial class PreferencesDialog : BaseForm
    {
        public PreferencesDialog()
        {
            InitializeComponent();
        }

        

        private void PreferencesDialog_Load(object sender, EventArgs e)
        {

        }

        private void preferencesOkButton_Click(object sender, EventArgs e)
        {

            if (validateForm())
            {
                Console.Write("Process result");
                this.Close();
            }


        }

        private void preferencesApplyButton_Click(object sender, EventArgs e)
        {

            if (validateForm())
            {
                drawRectangle();
                Console.Write("Process result");
            }

        }

        private void preferencesCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool validateForm()
        {
            bool result = true;

            String width = this.preferencesWidthTextBox.Text;

            if (width == null || width.Length == 0 || !width.All(char.IsDigit) || 
                Int32.Parse(width) < 10 || Int32.Parse(width) > 500)
            {
                this.preferencesErrorProvider.SetError(preferencesWidthTextBox, "Invalid Width");
                result = false;
            }
            else
            {
                this.preferencesErrorProvider.SetError(preferencesWidthTextBox, null);
            }

            String height = this.preferencesHeightTextBox.Text;

            if (height == null || height.Length == 0 || !height.All(char.IsDigit) ||
                Int32.Parse(height) < 10 || Int32.Parse(height) > 500)
            {
                this.preferencesErrorProvider.SetError(preferencesHeightTextBox, "Invalid Height");
                result = false;
            }
            else
            {
                this.preferencesErrorProvider.SetError(preferencesHeightTextBox, null);
            }

            String ratio = this.preferencesRatioTextBox.Text;

            if (ratio == null || ratio.Length == 0 || !ratio.All(char.IsDigit) ||
                Int32.Parse(ratio) < 10 || Int32.Parse(ratio) > 100)
            {
                this.preferencesErrorProvider.SetError(preferencesRatioTextBox, "Invalid Ratio");
                result = false;
            }
            else
            {
                this.preferencesErrorProvider.SetError(preferencesRatioTextBox, null);
            }

            return result;

        }

        public float setRatio()
        {

            String width = this.preferencesWidthTextBox.Text;
            String height = this.preferencesHeightTextBox.Text;

            float result = 0;
            if ( (width != null && width.All(char.IsDigit) && width.Length != 0) &&
                 (height != null && height.All(char.IsDigit) && height.Length != 0) )
                result = float.Parse(width) / float.Parse(height);

                return result;
        }

        public void basedOnRatio()
        {
            String  width = this.preferencesWidthTextBox.Text;
            String height = this.preferencesHeightTextBox.Text;

            float result = 0;

            if (width != null && width.All(char.IsDigit) && width.Length != 0)
            {
                result = float.Parse(width);

            }
            else if(height != null && height.All(char.IsDigit) && height.Length != 0)
            {
                result = float.Parse(height);

            }

        }

        private void preferencesHeightTextBox_TextChanged(object sender, EventArgs e)
        {

            this.preferencesRatioTextBox.Text = setRatio().ToString();

        }

        private void preferencesWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            this.preferencesRatioTextBox.Text = setRatio().ToString();

        }

        private void preferencesRatioTextBox_TextChanged(object sender, EventArgs e)
        {
            basedOnRatio();
        }

        public void drawRectangle()
        {
            //Rectangle rect = this.ClientRectangle();
            this.Close();


        }

        private void validateNumberField(TextBox textBox, System.ComponentModel.CancelEventArgs e, double min, double max)
        {
            String checkControl = textBox.Text;
            preferencesErrorProvider.SetError(textBox, "");

            if (checkControl == null || checkControl.Length == 0 || !checkControl.All(char.IsDigit) ||
               double.Parse(checkControl) < min || double.Parse(checkControl) > max)
            {
                preferencesErrorProvider.SetError(textBox,"Invalid Input");
                e.Cancel = true;
            }
        }

        private void preferencesWidthTextBox_Validating(object sender, CancelEventArgs e)
        {
            validateNumberField(preferencesWidthTextBox, e, 10, this.ClientSize.Width);
        }

        private void preferencesHeightTextBox_Validating(object sender, CancelEventArgs e)
        {
            validateNumberField(preferencesHeightTextBox, e, 10, this.ClientSize.Height);
        }

        private void preferencesRatioTextBox_Validating(object sender, CancelEventArgs e)
        {
            validateNumberField(preferencesRatioTextBox, e, 0.1, 100);
        }
    }
}
