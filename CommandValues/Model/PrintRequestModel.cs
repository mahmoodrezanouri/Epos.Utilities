using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Epos.Utilities.CommandValues.Model
{


    [XmlRoot("epos-print", Namespace = "http://www.epson-pos.com/schemas/2011/03/epos-print")]
    public class EposPrint
    {

        [XmlElement]
        public TextNode Text { get; set; }

    }

  
    public class TextNode
    {

        [XmlText]
        public string Value { get; set; }

        [XmlAttribute("lang")]
        public string Language { get; set; }

        [XmlAttribute("smooth")]
        public bool Smooth { get; set; }

        [XmlAttribute("width")]
        public int Width { get; set; }

        [XmlAttribute("height")]
        public int Height { get; set; }

    }
}
