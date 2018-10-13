using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiSDI
{
    public partial class ShapeOptions : Form/*, IBindingSource*/
    {
        public ShapeOptions()
        {
            InitializeComponent();
        }

        //public BindingSource DataBindingSource
        //{
        //    get { return this.shapeBindingSource; }
        //    set { this.shapeBindingSource = value; }
        //}

        #region Colors
        private void penColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                Color penColor = dlg.Color;

                if(penColor.GetBrightness() < 0.5)
                {
                    this.penColorButton.ForeColor = Color.White;
                }
                else
                {
                    this.penColorButton.ForeColor = Color.Black;
                }

                this.penColorButton.BackColor = penColor;
            }
        }

        private void brushColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Color brushColor = dlg.Color;

                if (brushColor.GetBrightness() < 0.5)
                {
                    this.brushColorButton.ForeColor = Color.White;
                }
                else
                {
                    this.brushColorButton.ForeColor = Color.Black;
                }

                this.brushColorButton.BackColor = brushColor;
            }
        }
        #endregion

        #region OK/Cancel
        private void okButton_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Validating Events
        private void shapeXTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Check if anything was entered
            if (!string.IsNullOrWhiteSpace(this.shapeXTextBox.Text) || !string.IsNullOrEmpty(this.shapeXTextBox.Text))
            {
                // Check if an integer was entered
                int temp;
                if (!int.TryParse(this.shapeXTextBox.Text, out temp))
                {
                    this.shapeOptionsErrorProvider.SetError(this.shapeXTextBox, "Please enter a whole number");
                }
            }
            else
            {
                this.shapeOptionsErrorProvider.SetError(this.shapeXTextBox, "Please enter an X coordinate");
            }
        }

        private void shapeYTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Check if anything was entered
            if (!string.IsNullOrWhiteSpace(this.shapeYTextBox.Text) || !string.IsNullOrEmpty(this.shapeYTextBox.Text))
            {
                // Check if an integer was entered
                int temp;
                if (!int.TryParse(this.shapeYTextBox.Text, out temp))
                {
                    this.shapeOptionsErrorProvider.SetError(this.shapeYTextBox, "Please enter a whole number");
                }
            }
            else
            {
                this.shapeOptionsErrorProvider.SetError(this.shapeYTextBox, "Please enter a Y coordinate");
            }
        }

        private void shapeWidthTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Check if anything was entered
            if (!string.IsNullOrWhiteSpace(this.shapeWidthTextBox.Text) || !string.IsNullOrEmpty(this.shapeWidthTextBox.Text))
            {
                // Check if an integer was entered
                int temp;
                if (!int.TryParse(this.shapeWidthTextBox.Text, out temp))
                {
                    this.shapeOptionsErrorProvider.SetError(this.shapeWidthTextBox, "Please enter a whole number");
                }
            }
            else
            {
                this.shapeOptionsErrorProvider.SetError(this.shapeWidthTextBox, "Please enter a width");
            }
        }

        private void shapeHeightTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Check if anything was entered
            if (!string.IsNullOrWhiteSpace(this.shapeHeightTextBox.Text) || !string.IsNullOrEmpty(this.shapeHeightTextBox.Text))
            {
                // Check if an integer was entered
                int temp;
                if (!int.TryParse(this.shapeHeightTextBox.Text, out temp))
                {
                    this.shapeOptionsErrorProvider.SetError(this.shapeHeightTextBox, "Please enter a whole number");
                }
            }
            else
            {
                this.shapeOptionsErrorProvider.SetError(this.shapeHeightTextBox, "Please enter a height");
            }
        }

        #endregion

        private void ShapeOptions_Load(object sender, EventArgs e)
        {
            List<Shape.PenType> penList = new List<Shape.PenType>();
            List<Shape.BrushType> brushList = new List<Shape.BrushType>();
            List<Shape.ShapeType> shapeList = new List<Shape.ShapeType>();

            foreach(Shape.PenType pentype in Enum.GetValues(typeof(Shape.PenType)))
            {
                penList.Add(pentype);
            }

            foreach(Shape.BrushType brushtype in Enum.GetValues(typeof(Shape.BrushType)))
            {
                brushList.Add(brushtype);
            }

            foreach(Shape.ShapeType shapetype in Enum.GetValues(typeof(Shape.ShapeType)))
            {
                shapeList.Add(shapetype);
            }

            this.penTypeComboBox.DataSource = penList;
            this.brushTypeComboBox.DataSource = brushList;
            this.shapeTypeComboBox.DataSource = shapeList;
        }
    }
}
