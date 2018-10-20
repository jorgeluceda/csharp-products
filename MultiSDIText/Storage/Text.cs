﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMDI.Storage
{
    class Text
    {
        #region Content 

        /// <summary>
        /// The actual constent of the Text class
        /// </summary>
        public string Content { get; set; }

        #endregion

        #region ZOrder

        /// <summary>
        /// The z-order of the text
        /// </summary>
        public int ZOrder { get; set; }

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
            set { this.colorArgb = value.ToArgb(); }
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
            set { this.backgroundColorArgb = value.ToArgb(); }
        }

        #endregion

        #region Location

        /// <summary>
        /// Internal property for holding the location X
        /// of the text
        /// </summary>
        private int locationX;

        /// <summary>
        /// Internal property for holding the location Y
        /// of the text
        /// </summary>
        private int locationY;

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
            }
        }

        #endregion

        #region Font

        /// <summary>
        /// Internal property for holding the font family,
        /// so serializarion is easier to implement
        /// </summary>
        private string fontFamily = "Arial";

        /// <summary>
        /// Internal property for holding the font family,
        /// so serializarion is easier to implement
        /// </summary>
        private float fontSize = 12.0f;

        /// <summary>
        /// Internal property for holding the font family,
        /// so serializarion is easier to implement
        /// </summary>
        private string fontStyle = "R";

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
        /// The rotation of the text on the document
        /// </summary>
        public int Rotation { get; set; }

        #endregion
    }
}