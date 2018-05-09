namespace QuartzEnergy.FracSchedule.Services.Vega.Services.Vehicles
{
    using QuartzEnergy.Common.Services.Services.Entity.Interfaces;
    using QuartzEnergy.FracSchedule.Services.Vega.Models.Vehicles.Entity;
    using QuartzEnergy.FracSchedule.Services.Vega.Models.Vehicles.Overviews;

    public interface IVehiclesService
        : IIntIdEntityService<Vehicle, VehicleOverviewsRequest, VehicleOverviews>
    {
    }
}
