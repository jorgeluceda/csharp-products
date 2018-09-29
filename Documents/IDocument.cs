using System.IO;
using System.Drawing;
using System;

namespace SingleDocumentInterface.Documents
{
    public interface IDocument
    {
        Color BackColor { get; set; }
        Path DocumentLocation { get; set; }
        string DocumentTitle { get; set; }
        Font Font { get; set; }
        float FontSize { get; set; }
        Color FontColor { get; set; }
        int FormLocationX { get; set; }
        int FormLocationY { get; set; }
        bool Save();
        string Text { get; set; }
    }
}
