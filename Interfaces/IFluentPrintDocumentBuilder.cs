using System;
using System.Collections.Generic;
using System.Text;

namespace TEI.Epos.Utilities.Interfaces
{
    public interface IFluentPrintDocumentBuilder
    {
        IFluentPrintDocumentBuilder PrintLine(string text, TextStyle style = default(TextStyle), IEnumerable<TextAttribute> attributes = default(IEnumerable<TextAttribute>));
        IFluentPrintDocumentBuilder PrintNewLine();
        IFluentPrintDocumentBuilder PrintImage(string text);
        IFluentPrintDocumentBuilder SetStyles(string style);
        IFluentPrintDocumentBuilder SetStyles(object style);
        ICollection<IPrintDocumentElement> Build();
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
