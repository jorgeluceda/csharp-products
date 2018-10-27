using MultiSDIText.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiSDIText
{
    public partial class OptionsForm : Form, IBindingSource
    {
        public BindingSource DataBindingSource
        {
            get { return this.bsText; }
            set { this.bsText = value; }
        }

        public OptionsForm()
        {
            InitializeComponent();
        }
        
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }



        private void colorButton_Click(object sender, EventArgs e)
        {
            if (this.textColorDialog.ShowDialog(this) == DialogResult.OK)
            {
                Text text = (Storage.Text)this.bsText.Current;
                text.Color = this.textColorDialog.Color;

                //Changing button backcolor and font based on color selected
                if (this.textColorDialog.Color.GetBrightness() < 0.5)
                {
                    this.colorButton.ForeColor = Color.White;
                }
                else
                {
                    this.colorButton.ForeColor = Color.Black;
                }

                this.colorButton.BackColor = this.textColorDialog.Color;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void fontButton_Click(object sender, EventArgs e)
        {
            if (this.textFontDialog.ShowDialog(this) == DialogResult.OK)
            {
                Text text = (Storage.Text)this.bsText.Current;
                text.Font = this.textFontDialog.Font;

                //Changing button backcolor and font based on color selected
                if (this.textColorDialog.Color.GetBrightness() < 0.5)
                {
                    this.colorButton.ForeColor = Color.White;
                }
                else
                {
                    this.colorButton.ForeColor = Color.Black;
                }

                this.colorButton.BackColor = this.textColorDialog.Color;
                this.fontButton.Font = text.Font;
            }
        }

        private void backgroundColorButton_Click(object sender, EventArgs e)
        {
            
            if (this.backgroundColorButtonDialog.ShowDialog(this) == DialogResult.OK)
            {
                Text text = (Storage.Text)this.bsText.Current;
                text.BackgroundColor = this.backgroundColorButtonDialog.Color;

                //Changing button backcolor and font based on color selected
                if (this.backgroundColorButtonDialog.Color.GetBrightness() < 0.5)
                {
                    this.backgroundColorButton.ForeColor = Color.White;
                }
                else
                {
                    this.backgroundColorButton.ForeColor = Color.Black;
                }

                this.backgroundColorButton.BackColor = this.backgroundColorButtonDialog.Color;
            }
        }
    }
}

