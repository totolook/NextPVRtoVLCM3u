using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NextpvrtoVlc.Model
{
    [XmlRoot(ElementName = "locator")]
    public class Locator
    {
        [XmlElement(ElementName = "frequency")]
        public string Frequency { get; set; }
        [XmlElement(ElementName = "bandwidth")]
        public string Bandwidth { get; set; }
    }

    [XmlRoot(ElementName = "tuning")]
    public class Tuning
    {
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "locator")]
        public Locator Locator { get; set; }
        [XmlElement(ElementName = "service_id")]
        public string Service_id { get; set; }
        [XmlElement(ElementName = "tsid")]
        public string Tsid { get; set; }
        [XmlElement(ElementName = "onid")]
        public string Onid { get; set; }
        [XmlElement(ElementName = "service_type")]
        public string Service_type { get; set; }
        [XmlElement(ElementName = "provider")]
        public string Provider { get; set; }
        [XmlElement(ElementName = "encrypted")]
        public string Encrypted { get; set; }
    }

    [XmlRoot(ElementName = "epg")]
    public class Epg
    {
        [XmlElement(ElementName = "source")]
        public string Source { get; set; }
        [XmlElement(ElementName = "capture_source")]
        public string Capture_source { get; set; }
        [XmlElement(ElementName = "readable_source")]
        public string Readable_source { get; set; }
        [XmlElement(ElementName = "mapping")]
        public string Mapping { get; set; }
    }

    [XmlRoot(ElementName = "Channel")]
    public class Channel
    {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Number")]
        public string Number { get; set; }
        [XmlElement(ElementName = "ServiceType")]
        public string ServiceType { get; set; }
        [XmlElement(ElementName = "tuning")]
        public Tuning Tuning { get; set; }
        [XmlElement(ElementName = "EPGSource")]
        public string EPGSource { get; set; }
        [XmlElement(ElementName = "epg")]
        public Epg Epg { get; set; }
    }

    [XmlRoot(ElementName = "Channels")]
    public class Channels
    {
        [XmlElement(ElementName = "Channel")]
        public List<Channel> Channel { get; set; }
        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }
    }

}
