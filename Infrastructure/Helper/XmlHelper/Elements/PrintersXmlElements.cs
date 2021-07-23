using System;
using System.Collections.Generic;
using System.Linq;
using TEI.Epos.Utilities.Infrastructure.Helper.XmlHelper.Elements;

namespace TEI.Epos.Utilities.Infrastructure.XmlHelper.Helper.Elements
{
    public class PrintersXmlElements : BaseXmlPrintElement
    {
        public static EpsonXmlPrintElements EpsonXmlElements = new EpsonXmlPrintElements(0, nameof(EpsonXmlElements).ToLowerInvariant(), "EPSON");
 
        public PrintersXmlElements(int id, string typeName, string tagName)
           : base(id , typeName , tagName)
        {
        }

        public static IEnumerable<BaseXmlPrintElement> List()
        {
            var list = new List<BaseXmlPrintElement>() {

               EpsonXmlElements
           };

            return list;
        }
        public static BaseXmlPrintElement FromName(string name)
        {
            var status = List().SingleOrDefault(s => string.Equals(s.TagName, name, StringComparison.CurrentCultureIgnoreCase));

            if (status == null)
            {
                throw new ArgumentException($"Possible values for PrintersXmlElements : {string.Join(",", List().Select(s => s.Name))}");
            }

            return status;
        }

    }
}
