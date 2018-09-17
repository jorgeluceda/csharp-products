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
            }

        }

        private void preferencesApplyButton_Click(object sender, EventArgs e)
        {

            if (validateForm())
            {
                Console.Write("Process result");
            }

        }

        private void preferencesCancelButton_Click(object sender, EventArgs e)
        {

        }

        public bool validateForm()
        {

            String width = this.preferencesWidthTextBox.Text;

            if (width == null || width.Length == 0 || !width.All(char.IsDigit) || 
                Int32.Parse(width) < 10 || Int32.Parse(width) > 500)
            {
                this.preferencesErrorProvider.SetError(preferencesWidthTextBox, "Invalid Width");
                return false;

            }

            String height = this.preferencesHeightTextBox.Text;

            if (height == null || height.Length == 0 || !height.All(char.IsDigit) ||
                Int32.Parse(height) < 10 || Int32.Parse(height) > 500)
            {
                this.preferencesErrorProvider.SetError(preferencesHeightTextBox, "Invalid Height");
                return false;

            }

            String ratio = this.preferencesRatioTextBox.Text;

            if (ratio == null || ratio.Length == 0 || !ratio.All(char.IsDigit) ||
                Int32.Parse(ratio) < 10 || Int32.Parse(ratio) > 100)
            {
                this.preferencesErrorProvider.SetError(preferencesRatioTextBox, "Invalid Ratio");
                return false;

            }

            return true;

        }
    }
}
