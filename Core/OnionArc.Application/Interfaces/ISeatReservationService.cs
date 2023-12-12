using Biletall.Application.Dto;
using Biletall.Application.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Biletall.Application.Dto.ReservationDto;

namespace Biletall.Application.Interfaces
{
    public interface ISeatReservationService
    {
       List<IslemSonuc> GetReservation(ReservationModel model);
    }
}
