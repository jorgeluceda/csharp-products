using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SingleDocumentInterface;
using System.ComponentModel;

namespace MultiSDI
{
    [Serializable]
    class Shape: INotifyPropertyChanged
    {
        public enum ShapeType
        {
            Ellipse,
            Rectangle,
            Custom
        }

        public enum PenType
        {
            Solid,
            Dashed,
            Compound
        }

        public enum BrushType
        {
            Solid,
            Hatched,
            LinearGradient
        }

        private Point location;
        private Size size;
        private Color penColor;
        private Color brushColor;
        private ShapeType shapeType;
        private PenType penType;
        private BrushType brushType;

        public Point Location {
            get { return this.location; }
            set {
                OnChange("Location");
                this.location = value;
            }
        }
        public Size Size {
            get { return this.size; }
            set {
                OnChange("Size");
                this.size = value;
            }
        }
        public Color PenColor {
            get { return this.penColor; }
            set {
                OnChange("Pen Color");
                this.penColor = value;
            }
        }
        public Color BrushColor {
            get { return this.brushColor; }
            set {
                OnChange("Brush Color");
                this.brushColor = value;
            }
        }

        public ShapeType ShapeTypeProp {
            get { return this.shapeType; }
            set {
                OnChange("Shape Type");
                this.shapeType = value;
            }
        }

        public PenType PenTypeProp {
            get { return this.penType; }
            set {
                OnChange("Pen Type");
                this.penType = value;
            }
        }

        public BrushType BrushTypeProp {
            get { return this.brushType; }
            set {
                OnChange("Brush Type");
                this.brushType = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Shape(ShapeType shapeType)
        {
   
            if (shapeType == ShapeType.Ellipse)
            {
                //create ellipse shape
                Ellipse ellipse = new Ellipse(this.location, this.size.Width, 
                                                this.size.Height);
            

            } else if(shapeType == ShapeType.Rectangle)
            {
                //create rectangle shape
                Rectangular rect = new Rectangular(this.location, this.size.Width,
                                                this.size.Height);
            } else
            {
                //create custom shape
                Custom cust = new Custom(this.location, this.size.Width,
                                            this.size.Height);

            }
        }

        /**
         * 
         */
        private void OnChange(String propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void Draw(Graphics graphics)
        {

        }
    }
}
