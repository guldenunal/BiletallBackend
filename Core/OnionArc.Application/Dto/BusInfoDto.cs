using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biletall.Application.Dto
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(Otobus));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (Otobus)serializer.Deserialize(reader);
    // }

    [XmlRoot(ElementName = "Sefer")]
    public class Sefer
    {

        [XmlElement(ElementName = "YerelTarihSaat")]
        public DateTime YerelTarihSaat { get; set; }

        [XmlElement(ElementName = "InternetTarihSaat")]
        public DateTime InternetTarihSaat { get; set; }

        [XmlElement(ElementName = "KalkisAdi")]
        public string KalkisAdi { get; set; }

        [XmlElement(ElementName = "VarisAdi")]
        public string VarisAdi { get; set; }

        [XmlElement(ElementName = "HatNo")]
        public int HatNo { get; set; }

        [XmlElement(ElementName = "FiyatDegistirebilir")]
        public bool FiyatDegistirebilir { get; set; }

        [XmlElement(ElementName = "BiletFiyati1")]
        public double BiletFiyati1 { get; set; }

        [XmlElement(ElementName = "BiletFiyati2")]
        public double BiletFiyati2 { get; set; }

        [XmlElement(ElementName = "BiletFiyati3")]
        public double BiletFiyati3 { get; set; }

        [XmlElement(ElementName = "BiletFiyatiInternet")]
        public double BiletFiyatiInternet { get; set; }

        [XmlElement(ElementName = "BiletFiyatiSinifFarki")]
        public double BiletFiyatiSinifFarki { get; set; }

        [XmlElement(ElementName = "BiletTekKoltukFarki")]
        public double BiletTekKoltukFarki { get; set; }

        [XmlElement(ElementName = "BiletFiyatiMisafir")]
        public double BiletFiyatiMisafir { get; set; }

        [XmlElement(ElementName = "MisafirBiletSatar")]
        public bool MisafirBiletSatar { get; set; }

        [XmlElement(ElementName = "OzurluIndirmliBiletSatar")]
        public bool OzurluIndirmliBiletSatar { get; set; }

        [XmlElement(ElementName = "KontenjanliBiletSatar")]
        public bool KontenjanliBiletSatar { get; set; }

        [XmlElement(ElementName = "RezervasyonAktifMi")]
        public bool RezervasyonAktifMi { get; set; }

        [XmlElement(ElementName = "SatisAktifMi")]
        public bool SatisAktifMi { get; set; }

        [XmlElement(ElementName = "MaximumRezerveTarihiSaati")]
        public DateTime MaximumRezerveTarihiSaati { get; set; }

        [XmlElement(ElementName = "OtobusTip")]
        public int OtobusTip { get; set; }

        [XmlElement(ElementName = "OtobusTipSinif")]
        public int OtobusTipSinif { get; set; }

        [XmlElement(ElementName = "OtobusTipIkinciKatSira")]
        public int OtobusTipIkinciKatSira { get; set; }

        [XmlElement(ElementName = "OtobusPlaka")]
        public object OtobusPlaka { get; set; }

        [XmlElement(ElementName = "OtobusKaptanAdi")]
        public object OtobusKaptanAdi { get; set; }

        [XmlElement(ElementName = "OtobusHostesAdi")]
        public object OtobusHostesAdi { get; set; }

        [XmlElement(ElementName = "Okalkti")]
        public int Okalkti { get; set; }

        [XmlElement(ElementName = "OtobusSeferMesaji")]
        public object OtobusSeferMesaji { get; set; }

        [XmlElement(ElementName = "OtobusSubeMesaji")]
        public object OtobusSubeMesaji { get; set; }

        [XmlElement(ElementName = "PeronNo")]
        public string PeronNo { get; set; }

        [XmlElement(ElementName = "KalkisTerminalAdi")]
        public string KalkisTerminalAdi { get; set; }

        [XmlElement(ElementName = "GeceAciklamasi")]
        public string GeceAciklamasi { get; set; }

        [XmlElement(ElementName = "MaximumBosBayanYaniSayisi")]
        public int MaximumBosBayanYaniSayisi { get; set; }

        [XmlElement(ElementName = "SubeBiletPort")]
        public int SubeBiletPort { get; set; }

        [XmlElement(ElementName = "YolcuUyePuanToplam")]
        public int YolcuUyePuanToplam { get; set; }

        [XmlElement(ElementName = "YolcuUyePuanCarpan")]
        public double YolcuUyePuanCarpan { get; set; }

        [XmlElement(ElementName = "DolulukOraniIndirimiYapildi")]
        public bool DolulukOraniIndirimiYapildi { get; set; }

        [XmlElement(ElementName = "OTipOzellik")]
        public double OTipOzellik { get; set; }

        [XmlElement(ElementName = "YonuTersKoltuklar")]
        public object YonuTersKoltuklar { get; set; }

        [XmlElement(ElementName = "SubeSatistaTcKimlikNoYazmakZorunlu")]
        public int SubeSatistaTcKimlikNoYazmakZorunlu { get; set; }

        [XmlElement(ElementName = "SeyahatSuresi")]
        public DateTime SeyahatSuresi { get; set; }

        [XmlElement(ElementName = "SeferTipiAciklamasi")]
        public string SeferTipiAciklamasi { get; set; }

        [XmlElement(ElementName = "OTipAciklamasi")]
        public string OTipAciklamasi { get; set; }

        [XmlElement(ElementName = "FirmaEnUygunFiyatAktifMi")]
        public int FirmaEnUygunFiyatAktifMi { get; set; }

        [XmlElement(ElementName = "OtobusMesaj")]
        public string OtobusMesaj { get; set; }

        [XmlElement(ElementName = "Tesisler")]
        public string Tesisler { get; set; }

        [XmlElement(ElementName = "Odeme3DSecureAktifMi")]
        public int Odeme3DSecureAktifMi { get; set; }

        [XmlElement(ElementName = "Odeme3DSecureZorunluMu")]
        public int Odeme3DSecureZorunluMu { get; set; }

        [XmlElement(ElementName = "PaypalUstLimit")]
        public int PaypalUstLimit { get; set; }

        [XmlElement(ElementName = "MaximumBosBayYaniSayisi")]
        public int MaximumBosBayYaniSayisi { get; set; }

        [XmlElement(ElementName = "SatilabilirKoltukSayi")]
        public int SatilabilirKoltukSayi { get; set; }

        [XmlElement(ElementName = "RezervasyonNedenYapilamaz")]
        public object RezervasyonNedenYapilamaz { get; set; }

        [XmlElement(ElementName = "FirmaMaxToplamBiletFiyati")]
        public double FirmaMaxToplamBiletFiyati { get; set; }

        [XmlElement(ElementName = "FarkliCinsiyetteKoltuklarSecilebilirMi")]
        public int FarkliCinsiyetteKoltuklarSecilebilirMi { get; set; }

        [XmlElement(ElementName = "OtobusHesKoduZorunluMu")]
        public int OtobusHesKoduZorunluMu { get; set; }

        [XmlElement(ElementName = "CiftKoltukTekYolcuyaSatilabilirMi")]
        public int CiftKoltukTekYolcuyaSatilabilirMi { get; set; }

        [XmlElement(ElementName = "TekliKoltuklarDoluysaCiftliKoltuktanSatisYapilabilirMi")]
        public int TekliKoltuklarDoluysaCiftliKoltuktanSatisYapilabilirMi { get; set; }

        [XmlElement(ElementName = "YaklasikSeyahatSuresi")]
        public DateTime YaklasikSeyahatSuresi { get; set; }

        [XmlElement(ElementName = "KalkisNoktaID")]
        public int KalkisNoktaID { get; set; }

        [XmlElement(ElementName = "KalkisNokta")]
        public string KalkisNokta { get; set; }

        [XmlElement(ElementName = "VarisNoktaID")]
        public int VarisNoktaID { get; set; }

        [XmlElement(ElementName = "VarisNokta")]
        public string VarisNokta { get; set; }

        [XmlElement(ElementName = "OtobusKoltukBoslukSemasi")]
        public object OtobusKoltukBoslukSemasi { get; set; }
    }

    [XmlRoot(ElementName = "Koltuk")]
    public class Koltuk
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

    [XmlRoot(ElementName = "SeyahatTipleri")]
    public class SeyahatTipleri
    {

        [XmlElement(ElementName = "SeyahatTipi")]
        public int SeyahatTipi { get; set; }

        [XmlElement(ElementName = "SeyahatAdi")]
        public string SeyahatAdi { get; set; }

        [XmlElement(ElementName = "BiletFiyati")]
        public int BiletFiyati { get; set; }

        [XmlElement(ElementName = "BiletFiyatSinifFarki")]
        public int BiletFiyatSinifFarki { get; set; }

        [XmlElement(ElementName = "BiletTekKoltukFarki")]
        public int BiletTekKoltukFarki { get; set; }
    }

    [XmlRoot(ElementName = "OTipOzellik")]
    public class OTipOzellik
    {

        [XmlElement(ElementName = "O_Tip_Ozellik")]
        public int Ozellik { get; set; }

        [XmlElement(ElementName = "O_Tip_Ozellik_Aciklama")]
        public string OTipOzellikAciklama { get; set; }

        [XmlElement(ElementName = "O_Tip_Ozellik_Detay")]
        public string OTipOzellikDetay { get; set; }

        [XmlElement(ElementName = "O_Tip_Ozellik_Icon")]
        public string OTipOzellikIcon { get; set; }
    }

    [XmlRoot(ElementName = "Otobus")]
    public class Otobus
    {

        [XmlElement(ElementName = "Sefer")]
        public Sefer Sefer { get; set; }

        [XmlElement(ElementName = "Koltuk")]
        public List<Koltuk> Koltuk { get; set; }

        [XmlElement(ElementName = "SeyahatTipleri")]
        public SeyahatTipleri SeyahatTipleri { get; set; }

        [XmlElement(ElementName = "OTipOzellik")]
        public List<OTipOzellik> OTipOzellik { get; set; }
    }


}
