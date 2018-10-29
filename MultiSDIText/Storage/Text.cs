using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MultiSDIText.Storage
{
    [Serializable]
    public class Text : ISerializable, INotifyPropertyChanged
    {
        #region Constructor

        /// <summary>
        /// Simple constructor that initilaizes all properties
        /// </summary>
        public Text()
        {
            this.content = "";

            this.zOrder = 0;

            this.colorArgb = 0;

            this.backgroundColorArgb = 0;

            this.locationX = 0;
            this.locationY = 0;

            this.fontFamily = "Arial";
            this.fontSize = 12.0f;
            this.fontStyle = "R";
        }

        #endregion

        #region Content

        /// <summary>
        /// Internal property for holding the content value, so
        /// serialization is easier to implement
        /// </summary>
        private string content;

        /// <summary>
        /// The actual content of the Text class
        /// </summary>
        public string Content
        {
            get { return this.content; }
            set
            {
                this.content = value;
                this.PropertyChange("Content");
            }
        }

        #endregion

        #region ZOrder

        /// <summary>
        /// Internal property for holding the content value, so
        /// serialization is easier to implement
        /// </summary>
        private int zOrder;

        /// <summary>
        /// The z-order of the text
        /// </summary>
        public int ZOrder
        {
            get { return this.zOrder; }
            set
            {
                this.zOrder = value;
                this.PropertyChange("ZOrder");
            }
        }

        #endregion

        #region Color

        /// <summary>
        /// Internal property for holding the color value, so
        /// serialization is easier to implement
        /// </summary>
        private int colorArgb;

        /// <summary>
        /// The color of the text
        /// </summary>
        public Color Color
        {
            get { return Color.FromArgb(this.colorArgb); }
            set
            {
                this.colorArgb = value.ToArgb();
                this.PropertyChange("Color");
            }
        }

        #endregion

        #region BackgroundColor

        /// <summary>
        /// Internal property for holding the back color
        /// value, so serialization is easier to implement
        /// </summary>
        private int backgroundColorArgb;

        /// <summary>
        /// The background color of the text
        /// </summary>
        public Color BackgroundColor
        {
            get { return Color.FromArgb(this.backgroundColorArgb); }
            set
            {
                this.backgroundColorArgb = value.ToArgb();
                this.PropertyChange("BackgroundColor");
            }
        }

        #endregion

        #region Location

        /// <summary>
        /// Internal location X property
        /// </summary>
        public int locationX;

        /// <summary>
        /// Internal location Y property
        /// </summary>
        public int locationY;



        
        /// <summary>
        /// The location of the text in the document
        /// </summary>
        public Point Location
        {
            get { return new Point(this.locationX, this.locationY); }
            set
            {
                    this.locationX = value.X;

                    this.locationY = value.Y;

                    this.PropertyChange("Location");
            }
        }
        


        #endregion

        #region Font

        /// <summary>
        /// Internal property for holding the font family,
        /// so serializarion is easier to implement
        /// </summary>
        private string fontFamily;

        /// <summary>
        /// Internal property for holding the font family,
        /// so serializarion is easier to implement
        /// </summary>
        private float fontSize;

        /// <summary>
        /// Internal property for holding the font family,
        /// so serializarion is easier to implement
        /// </summary>
        private string fontStyle;

        /// <summary>
        /// The font of the text
        /// </summary>
        public Font Font
        {
            get
            {
                return new Font(this.fontFamily, this.fontSize, this.DesirializeFontStyle());
            }
            set
            {
                this.fontFamily = value.FontFamily.Name;
                this.fontSize = value.Size;
                this.fontStyle = this.SerializeFontStyle(value);
                this.PropertyChange("Font");
            }
        }

        /// <summary>
        /// Helper method to translate font style to an string representation
        /// </summary>
        /// <param name="font">The font from where the style is going to be extracted</param>
        /// <returns>An string representation of the font style</returns>
        private string SerializeFontStyle(Font font)
        {
            string fontStyle = "";

            if (font.Style.Equals(FontStyle.Regular))
                fontStyle += "R";
            else
            {
                if (font.Bold)
                    fontStyle += "B";
                if (font.Italic)
                    fontStyle += "I";
                if (font.Strikeout)
                    fontStyle += "S";
                if (font.Underline)
                    fontStyle += "U";
            }

            return fontStyle;
        }

        /// <summary>
        /// Helper method to convert string into a font style
        /// </summary>
        /// <returns>The font style from a string representation</returns>
        private FontStyle DesirializeFontStyle()
        {
            FontStyle? style = null;

            if (this.fontStyle.Contains("B"))
                this.SetFontStyle(ref style, FontStyle.Bold);
            if (this.fontStyle.Contains("I"))
                this.SetFontStyle(ref style, FontStyle.Italic);
            if (this.fontStyle.Contains("R"))
                this.SetFontStyle(ref style, FontStyle.Regular);
            if (this.fontStyle.Contains("S"))
                this.SetFontStyle(ref style, FontStyle.Strikeout);
            if (this.fontStyle.Contains("U"))
                this.SetFontStyle(ref style, FontStyle.Underline);

            return style ?? default(FontStyle);
        }

        /// <summary>
        /// Helper method to combine multiple font styles
        /// </summary>
        /// <param name="style">The result font style</param>
        /// <param name="s">The style that is going to be combined</param>
        private void SetFontStyle(ref FontStyle? style, FontStyle s)
        {
            if (style == null)
                style = s;
            else
                style = style | s;
        }

        #endregion

        #region Rotation

        /// <summary>
        /// Internal property for holding the content value, so
        /// serialization is easier to implement
        /// </summary>
        private int rotation;

        /// <summary>
        /// The rotation of the text on the document
        /// </summary>
        public int Rotation
        {
            get { return this.rotation; }
            set
            {
                this.rotation = value;
                this.PropertyChange("Rotation");
            }
        }

        #endregion

        #region ISerializable

        /// <summary>
        /// Desirializes the object
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected Text(SerializationInfo info, StreamingContext context)
        {
            this.content = info.GetString("content");

            this.zOrder = info.GetInt32("zOrder");

            this.colorArgb = info.GetInt32("colorArgb");

            this.backgroundColorArgb = info.GetInt32("backgroundColorArgb");

            this.locationX = info.GetInt32("locationX");
            this.locationY = info.GetInt32("locationY");

            this.fontFamily = info.GetString("fontFamily");
            this.fontSize = (float)info.GetDouble("fontSize");
            this.fontStyle = info.GetString("fontStyle");

            this.rotation = info.GetInt32("rotation");
        }

        /// <summary>
        /// Serializes the object
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("content", this.content);

            info.AddValue("zOrder", this.zOrder);

            info.AddValue("colorArgb", this.colorArgb);

            info.AddValue("backgroundColorArgb", this.backgroundColorArgb);

            info.AddValue("locationX", this.locationX);
            info.AddValue("locationY", this.locationY);

            info.AddValue("fontFamily", this.fontFamily);
            info.AddValue("fontSize", this.fontSize);
            info.AddValue("fontStyle", this.fontStyle);

            info.AddValue("rotation", this.rotation);
        }

        #endregion

        #region DataBinding

        /// <summary>
        /// The property change handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Fires the property change event for a property
        /// </summary>
        /// <param name="propertyName">The property name that changed</param>
        protected void PropertyChange(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Functionality

        /// <summary>
        /// Draw the string property
        /// </summary>
        /// <param name="g">The graphics used to draw</param>
        public void Draw(Graphics g)
        {
            // Draw a string on the PictureBox.
            g.DrawString(this.content,
                this.Font, System.Drawing.Brushes.Blue, this.Location);
        }

        /// <summary>
        /// Determines if a given point is within the text's rectangle
        /// boundaries
        /// </summary>
        /// <param name="p">The ponint to be found</param>
        /// <returns>Whether or not the point is within the text boundaries</returns>
        public bool PointWithinBoundaries(Point p)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
