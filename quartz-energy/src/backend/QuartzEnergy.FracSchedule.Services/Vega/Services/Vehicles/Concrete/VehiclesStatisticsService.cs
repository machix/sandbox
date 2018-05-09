namespace QuartzEnergy.FracSchedule.Services.Vega.Services.Vehicles.Concrete
{
    using System.Threading.Tasks;

    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Services.Models.Statistics;
    using QuartzEnergy.Common.Services.Services.Statistics;
    using QuartzEnergy.FracSchedule.Domain.Entities;
    using QuartzEnergy.FracSchedule.Services.Vega.Mappers;
    using QuartzEnergy.FracSchedule.Services.Vega.Models.Vehicles.Statistics;

    public sealed class VehiclesStatisticsService
        : NoRequestStatisticsService<VehiclesByMakerData>, IVehiclesStatisticsService
    {
        public VehiclesStatisticsService(IUnitOfWorkFactory unitOfWorkFactory)
            : base(unitOfWorkFactory)
        {
        }

        protected override async Task<Statistics<EmptyStatisticsRequest, VehiclesByMakerData>> DoGetStatistics(IUnitOfWork uow, EmptyStatisticsRequest request)
        {
            var vehiclesRep = uow.GetRepository<VehicleEntity>();
            var makersRep = uow.GetRepository<MakerEntity>();
            var modelsRep = uow.GetRepository<ModelEntity>();

            return await VehiclesMapper.MapToStatisticsByMakers(
                       vehiclesRep.GetAll(),
                       makersRep.GetAll(),
                       modelsRep.GetAll());
        }
    }
}
