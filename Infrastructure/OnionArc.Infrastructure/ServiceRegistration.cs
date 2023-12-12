using Biletall.Application.Interfaces;
using Biletall.Infrastructure.Baws;
using Biletall.Infrastructure.BusPoint;
using Biletall.Infrastructure.BusJourney;
using Microsoft.Extensions.DependencyInjection;
using Biletall.Infrastructure.BusInfo;
using Biletall.Infrastructure.SeatReservation;

namespace Biletall.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastractureServices(this IServiceCollection service)
        {
            service.AddSingleton<IBawsXmlProviderService, BawsXmlProviderService>();
            service.AddSingleton<IBusPointService, BusPointService>();
            service.AddSingleton<IBusJourneyService, BusJourneyService>();
            service.AddSingleton<IBusInfoService, BusInfoService>();
            service.AddSingleton<ISeatReservationService, SeatReservationService>();
        }
    }
}