using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using MultiSDIText.Storage;
using System.IO;

namespace MultiSDIText
{
    public partial class TextOptions : Form, IBindingSource
    {
        public bool closeAccept = false;
        public int bringToInt = 0; //0 -> none, 1-> send to back , 2 -> bring to front
        public int boundZOrder;

        //Using Interop to make a custom cursor called AnimatedCursor
        [DllImport("user32.dll")]
        static extern IntPtr LoadCursorFromFile(string lpFileName);
        static Cursor ColoredCursor;

        public BindingSource DataBindingSource
        {
            get { return this.bsDocument; }
            set { this.bsDocument = value; }
        }

        BindingManagerBase BindingManager
        {

            get {
                return this.BindingContext[this.bsDocument];
            }
        }


        public TextOptions()
        {
            InitializeComponent();


            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            radioButtonName.Checked = true;
            this.listBoxDoc.DisplayMember = "Content";


            RefreshItems();
        }

        static TextOptions()
        {
            //Getting the path to the animated cursor from Resources
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\bookCursor.cur", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            //Load Animated Cursor
            IntPtr cursor = LoadCursorFromFile(FileName);
            ColoredCursor = new Cursor(cursor);
        }

        public void RefreshItems()
        {
            int count = this.DataBindingSource.Count;
            int pos = this.DataBindingSource.Position + 1;

            this.labelCount.Text = count.ToString();
            this.labelPosition.Text = pos.ToString();

            this.buttonFirst.Enabled = (pos > 1);
            this.buttonPrev.Enabled = (pos > 1);
            this.buttonNext.Enabled = (pos < count);
            this.buttonLast.Enabled = (pos < count);
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            this.DataBindingSource.Position = 0;
            RefreshItems();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            --this.DataBindingSource.Position;
            RefreshItems();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            ++this.DataBindingSource.Position;
            RefreshItems();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            this.DataBindingSource.Position = this.DataBindingSource.Count - 1;
            RefreshItems();
        }

        private void radioButtonDefault_CheckedChanged(object sender, EventArgs e)
        {
            listBoxDoc.DisplayMember = "Content";
        }

        private void radioButtonName_CheckedChanged(object sender, EventArgs e)
        {
            listBoxDoc.DisplayMember = "Content";
        }

        private void radioButtonLocation_CheckedChanged(object sender, EventArgs e)
        {
            listBoxDoc.DisplayMember = "Location";
        }

        private void radioButtonZOrder_CheckedChanged(object sender, EventArgs e)
        {
            listBoxDoc.DisplayMember = "ZOrder";
        }

        private void radioButtonTextFont_CheckedChanged(object sender, EventArgs e)
        {
            listBoxDoc.DisplayMember = "Font";
        }

        private void radioButtonTextColor_CheckedChanged(object sender, EventArgs e)
        {
            listBoxDoc.DisplayMember = "Color";
        }

        private void radioButtonBackgroundColor_CheckedChanged(object sender, EventArgs e)
        {
            listBoxDoc.DisplayMember = "BackgroundColor";
        }


        private void textColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Color textColor = dlg.Color;

                //edit current text color here;
                //this.shapeData.PenColor = penColor;

                /*
                if (textColor.GetBrightness() < 0.5)
                {
                    this.textColorButton.ForeColor = Color.White;
                }
                else
                {
                    this.textColorButton.ForeColor = Color.Black;
                }
                */

                this.textColorButton.ForeColor = textColor;
            }
        }

        private void backgroundColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Color backColor = dlg.Color;

                //edit current text color here;
                //this.shapeData.PenColor = penColor;

                if (backColor.GetBrightness() < 0.5)
                {
                    this.backgroundColorButton.ForeColor = Color.White;
                }
                else
                {
                    this.backgroundColorButton.ForeColor = Color.Black;
                }

                this.backgroundColorButton.BackColor = backColor;
            }

        }

        private void textFontButton_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Font font = dlg.Font;

                this.textFontButton.Font = font;
            }
        }

        private void OkOptionsButton_Click(object sender, EventArgs e)
        {
            closeAccept = true;
            this.Close();
        }

        private void cancelOptionsButton_Click(object sender, EventArgs e)
        {
            closeAccept = false;
            this.Close();
        }

        private void buttonSendToBack_Click(object sender, EventArgs e)
        {
            bringToInt = 1; //send to back
            this.boundZOrder = (int)buttonSendToBack.Tag;


        }

        private void buttonBringToFront_Click(object sender, EventArgs e)
        {
            bringToInt = 2; //bring to front
            this.boundZOrder = (int)buttonBringToFront.Tag;

        }

        private void textBoxLocation_Validating(object sender, CancelEventArgs e)
        {
            int[] textMatches = new int[0];
            try
            {
                textMatches = Array.ConvertAll<string, int>(textBoxLocation.Text.Split(','), Convert.ToInt32);
            } catch (FormatException)
            {
                preferencesErrorProvider.SetError(textBoxLocation, "Please, enter a valid pair of coordinates: X, Y");


            }


            if (textBoxLocation.Text == null ||
                textMatches.Count() < 2 ||
                textMatches.Count() > 2)
            {
                 preferencesErrorProvider.SetError(textBoxLocation, "Please, enter a valid pair of coordinates: X, Y");
            }

        }

        //WHen mouse is on the form's field
        private void TextOptions_MouseEnter(object sender, EventArgs e)
        {
            //Changes cursor to the book cursor
            this.Cursor = ColoredCursor;
        }
    }

}