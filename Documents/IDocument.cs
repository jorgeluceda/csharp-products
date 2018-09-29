using System.Drawing;

namespace SingleDocumentInterface.Documents
{
    public interface IDocument
    {
        Color BackColor { get; set; }
        string DocumentLocation { get; set; }
        string DocumentTitle { get; set; }
        Font Font { get; set; }
        string Text { get; set; }
    }
}
