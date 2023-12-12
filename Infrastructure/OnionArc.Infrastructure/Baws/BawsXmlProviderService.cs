using Baws.SoapService;
using Biletall.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Biletall.Infrastructure.Baws
{
    internal class BawsXmlProviderService : IBawsXmlProviderService
    {
        private readonly ServiceSoapClient _serviceSoapClient;
        public BawsXmlProviderService() { 
        _serviceSoapClient = new ServiceSoapClient(ServiceSoapClient.EndpointConfiguration.ServiceSoap12, "https://ws.biletall.com/service.asmx");
        }
        public XmlElement CreateXmlElement(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            return doc.DocumentElement;
        }
        public XmlElement GetUserXml()
        {
            return CreateXmlElement("<Kullanici><Adi>...</Adi><Sifre>....</Sifre><AcenteProje>...</AcenteProje><SatisKanal>...</SatisKanal></Kullanici>");
        }
        public string GetXmlFromService(string xml)
        {
            var element = _serviceSoapClient.XmlIslet(CreateXmlElement(xml), GetUserXml());
            string result = element.OuterXml;

            return result;
        }

        public async Task<string> GetXmlFromServiceAsync(string xml)
        {
            var element = await _serviceSoapClient.XmlIsletAsync(CreateXmlElement(xml), GetUserXml());
            string result = element.Body.XmlIsletResult.OuterXml;

            return result;
        }
    }
}
