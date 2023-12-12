using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biletall.Application.Dto
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(KaraNoktalar));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (KaraNoktalar)serializer.Deserialize(reader);
    // }

    [XmlRoot(ElementName = "BusPointDto")]
    public class BusPointDto
    {

        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "SeyahatSehirID")]
        public int SeyahatSehirID { get; set; }

        [XmlElement(ElementName = "Bolge")]
        public object Bolge { get; set; }

        [XmlElement(ElementName = "UlkeKodu")]
        public string UlkeKodu { get; set; }

        [XmlElement(ElementName = "Ad")]
        public string Ad { get; set; }

        [XmlElement(ElementName = "Aciklama")]
        public object Aciklama { get; set; }

        [XmlElement(ElementName = "MerkezMi")]
        public int MerkezMi { get; set; }

        [XmlElement(ElementName = "BagliOlduguNoktaID")]
        public int BagliOlduguNoktaID { get; set; }
    }

    [XmlRoot(ElementName = "KaraNoktalar")]
    public class KaraNoktalar
    {

        [XmlElement(ElementName = "BusPointDto")]
        public List<BusPointDto> BusPointDto { get; set; }
    }


}
