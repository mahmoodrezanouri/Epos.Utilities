using TEI.Epos.Utilities.Interfaces;
using System.Linq;
using System.Xml.Linq;

namespace TEI.Epos.Utilities.Infrastructure.Helper.XmlHelper.Elements
{
    public class XmlPrintTextElement : BaseXmlPrintElement
    {
        public XmlPrintTextElement(int id, string typeName, string tagName)
            : base(id, typeName, tagName)
        {

        }
        public override XElement CreateElement(IPrintDocumentElement documentElement)
        {
            var textLineDocumentElement = (BaseTextLineDocumentElement)documentElement;

            var textEl = new XElement(nameSpace + TagName);
            textEl.Add(textLineDocumentElement.Value);

            if(textLineDocumentElement.Attributes != null && textLineDocumentElement.Attributes.Any())
            {
                foreach (var attr in textLineDocumentElement.Attributes)
                {
                    textEl.Add(new XAttribute(attr.Name, attr.Value));
                }
            }

            return textEl;
        }

    }

}


