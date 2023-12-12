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

namespace Biletall.Infrastructure.BusInfo
{
    internal class BusInfoService : IBusInfoService
    {
        public List<Koltuk> getBusInfo(BusSearchModel model)
        {
            BawsXmlProviderService xmlProvider = new BawsXmlProviderService();
            string xml = "<Otobus>" +
                $" <FirmaNo>{model.FirmaNo}</FirmaNo>" +
                $" <KalkisNoktaID>{model.KalkisNoktaID}</KalkisNoktaID>" +
                $"<VarisNoktaID>{model.VarisNoktaID}</VarisNoktaID>" +
                $"<Tarih>{Convert.ToDateTime(model.Tarih).ToLocalTime().ToString("yyyy-MM-dd")}</Tarih>" +
                $"<Saat>{Convert.ToDateTime(model.Saat).ToLocalTime().ToString("s")}</Saat>" +
                $"<HatNo>{model.HatNo}</HatNo>" +
                $" <IslemTipi>0</IslemTipi>" +
                $"<SeferTakipNo>{model.SeferTakipNo}</SeferTakipNo>" +
                $" <Ip>127.0.0.1</Ip></Otobus>";

            string result = xmlProvider.GetXmlFromService(xml);

            return Converter.ConverterInfo(result);
        }
    }
}
