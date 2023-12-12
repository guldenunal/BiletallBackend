using Biletall.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biletall.Infrastructure.Baws;
using Biletall.Infrastructure.Helper;

namespace Biletall.Infrastructure.BusPoint
{
    public class BusPointService : IBusPointService
    {
        public List<KaraNoktaDto> GetBusPoint()
        {
            BawsXmlProviderService xmlProvider = new BawsXmlProviderService();

            string xml = "<KaraNoktaGetirKomut/>";
            string result = xmlProvider.GetXmlFromService(xml);

            return Converter.ConvertXml(result);
        }

        public Task<string> GetBusPointAsync()
        {
            BawsXmlProviderService xmlProvider = new BawsXmlProviderService();

            string xml = "<KaraNoktaGetirKomut/>";
            Task<string> result = xmlProvider.GetXmlFromServiceAsync(xml);

            return result;
      
    }
}
}
