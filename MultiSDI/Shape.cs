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
    public class Shape: DataBindingObject
    {
        public enum ShapeTypeEnum
        {
            Ellipse,
            Rectangle,
            Custom
        }

        public enum PenTypeEnum
        {
            Solid,
            Dashed,
            Compound
        }

        public enum BrushTypeEnum
        {
            Solid,
            Hatched,
            LinearGradient
        }

        private Color penColor;
        private Color brushColor;
        private ShapeTypeEnum shapeType;
        private PenTypeEnum penType;
        private BrushTypeEnum brushType;

        #region Location

        public Point Location
        {
            get { return new Point(this.LocationX, this.LocationY); }
        }

        private int locationX;
        public int LocationX {
            get { return locationX; }
            set {
                OnChange("LocationX");
                this.locationX = value;
            }
        }

        private int locationY;
        public int LocationY
        {
            get { return this.locationY; }
            set
            {
                OnChange("LocationY");
                this.locationY = value;
            }
        }

        #endregion

        #region Size

        public Size Size {
            get { return new Size(this.sizeW, this.sizeH); }
        }

        private int sizeW;
        public int SizeW
        {
            get { return sizeW; }
            set
            {
                sizeW = value;
                OnChange("SizeW");
            }
        }

        private int sizeH;
        public int SizeH
        {
            get { return sizeH; }
            set
            {
                sizeH = value;
                OnChange("SizeH");
            }
        }

        #endregion

        public Color PenColor {
            get { return this.penColor; }
            set {
                OnChange("PenColor");
                this.penColor = value;
            }
        }
        public Color BrushColor {
            get { return this.brushColor; }
            set {
                OnChange("BrushColor");
                this.brushColor = value;
            }
        }

        public ShapeTypeEnum ShapeType {
            get { return this.shapeType; }
            set {
                OnChange("ShapeType");
                this.shapeType = value;
            }
        }

        public PenTypeEnum PenType {
            get { return this.penType; }
            set {
                OnChange("PenType");
                this.penType = value;
            }
        }

        public BrushTypeEnum BrushType {
            get { return this.brushType; }
            set {
                OnChange("BrushType");
                this.brushType = value;
            }
        }

        public Shape(ShapeTypeEnum shapeType)
        {
   
            if (shapeType == ShapeTypeEnum.Ellipse)
            {
                //create ellipse shape
                Ellipse ellipse = new Ellipse(this.Location, this.Size.Width, 
                                                this.Size.Height);
            

            } else if(shapeType == ShapeTypeEnum.Rectangle)
            {
                //create rectangle shape
                Rectangular rect = new Rectangular(this.Location, this.Size.Width,
                                                this.Size.Height);
            } else
            {
                //create custom shape
                Custom cust = new Custom(this.Location, this.Size.Width,
                                            this.Size.Height);

            }
        }

        public void Draw(Graphics graphics)
        {

        }
    }
}
