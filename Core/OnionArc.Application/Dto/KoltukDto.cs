using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biletall.Application.Dto
{
        [XmlRoot(ElementName = "KoltukDto")]
        public class KoltukDto
        {

            [XmlElement(ElementName = "KoltukStr")]
            public int KoltukStr { get; set; }

            [XmlElement(ElementName = "KoltukNo")]
            public int KoltukNo { get; set; }

            [XmlElement(ElementName = "Durum")]
            public int Durum { get; set; }

            [XmlElement(ElementName = "DurumYan")]
            public int DurumYan { get; set; }

            [XmlElement(ElementName = "KoltukFiyatiInternet")]
            public int KoltukFiyatiInternet { get; set; }
        }

    [XmlRoot(ElementName = "Otobus")]
    public class otobus
    {

        [XmlElement(ElementName = "KoltukDto")]
        public List<KoltukDto> KoltukDto { get; set; }

        [XmlAttribute(AttributeName = "xmlns")]
        public object Xmlns { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

}

