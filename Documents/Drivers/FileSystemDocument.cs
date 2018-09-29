using System;
using System.Drawing;

namespace SingleDocumentInterface.Documents.Drivers
{
    [Serializable]
    class FileSystemDocument : IDocument
    {
        #region BackColor

        private int argbColor = 0;

        public Color BackColor
        {
            get
            {
                if (this.argbColor == 0)
                    return Color.Black;

                return Color.FromArgb(this.argbColor);
            }
            set
            {
                this.argbColor = value.ToArgb();
            }
        }

        #endregion

        #region DocumentTitle

        private string documentTitle = "";
        public string DocumentTitle
        {
            get { return this.documentTitle; }
            set { this.documentTitle = value; }
        }

        #endregion

        #region DocumentLocation

        private string documentLocation = "";
        public string DocumentLocation
        {
            get { return this.documentLocation; }
            set { this.documentLocation = value; }
        }

        #endregion

        #region Font

        private string fontFamily = "Arial";
        private float fontSize = 12.0f;
        private string fontStyle = "R";

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
                this.fontFamily = this.SerializeFontStyle(value);
            }
        }

        #endregion

        #region Text

        private string text = "";
        public string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }

        #endregion

        #region Helpers

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

        private void SetFontStyle(ref FontStyle? style, FontStyle s)
        {
            if (style == null)
                style = s;
            else
                style = style | s;
        }

        #endregion
    }
}
