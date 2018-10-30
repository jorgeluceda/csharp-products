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
        private Shape shapeData;

        public ShapeOptions(Shape shape)
        {
            InitializeComponent();

            this.shapeData = shape;
            this.BindData();
        }


        private void BindData()
        {
            this.shapeXTextBox.DataBindings.Add("Text", this.shapeData, "LocationX");
            this.shapeYTextBox.DataBindings.Add("Text", this.shapeData, "LocationY");
            this.shapeWidthTextBox.DataBindings.Add("Text", this.shapeData, "SizeW");
            this.shapeHeightTextBox.DataBindings.Add("Text", this.shapeData, "SizeH");
        }
        
        #region Colors
        private void penColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                Color penColor = dlg.Color;
                this.shapeData.PenColor = penColor;

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
                this.shapeData.BrushColor = brushColor;

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

        #region ComboBox

        private void InitialComboboxBinding()
        {
            this.penTypeComboBox.SelectedIndex = (int)this.shapeData.PenType;
            this.brushTypeComboBox.SelectedIndex = (int)this.shapeData.BrushType;
            this.shapeTypeComboBox.SelectedIndex = (int)this.shapeData.ShapeType;

            this.penTypeComboBox.DataBindings.Add("SelectedItem", this.shapeData, "PenType");
            this.brushTypeComboBox.DataBindings.Add("SelectedItem", this.shapeData, "BrushType");
            this.shapeTypeComboBox.DataBindings.Add("SelectedItem", this.shapeData, "ShapeType");
        }

        private void penTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((ComboBox)sender).DataBindings["SelectedItem"].WriteValue();
        }

        private void brushTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((ComboBox)sender).DataBindings["SelectedItem"].WriteValue();
        }

        private void shapeTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((ComboBox)sender).DataBindings["SelectedItem"].WriteValue();
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
            List<Shape.PenTypeEnum> penList = new List<Shape.PenTypeEnum>();
            List<Shape.BrushTypeEnum> brushList = new List<Shape.BrushTypeEnum>();
            List<Shape.ShapeTypeEnum> shapeList = new List<Shape.ShapeTypeEnum>();

            foreach(Shape.PenTypeEnum pentype in Enum.GetValues(typeof(Shape.PenTypeEnum)))
            {
                penList.Add(pentype);
            }

            foreach(Shape.BrushTypeEnum brushtype in Enum.GetValues(typeof(Shape.BrushTypeEnum)))
            {
                brushList.Add(brushtype);
            }

            foreach(Shape.ShapeTypeEnum shapetype in Enum.GetValues(typeof(Shape.ShapeTypeEnum)))
            {
                shapeList.Add(shapetype);
            }

            this.penTypeComboBox.DataSource = penList;
            this.brushTypeComboBox.DataSource = brushList;
            this.shapeTypeComboBox.DataSource = shapeList;

            this.InitialComboboxBinding();
        }
    }
}
