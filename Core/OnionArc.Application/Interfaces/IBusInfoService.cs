using Biletall.Application.Dto;
using Biletall.Application.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biletall.Application.Interfaces
{
   public interface IBusInfoService
    {
        List<Koltuk> getBusInfo(BusSearchModel model);

    }
}
