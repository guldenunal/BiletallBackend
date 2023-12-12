using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Biletall.Infrastructure.Baws;
using System.Xml.Linq;
using System.Runtime.CompilerServices;
using System.Data.SqlTypes;
using Biletall.Infrastructure.Helper;
using System.Globalization;
using Biletall.Application.Dto;
using static Biletall.Application.Dto.ReservationDto;

namespace Biletall.Infrastructure.Helper
{
    public class Converter
    {
        public static List<KaraNoktaDto> ConvertXml(string xml)
        {

            XElement element = XElement.Parse(xml);

            var list = element.Descendants("KaraNokta").Select(x => new KaraNoktaDto

            {
                SeyahatSehirID = int.Parse(x.NullOrValue("SeyahatSehirID").ToString()),
                ID = int.Parse(x.NullOrValue("ID").ToString()),
                
                Ad = x.NullOrValue("Ad").ToString(),


            }).ToList();

            return list;

        }
       
        public static List<Table> Convert(string xml)
        {
            XElement element = XElement.Parse(xml);

            var seferler = element.Descendants("Table").Select(x => new Table
            {
                FirmaAdi = x.NullOrValue("FirmaAdi").ToString(),
                Tarih =DateTime.Parse(x.NullOrValue("Tarih").ToString()),
                Saat = DateTime.Parse(x.NullOrValue("Saat").ToString()),
                KalkisNokta = x.NullOrValue("KalkisNokta").ToString(),
                VarisNokta = x.NullOrValue("VarisNokta").ToString(),
                SeyahatSuresi = DateTime.Parse(x.NullOrValue("SeyahatSuresi").ToString()),
                BiletFiyatiInternet = int.Parse(x.NullOrValue("BiletFiyatiInternet").ToString()),
                OtobusKoltukYerlesimTipi = x.NullOrValue("OtobusKoltukYerlesimTipi").ToString(),

                FirmaNo = int.Parse(x.NullOrValue("FirmaNo").ToString()),
                VarisNoktaID = int.Parse(x.NullOrValue("VarisNoktaID").ToString()),
                KalkisNoktaID = int.Parse(x.NullOrValue("KalkisNoktaID").ToString()),
                HatNo = int.Parse(x.NullOrValue("HatNo").ToString()),
                SeferTakipNo = int.Parse(x.NullOrValue("SeferTakipNo").ToString()),


            }).ToList();

            return seferler;
        }

        public static List<Koltuk> ConverterInfo(string xml) {
            XElement element = XElement.Parse(xml);

            var sefer = element.Descendants("Koltuk").Select(x => new Koltuk
            {
                KoltukNo = int.Parse(x.NullOrValue("KoltukNo").ToString()),
                Durum = int.Parse(x.NullOrValue("Durum").ToString()),
                KoltukFiyatiInternet = int.Parse(x.NullOrValue("KoltukFiyatiInternet").ToString())
            }).ToList();

            return sefer;

        }

        public static List<IslemSonuc> ConverterRes(string xml)
        {
            XElement element = XElement.Parse(xml);

            var reserv = element.Descendants("IslemSonuc").Select(x => new IslemSonuc
            {
                Sonuc = bool.Parse(x.NullOrValue("Sonuc").ToString()),
                PNR = x.NullOrValue("PNR").ToString(),
                RezervasyonOpsiyon = x.NullOrValue("Rezervasyon").ToString(),
                Mesaj = x.NullOrValue("Mesaj").ToString(),
                SeferInternetTarihSaat = DateTime.Parse(x.NullOrValue("SeferInternetTarihSaat").ToString()),
            }).ToList();

            return reserv;
        }
    }}



