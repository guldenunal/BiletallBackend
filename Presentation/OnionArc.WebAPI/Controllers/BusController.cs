using Biletall.Application.Interfaces;
using Biletall.Application.RequestModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biletall.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {

        private readonly IBusPointService _busPointService;
        private readonly IBusJourneyService _busJourneyService;
        private readonly IBusInfoService _busInfoService;
        private readonly ISeatReservationService _seatReservationService;


        public BusController(IBusPointService busPointService, 
                             IBusJourneyService busJourneyService,
                             IBusInfoService busInfoService,
                             ISeatReservationService seatReservationService)
        {
            _busPointService = busPointService;
            _busJourneyService = busJourneyService;
            _busInfoService = busInfoService;
            _seatReservationService = seatReservationService;
        }

        [HttpGet]
        public IActionResult BusPoint()
        {
            var a = _busPointService.GetBusPoint();
            return Ok(a);
        }
      
       [HttpPost("BusJourney")]
        public IActionResult BusJourney([FromBody] JourneySearchModel model)
        {
           
                if (model == null)
                {
                    return BadRequest("Invalid search model");
                }
            else {
                var a = _busJourneyService.GetJourney(model);
            return Ok(a); }
        }

        [HttpPost("BusInfo")]
        public IActionResult BusInfo([FromBody] BusSearchModel model)
        {
            if (model == null)
            {
                return BadRequest("Invalid search model");
            }
            else
            {
                var a = _busInfoService.getBusInfo(model);
                return Ok(a);
            }
        }

        [HttpPost("Reservation")]
        public IActionResult Reservation([FromBody] ReservationModel model) {
        
            if (model == null)
            {
                return BadRequest();
            }
            else
            {
                var a = _seatReservationService.GetReservation(model); 
                return Ok(a);
            }
        }

    }


}
