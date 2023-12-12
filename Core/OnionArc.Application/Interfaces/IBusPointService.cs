using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Biletall.Application.Interfaces
{
    public interface IBusPointService
    {
       List<KaraNoktaDto> GetBusPoint();

        Task<string> GetBusPointAsync();


    }
}
