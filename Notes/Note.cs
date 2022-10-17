using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Notes
{
    [XmlType("note")]
    public class Note
    {
        [XmlElement("to")]
        public string To { get; set; }
        [XmlElement("from")]
        public string From { get; set; }
        [XmlElement("heading")]
        public string Heading { get; set; }
        [XmlElement("body")]
        public string Body { get; set; }
    }
}
