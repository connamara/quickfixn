using System.Xml.Serialization;

namespace AcceptanceTest.Xml;

[XmlRoot("at")]
public class AcceptanceTest
{
    [XmlElement("test")]
    public Test[] Tests { get; set; }

    [XmlElement("results")]
    public Results Results { get; set; }
}

[XmlType("test")]
public class Test
{
    [XmlAttribute("name")]
    public string Name { get; set; }

    [XmlAttribute("result")]
    public string Result { get; set; }

    [XmlElement("message")]
    public Message Message { get; set; }
}

[XmlType("message")]
public class Message
{
    [XmlText(typeof(string))]
    public string Text { get; set; }

    [XmlElement("line")]
    public int Line { get; set; }

    [XmlElement("expected")]
    public string Expected { get; set; }

    [XmlElement("received")]
    public string Received { get; set; }
}

[XmlType("results")]
public class Results
{
    [XmlAttribute("total")]
    public int Total { get; set; }

    [XmlAttribute("failures")]
    public int Failures { get; set; }
}
