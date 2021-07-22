using System;
using System.Collections.Generic;
using System.Text;

namespace Tei.Epos.Utilities.Interfaces
{
    public interface IFluentPrint 
    {
        IFluentPrint PrintLine(string text, TextStyle style = default(TextStyle), IEnumerable<TextAttribute> attributes = default(IEnumerable<TextAttribute>));
        IFluentPrint PrintNewLine();
        IFluentPrint PrintImage(string text);
        IFluentPrint SetStyles(string style);
        IFluentPrint SetStyles(object style);
        void Finish();

        ICollection<IPrintDocumentElement> GetPrintDocuments();

    }

    public struct TextStyle : IPrintDocumentElementAttribute
    {
        public string Width { get; set; }
        public string Height { get; set; }
    }
    public struct TextAttribute : IPrintDocumentElementAttribute
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
    public struct BaseTextLineDocumentElement : IPrintDocumentElement
    {
        public string Value { get; set; }
        public IEnumerable<TextAttribute> Attributes { get; set; }
        public TextStyle Style { get; set; }
    }
    public struct BaseImageDocumentElement : IPrintDocumentElement
    {
        public string Value { get; set; }
    }
    public struct BaseNewLineDocumentElement : IPrintDocumentElement
    {
    }
}
