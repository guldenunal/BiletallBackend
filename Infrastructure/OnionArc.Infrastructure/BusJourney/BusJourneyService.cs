using Biletall.Application.Interfaces;
using Biletall.Infrastructure.Baws;
using Biletall.Infrastructure.Helper;
using Biletall.Application.RequestModel;


namespace Biletall.Infrastructure.BusJourney

{
    public class BusJourneyService : IBusJourneyService
    {
        public List<Table> GetJourney(JourneySearchModel model)
        {
            BawsXmlProviderService xmlProvider = new BawsXmlProviderService();


            string xml = $"<Sefer> " +
                $" <FirmaNo>0</FirmaNo>" +
                $" <KalkisNoktaID>{model.KalkisNoktaID}</KalkisNoktaID>" +
                $" <VarisNoktaID>{model.VarisNoktaID}</VarisNoktaID> " +
                $" <Tarih>{Convert.ToDateTime(model.Tarih).ToLocalTime().ToString("yyyy-MM-dd")}</Tarih> " +
                $"<AraNoktaGelsin>{model.AraNoktaGelsin}</AraNoktaGelsin>" +
                $"  <IslemTipi>{model.IslemTipi}</IslemTipi>  " +
                $"<YolcuSayisi>{model.YolcuSayisi}</YolcuSayisi>  " +
                $"<Ip>127.0.0.1</Ip></Sefer>";

            string result = xmlProvider.GetXmlFromService(xml);
            return Converter.Convert(result);
        }

        public Task<string> GetJourneyAsync()
        {
            throw new NotImplementedException();
        }

     
    }
}

