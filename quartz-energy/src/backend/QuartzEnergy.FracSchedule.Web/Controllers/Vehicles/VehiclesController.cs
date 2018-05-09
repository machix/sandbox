namespace QuartzEnergy.FracSchedule.Web.Controllers.Vehicles
{
    using AutoMapper;

    using QuartzEnergy.Common.Web.Controllers.Entity;
    using QuartzEnergy.FracSchedule.Services.Vega.Models.Vehicles.Entity;
    using QuartzEnergy.FracSchedule.Services.Vega.Models.Vehicles.Overviews;
    using QuartzEnergy.FracSchedule.Services.Vega.Services.Vehicles;
    using QuartzEnergy.FracSchedule.Web.Resources.Vehicles.Entity;
    using QuartzEnergy.FracSchedule.Web.Resources.Vehicles.Overviews;

    public sealed class VehiclesController :
        IntIdEntityApiController<
            IVehiclesService,
            Vehicle,
            VehicleOverviewsRequest,
            VehicleOverviews,
            VehicleResource,
            VehicleOverviewsRequestResource,
            VehicleOverviewsResource>
    {
        public VehiclesController(IVehiclesService service, IMapper mapper)
            : base(service, mapper)
        {
        }
    }
}
