using Biletall.Application.RequestModel;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biletall.Application.Interfaces
{
    public interface IBusJourneyService
    {
        Task<string> GetJourneyAsync();

        List<Table> GetJourney(JourneySearchModel model);

    }
}
