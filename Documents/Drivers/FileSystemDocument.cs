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

        public string DocumentTitle { get; set; }
        public string DocumentLocation { get; set; }
        public Font Font { get; set; }
        public float FontSize { get; set; }
        public Color FontColor { get; set; }
        public string Text { get; set; }
    }
}
