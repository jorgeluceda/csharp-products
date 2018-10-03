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


        public event EventHandler Apply;        // Event to fire when Apply is pressed

        public PreferencesDialog()
        {
            InitializeComponent();
            
        }


        private void PreferencesDialog_Load(object sender, EventArgs e)
        {
            if (TextColor.GetBrightness() <= 0.6f)
            {
                this.TextColorButton.ForeColor = Color.White;
            }

            if(BackColor.GetBrightness() <= 0.6f)
            {
                this.BackColorButton.ForeColor = Color.White;
            }
            this.TextColorButton.BackColor = TextColor;
            this.BackColorButton.BackColor = BackColor;
            this.TextFontButton.Font = Font;
           
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
                    TextColor = TextColorButton.BackColor;
                    BackColor = TextColorButton.BackColor;
                    Font = TextFontButton.Font;
                    DocumentTitle = DocumentTitleTextBox.Text;
                    DocumentSize = new Size(int.Parse(DocumentSizeWidthTextBox.Text), 
                                            int.Parse(DocumentSizeHeightTextBox.Text));
                    DocumentLocation = new Point(int.Parse(DocumentLocationXTextBox.Text),
                                                    int.Parse(DocumentLocationYTextBox.Text));

                    Apply(this, EventArgs.Empty);
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


        /* TODO: VALIDATION 
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

        */

        private void BackColorButton_Click(object sender, EventArgs e)
        {
            //Show the dialog
            DialogResult result = preferencesBackColorDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                //Get color
                Color color = preferencesBackColorDialog.Color;
                //set Color properties
                this.BackColorButton.BackColor = color;
            }

        }

        private void TextFontButton_Click(object sender, EventArgs e)
        {
            // Show the dialog.
            DialogResult result = preferencesFontDialog.ShowDialog();
            // See if OK was pressed.
            if (result == DialogResult.OK)
            {
                // Get Font.
                Font font = preferencesFontDialog.Font;
                // Set TextBox properties.
                this.TextFontButton.Font = font;
            }
        }

        private void TextColorButton_Click(object sender, EventArgs e)
        {
            //Show the dialog
            DialogResult result = preferencesTextColorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                //Get color
                Color color = preferencesTextColorDialog.Color;
                //set Color properties
                this.TextColorButton.BackColor = color;
            }

        }
    }
}