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
        // fontFamily, size, style, graphicsUnit
        private string fontFamily = "Arial";
        private float fontSize = 12.0f;
        private string fontStyle = "R";

        public Font Font
        {
            get
            {
                FontStyle style;

                if (this.fontStyle.Contains("R"))
                    style = FontStyle.Regular;
                else
                {
                    if(this.fontStyle.Contains("B"))
                }

                return new Font(this.fontFamily, this.fontSize, style);
            }
            set { this.documentLocation = value; }
        }

        #endregion

        
        public string Text { get; set; }

        #region Helpers

        private string SetFontStyle(FontStyle style)
        {
            if(style == null)
        }

        #endregion
    }
}
