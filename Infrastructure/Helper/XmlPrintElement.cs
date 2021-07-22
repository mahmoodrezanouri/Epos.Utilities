using Epos.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Epos.Utilities.Infrastructure.Helper
{
    public class XmlPrintElement : Enumeration
    {

        public static XmlPrintTextElement Text = new XmlPrintTextElement(0, typeof(BaseTextLineDocumentElement).Name.ToLowerInvariant() , "text");
        public static XmlPrintImageElement Image = new XmlPrintImageElement(1, typeof(BaseImageDocumentElement).Name.ToLowerInvariant() , "image");
        public static XmlPrintNewLineElement NewLine = new XmlPrintNewLineElement(2, typeof(BaseNewLineDocumentElement).Name.ToLowerInvariant() , string.Empty);

        public static IEnumerable<BaseXmlPrintElement> List()
        {
           var list = new List<BaseXmlPrintElement>() { 
           
               Text,
               Image,
               NewLine
           
           };

            return list;
     
        }

        public static BaseXmlPrintElement FromName(string name)
        {
            var status = List().SingleOrDefault(s => string.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (status == null)
            {
                throw new ArgumentException($"Possible values for EpsonXmlPrintElement : {string.Join(",", List().Select(s => s.Name))}");
            }

            return status;

        }

        public static BaseXmlPrintElement FromTypeName(string typeName)
        {
            var status = List().SingleOrDefault(s => string.Equals(s.TypeName, typeName, StringComparison.CurrentCultureIgnoreCase));

            if (status == null)
            {
                throw new ArgumentException($"Possible values for EpsonXmlPrintElement : {string.Join(",", List().Select(s => s.Name))}");
            }

            return status;
        }

            public static int From(BaseXmlPrintElement printElement)
        {
            throw new ArgumentException($"Possible values for EpsonXmlPrintElement : {string.Join(",", List().Select(s => s.Name))}");

        }

        public static XElement GetElement(IPrintDocumentElement documentElement)
        {
            var el = FromTypeName(documentElement.GetType().Name.ToLowerInvariant());
            return el.CreateElement(documentElement);

        }

    }
}
