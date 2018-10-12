using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SingleDocumentInterface.Documents.Drivers
{
    [Serializable]
    public class FileSystemDocument : IDocument, ISerializable
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

        #region TextColor

        private int argbColor2 = 0;
        public Color TextColor
        {
            get
            {
                if (this.argbColor2 == 0)
                    return Color.Black;

                return Color.FromArgb(this.argbColor2);
            }
            set
            {
                this.argbColor2 = value.ToArgb();
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

        private int documentLocationX = 0;
        private int documentLocationY = 0;
        public Point DocumentLocation
        {
            get { return new Point(this.documentLocationX, this.documentLocationY); }
            set
            {
                this.documentLocationX = value.X;
                this.documentLocationY = value.Y;
            }
        }

        #endregion

        #region DocumentSize

        private int documentHeight = 0;
        private int documentWidth = 0;
        public Size DocumentSize
        {
            get { return new Size(this.documentWidth, this.documentHeight); }
            set
            {
                this.documentHeight = value.Height;
                this.documentWidth = value.Width;
            }
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
                this.fontStyle = this.SerializeFontStyle(value);
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

        #region FilePath

        private string filePath = "";
        public string FilePath
        {
            get { return this.filePath; }
            set { this.filePath = value; }
        }

        #endregion

        public FileSystemDocument() { }

        protected FileSystemDocument(SerializationInfo info, StreamingContext context)
        {
            this.argbColor = info.GetInt32("argbColor");
            this.documentTitle = info.GetString("documentTitle");
            this.documentLocationX = info.GetInt32("documentLocationX");
            this.documentLocationY = info.GetInt32("documentLocationY");

            this.fontFamily = info.GetString("fontFamily");
            this.fontSize = (float)info.GetDouble("fontSize");
            this.fontStyle = info.GetString("fontStyle");

            this.text = info.GetString("text");
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("argbColor", this.argbColor);
            info.AddValue("documentTitle", this.documentTitle);
            info.AddValue("documentLocationX", this.documentLocationX);
            info.AddValue("documentLocationY", this.documentLocationY);

            info.AddValue("fontFamily", this.fontFamily);
            info.AddValue("fontSize", this.fontSize);
            info.AddValue("fontStyle", this.fontStyle);

            info.AddValue("text", this.text);
        }

        public IDocument Load(object data)
        {
            string filePath = (string)data;

            // Restore from file
            FileStream stream = File.OpenRead(filePath);
            var formatter = new BinaryFormatter();
            var deserializedDocument = (FileSystemDocument)formatter.Deserialize(stream);
            stream.Close();

            return deserializedDocument;
        }

        public bool Save(object data)
        {
            string filePath = (string)data;

            // Delete old file, if it exists
            if (File.Exists(filePath))
                File.Delete(filePath);

            // Persist to file
            FileStream stream = File.Create(filePath);
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Close();

            return true;
        }

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
