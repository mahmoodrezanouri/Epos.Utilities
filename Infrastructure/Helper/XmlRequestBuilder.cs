using Epos.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Epos.Utilities.Infrastructure.Helper
{
    public static class XmlRequestBuilder
    {
        private static XNamespace soap = "http://schemas.xmlsoap.org/soap/envelope/";
        private static XNamespace epos = "http://www.epson-pos.com/schemas/2011/03/epos-print";
        public static XElement ToXmlRequest(this IFluentPrint document)
        {
            var envelope = new XElement(soap + "Envelope");
            var body = new XElement(soap + "Body");
            var print = new XElement(epos + "epos-print");

            envelope.Add(body);
            body.Add(print);

            var printDocuments = document.GetPrintDocuments();

            foreach(var doc in printDocuments)
            {
                var el = XmlPrintElement.GetElement(doc);
                print.Add(el);
            }

            return envelope;

        }
    }
}
