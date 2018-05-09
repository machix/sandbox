namespace QuartzEnergy.FracSchedule.Web.Controllers.Vehicles
{
    using AutoMapper;

    using QuartzEnergy.Common.Web.Constants;
    using QuartzEnergy.Common.Web.Controllers.Statistics;
    using QuartzEnergy.FracSchedule.Services.Vega.Models.Vehicles.Statistics;
    using QuartzEnergy.FracSchedule.Services.Vega.Services.Vehicles;

    using Microsoft.AspNetCore.Mvc;

    [Route(Routes.ApiRoute + "vehicles/statistics/bymakers")]
    public sealed class VehiclesStatisticsController
        : NoRequestStatisticsApiController<IVehiclesStatisticsService, VehiclesByMakerData>
    {
        public VehiclesStatisticsController(IVehiclesStatisticsService service, IMapper mapper)
            : base(service, mapper)
        {
        }
    }
}
