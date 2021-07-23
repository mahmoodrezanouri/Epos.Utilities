using TEI.Epos.Utilities.Interfaces;
using System.Xml.Linq;
using TEI.Epos.Utilities.Infrastructure.XmlHelper.Helper.Elements;

namespace TEI.Epos.Utilities.Infrastructure.Extensions
{
    public static class XmlRequestBuilder
    {
        public static XElement ToXmlRequest(this IFluentPrintDocumentBuilder document, string printerName)
        {
            var printerElements = PrintersXmlElements.FromName(printerName);
            var request =printerElements.CreateXmlRequest(document);

            return request;

        }
    }
}
