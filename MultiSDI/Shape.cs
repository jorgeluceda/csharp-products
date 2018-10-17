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

        private Color penColor;
        public Color PenColor {
            get { return this.penColor; }
            set {
                OnChange("PenColor");
                this.penColor = value;
            }
        }

        private Color brushColor;
        public Color BrushColor {
            get { return this.brushColor; }
            set {
                this.brushColor = value;
                OnChange("BrushColor");
            }
        }

        private ShapeTypeEnum shapeType;
        public ShapeTypeEnum ShapeType {
            get { return this.shapeType; }
            set {
                this.shapeType = value;
                OnChange("ShapeType");
            }
        }

        private PenTypeEnum penType;
        public PenTypeEnum PenType {
            get { return this.penType; }
            set {
                this.penType = value;
                OnChange("PenType");
            }
        }

        private BrushTypeEnum brushType;
        public BrushTypeEnum BrushType {
            get { return this.brushType; }
            set {
                this.brushType = value;
                OnChange("BrushType");
            }
        }

        //default shape constructor, sets default enum values for our types
        public Shape()
        {
        
            ShapeType = ShapeTypeEnum.Ellipse;
            BrushType = BrushTypeEnum.Solid;
            PenType = PenTypeEnum.Solid;
            
        }

        public void Draw(Graphics graphics)
        {

        }
    }
}
