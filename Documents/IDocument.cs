using System.Drawing;

namespace SingleDocumentInterface.Documents
{
    public interface IDocument
    {
        Color BackColor { get; set; }
        Point DocumentLocation { get; set; }
        string DocumentTitle { get; set; }
        Font Font { get; set; }
        string Text { get; set; }
        string FilePath { get; set; }
        Color TextColor { get; set; }
        Size DocumentSize { get; set; }

        IDocument Load(object data);
        bool Save(object data);
    }
}
