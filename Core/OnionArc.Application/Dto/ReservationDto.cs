using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biletall.Application.Dto
{
    public class ReservationDto
    {
        // using System.Xml.Serialization;
        // XmlSerializer serializer = new XmlSerializer(typeof(IslemSonuc));
        // using (StringReader reader = new StringReader(xml))
        // {
        //    var test = (IslemSonuc)serializer.Deserialize(reader);
        // }

        [XmlRoot(ElementName = "IslemSonuc")]
        public class IslemSonuc
        {

            [XmlElement(ElementName = "Sonuc")]
            public bool Sonuc { get; set; }

            [XmlElement(ElementName = "PNR")]
            public string PNR { get; set; }

            [XmlElement(ElementName = "RezervasyonOpsiyon")]
            public string RezervasyonOpsiyon { get; set; }

            [XmlElement(ElementName = "Mesaj")]
            public object Mesaj { get; set; }

            [XmlElement(ElementName = "SeferInternetTarihSaat")]
            public DateTime SeferInternetTarihSaat { get; set; }
        }


    }
}
