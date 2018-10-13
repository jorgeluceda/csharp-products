using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SingleDocumentInterface;

namespace MultiSDI
{
    class Shape
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
        public Point location { get; set; }
        public Size size { get; set; }
        public Color penColor { get; set; }
        public Color brushColor { get; set; }

        public ShapeType shapeType { get; set; }

        public PenType penType { get; set; }
        public BrushType brushType { get; set; }
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
    }
}
