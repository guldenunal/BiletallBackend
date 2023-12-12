using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Biletall.Application.Interfaces
{
    public interface IBawsXmlProviderService
    {
        Task<string> GetXmlFromServiceAsync(string xml);

        string GetXmlFromService(string xml);

        XmlElement GetUserXml();
    }
}
