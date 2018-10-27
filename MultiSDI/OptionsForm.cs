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
    public partial class OptionsForm : Form, IBindingSource
    {
        public BindingSource DataBindingSource
        {
            get { return this.bsShape; }
            set { this.bsShape = value; }
        }

        public OptionsForm()
        {
            InitializeComponent();
        }

        private void btnPenColor_Click(object sender, EventArgs e)
        {
            if(this.colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                Shape shape = (Shape)this.bsShape.Current;
                shape.PenColor = this.colorDialog.Color;

                //Changing button backcolor and font based on color selected
                if (this.colorDialog.Color.GetBrightness() < 0.5)
                {
                    this.btnPenColor.ForeColor = Color.White;
                }
                else
                {
                    this.btnPenColor.ForeColor = Color.Black;
                }

                this.btnPenColor.BackColor = this.colorDialog.Color;
            }
        }

        private void btnBrushColor_Click(object sender, EventArgs e)
        {
            if (this.colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                Shape shape = (Shape)this.bsShape.Current;
                shape.BrushColor = this.colorDialog.Color;

                //Changing button backcolor and font based on color selected
                if (this.colorDialog.Color.GetBrightness() < 0.5)
                {
                    this.btnBrushColor.ForeColor = Color.White;
                }
                else
                {
                    this.btnBrushColor.ForeColor = Color.Black;
                }

                this.btnBrushColor.BackColor = this.colorDialog.Color;
            }
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            Shape shape = (Shape)this.bsShape.Current;

            List<Shape.PenTypeEnum> penList = new List<Shape.PenTypeEnum>();
            List<Shape.BrushTypeEnum> brushList = new List<Shape.BrushTypeEnum>();
            List<Shape.ShapeTypeEnum> shapeList = new List<Shape.ShapeTypeEnum>();

            foreach (Shape.PenTypeEnum pentype in Enum.GetValues(typeof(Shape.PenTypeEnum)))
            {
                penList.Add(pentype);
            }

            foreach (Shape.BrushTypeEnum brushtype in Enum.GetValues(typeof(Shape.BrushTypeEnum)))
            {
                brushList.Add(brushtype);
            }

            foreach (Shape.ShapeTypeEnum shapetype in Enum.GetValues(typeof(Shape.ShapeTypeEnum)))
            {
                shapeList.Add(shapetype);
            }

            this.penTypeComboBox.DataSource = penList;
            this.brushTypeComboBox.DataSource = brushList;
            this.shapeTypeComboBox.DataSource = shapeList;

            this.penTypeComboBox.SelectedIndex = (int)((Shape)this.DataBindingSource.Current).PenType;
            this.brushTypeComboBox.SelectedIndex = (int)((Shape)this.DataBindingSource.Current).BrushType;
            this.shapeTypeComboBox.SelectedIndex = (int)((Shape)this.DataBindingSource.Current).ShapeType;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void locationXTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Check if anything was entered
            if (!string.IsNullOrWhiteSpace(this.locationXTextBox.Text) || !string.IsNullOrEmpty(this.locationXTextBox.Text))
            {
                // Check if an integer was entered
                int temp;
                if (!int.TryParse(this.locationXTextBox.Text, out temp))
                {
                    this.shapeOptionsErrorProvider.SetError(this.locationXTextBox, "Please enter a whole number");
                }
                else //When Correct
                {
                    this.shapeOptionsErrorProvider.SetError(this.locationXTextBox, null);
                }
            }
            else
            {
                this.shapeOptionsErrorProvider.SetError(this.locationXTextBox, "Please enter an X coordinate");
            }
        }

        private void locationYTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Check if anything was entered
            if (!string.IsNullOrWhiteSpace(this.locationYTextBox.Text) || !string.IsNullOrEmpty(this.locationYTextBox.Text))
            {
                // Check if an integer was entered
                int temp;
                if (!int.TryParse(this.locationYTextBox.Text, out temp))
                {
                    this.shapeOptionsErrorProvider.SetError(this.locationYTextBox, "Please enter a whole number");
                }
                else //When Correct
                {
                    this.shapeOptionsErrorProvider.SetError(this.locationYTextBox, null);
                }
            }
            else
            {
                this.shapeOptionsErrorProvider.SetError(this.locationYTextBox, "Please enter a Y coordinate");
            }
        }

        private void sizeHTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Check if anything was entered
            if (!string.IsNullOrWhiteSpace(this.sizeHTextBox.Text) || !string.IsNullOrEmpty(this.sizeHTextBox.Text))
            {
                // Check if an integer was entered
                int temp;
                if (!int.TryParse(this.sizeHTextBox.Text, out temp))
                {
                    this.shapeOptionsErrorProvider.SetError(this.sizeHTextBox, "Please enter a whole number");
                }
                else //When Correct
                {
                    this.shapeOptionsErrorProvider.SetError(this.sizeHTextBox, null);
                }
            }
            else
            {
                this.shapeOptionsErrorProvider.SetError(this.sizeHTextBox, "Please enter a height");
            }
        }

        private void sizeWTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Check if anything was entered
            if (!string.IsNullOrWhiteSpace(this.sizeWTextBox.Text) || !string.IsNullOrEmpty(this.sizeWTextBox.Text))
            {
                // Check if an integer was entered
                int temp;
                if (!int.TryParse(this.sizeWTextBox.Text, out temp))
                {
                    this.shapeOptionsErrorProvider.SetError(this.sizeWTextBox, "Please enter a whole number");
                }
                else //When Correct
                {
                    this.shapeOptionsErrorProvider.SetError(this.sizeWTextBox, null);
                }
            }
            else
            {
                this.shapeOptionsErrorProvider.SetError(this.sizeWTextBox, "Please enter a width");
            }
        }

        private void locationXTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
