// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(KaraNoktalar));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (KaraNoktalar)serializer.Deserialize(reader);
// }

using System.Xml.Serialization;

[XmlRoot(ElementName = "KaraNokta")]
public class KaraNoktaDto
{


    [XmlElement(ElementName = "SeyahatSehirID")]
    public int SeyahatSehirID { get; set; }

    [XmlElement(ElementName = "Ad")]
    public string Ad { get; set; }
    public int ID { get; set; }

  
}

[XmlRoot(ElementName = "KaraNoktalar")]
public class KaraNoktalar
{

    [XmlElement(ElementName = "KaraNokta")]
    public List<KaraNoktaDto> KaraNokta { get; set; }

    [XmlAttribute(AttributeName = "xmlns")]
    public object Xmlns { get; set; }

    [XmlText]
    public string Text { get; set; }
}

