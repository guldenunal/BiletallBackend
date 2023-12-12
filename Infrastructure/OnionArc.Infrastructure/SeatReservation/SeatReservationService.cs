using Biletall.Application.Dto;
using Biletall.Application.Interfaces;
using Biletall.Application.RequestModel;
using Biletall.Infrastructure.Baws;
using Biletall.Infrastructure.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Biletall.Application.Dto.ReservationDto;

namespace Biletall.Infrastructure.SeatReservation
{
    public class SeatReservationService : ISeatReservationService
    {
        List<IslemSonuc> ISeatReservationService.GetReservation(ReservationModel model)
        {
            BawsXmlProviderService xmlProvider = new BawsXmlProviderService();
            string xml = "<IslemRezervasyon>" +
                $"<FirmaNo>{model.FirmaNo}</FirmaNo>" +
                $"<KalkisNoktaID>{model.KalkisNoktaID}</KalkisNoktaID>" +
                $"<VarisNoktaID>{model.VarisNoktaID}</VarisNoktaID>" +
                $"<Tarih>{Convert.ToDateTime(model.Tarih).ToLocalTime().ToString("yyyy-MM-dd")}</Tarih>" +
                $"<Saat>{Convert.ToDateTime(model.Saat).ToLocalTime().ToString("s")}</Saat>" +
                $"<HatNo>{model.HatNo}</HatNo>" +
                $"<SeferNo>{model.SeferTakipNo}</SeferNo>" +
                $"<KalkisTerminalAdiSaatleri></KalkisTerminalAdiSaatleri>" +
                $"<KoltukNo1>{model.KoltukNo1}</KoltukNo1>" +
                $"<Adi1>{model.Adi}</Adi1>" +
                $"<Soyadi1>{model.Soyadi}</Soyadi1>" +
                $"<TcKimlikNo1>{Convert.ToInt64(model.TcKimlikNo)}</TcKimlikNo1>" +
                $"<ServisYeriKalkis1>{model.KalkisNokta}</ServisYeriKalkis1>" +
                $"<TelefonNo>{Convert.ToInt64(model.TelefonNo)}</TelefonNo>" +
                $"<Cinsiyet>{model.Cinsiyet}</Cinsiyet>" +
                $"<YolcuSayisi>1</YolcuSayisi>" +
                $"<FirmaAciklama></FirmaAciklama>" +
                $"<HatirlaticiNot></HatirlaticiNot>" +
                "<WebYolcu>" +
                "<WebUyeNo>0</WebUyeNo>" +
                "<Ip>0.0.0.0</Ip>" +
                $"<Email>{model.EMail}</Email>" +
                "</WebYolcu></IslemRezervasyon>";

            string result = xmlProvider.GetXmlFromService(xml);

            return Converter.ConverterRes(result);
        }
    }
}
