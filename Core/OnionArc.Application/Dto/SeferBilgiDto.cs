using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

    [XmlRoot(ElementName = "Table")]
    public class Table

    {

        [XmlElement(ElementName = "FirmaAdi")]
        public string FirmaAdi { get; set; }

        [XmlElement(ElementName = "Tarih")]
        public DateTime Tarih { get; set; }

        [XmlElement(ElementName = "Saat")]
        public DateTime Saat { get; set; }

        [XmlElement(ElementName = "KalkisNokta")]
        public string KalkisNokta { get; set; }

        [XmlElement(ElementName = "VarisNokta")]
         public string VarisNokta { get; set; }

        [XmlElement(ElementName = "SeyahatSuresi")]
        public DateTime SeyahatSuresi { get; set; }

        [XmlElement(ElementName = "BiletFiyatiInternet")]
        public int BiletFiyatiInternet { get; set; }

        [XmlElement(ElementName = "OtobusKoltukYerlesimTipi")]
        public string OtobusKoltukYerlesimTipi { get; set; }

        [XmlElement(ElementName = "FirmaNo")]
        public int FirmaNo { get; set; }

        [XmlElement(ElementName = "VarisNoktaID")]
        public int VarisNoktaID { get; set; }


        [XmlElement(ElementName = "KalkisNoktaID")]
        public int KalkisNoktaID { get; set; }

        [XmlElement(ElementName = "HatNo")]
        public int HatNo { get; set; }


        [XmlElement(ElementName = "SeferTakipNo")]
        public int SeferTakipNo { get; set; }

}

[XmlRoot(ElementName = "NewDataSet")]
public class NewDataSet
{

    [XmlElement(ElementName = "Table")]
    public List<Table> Table { get; set; }

    [XmlAttribute(AttributeName = "xmlns")]
    public object Xmlns { get; set; }

    [XmlText]
    public string Text { get; set; }
}



