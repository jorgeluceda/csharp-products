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
        private float ratio = 0;
        private int width = 0;

        public PreferencesDialog()
        {
            InitializeComponent();
        }

        float Ratio
        {
            get { return ratio; }
            set { setRatio(); }
        }

        int Width
        {
            get { return width; }
            set { }
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
            bool result = false;

            String width = this.preferencesWidthTextBox.Text;

            if(width == null || width.Length == 0)
            {
                this.preferencesErrorProvider.SetError(preferencesWidthTextBox, "Please enter a width");
            }

            if (!width.All(char.IsDigit))
            {
                this.preferencesErrorProvider.SetError(preferencesWidthTextBox, "Please enter integers only");
            }

            if (Int32.Parse(width) < 10 || Int32.Parse(width) > 500)
            {
                this.preferencesErrorProvider.SetError(preferencesWidthTextBox, "Width must be between 10 and 500 pixels");
            }
            else
            {
                this.preferencesErrorProvider.SetError(preferencesWidthTextBox, "");
                result = true;
            }

            String height = this.preferencesHeightTextBox.Text;

            if (height == null || height.Length == 0)
            {
                this.preferencesErrorProvider.SetError(preferencesHeightTextBox, "Please enter a height");
            }

            if (!height.All(char.IsDigit))
            {
                this.preferencesErrorProvider.SetError(preferencesHeightTextBox, "Please enter integers only");
            }

            if (Int32.Parse(height) < 10 || Int32.Parse(height) > 500)
            {
                this.preferencesErrorProvider.SetError(preferencesHeightTextBox, "Height must be between 10 and 500 pixels");
            }
            else
            {
                this.preferencesErrorProvider.SetError(preferencesHeightTextBox, "");
                result = true;
            }

            String ratio = this.preferencesRatioTextBox.Text;

            if (ratio == null || ratio.Length == 0)
            {
                this.preferencesErrorProvider.SetError(preferencesRatioTextBox, "Please enter a ratio");
            }

            if (!ratio.All(char.IsDigit))
            {
                this.preferencesErrorProvider.SetError(preferencesRatioTextBox, "Please enter integers only");
            }

            if (Int32.Parse(ratio) < 10 || Int32.Parse(ratio) > 100)
            {
                this.preferencesErrorProvider.SetError(preferencesRatioTextBox, "Ratio must be between 10 and 100");
            }
            else
            {
                this.preferencesErrorProvider.SetError(preferencesRatioTextBox, "");
                result = true;
            }

            return result;

        }

        public void setRatio()
        {
            String width = this.preferencesWidthTextBox.Text;
            String height = this.preferencesHeightTextBox.Text;

            if ( (width != null && width.All(char.IsDigit) && width.Length != 0) &&
                 (height != null && height.All(char.IsDigit) && height.Length != 0) )
                ratio = float.Parse(width) / float.Parse(height);
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

            this.preferencesRatioTextBox.Text = ratio.ToString();

        }

        private void preferencesWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            this.preferencesRatioTextBox.Text = ratio.ToString();

        }

        private void preferencesRatioTextBox_TextChanged(object sender, EventArgs e)
        {
            basedOnRatio();
        }

        public void drawRectangle()
        {
            this.Close();
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
    }
}
