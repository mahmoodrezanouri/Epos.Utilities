using Tei.Epos.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Tei.Epos.Utilities.Infrastructure.Helper
{
    public class BaseXmlPrintElement : Enumeration
    {
        protected XNamespace Epos => "http://www.epson-pos.com/schemas/2011/03/epos-print";
        public string TypeName { get; set; }
       
        public BaseXmlPrintElement(int id, string typeName , string tagName)
            : base(id, tagName)
        {
            TypeName = typeName;
        }
        public virtual XElement CreateElement(IPrintDocumentElement documentElement)
        {
            return default(XElement);
        }

    }

}


