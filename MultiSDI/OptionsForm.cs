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
            }
        }

        private void btnBrushColor_Click(object sender, EventArgs e)
        {
            if (this.colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                Shape shape = (Shape)this.bsShape.Current;
                shape.BrushColor = this.colorDialog.Color;
            }
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
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
    }
}
