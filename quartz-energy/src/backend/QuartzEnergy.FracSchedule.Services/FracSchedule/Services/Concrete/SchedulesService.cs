namespace QuartzEnergy.FracSchedule.Services.FracSchedule.Services.Concrete
{
    using System.Threading.Tasks;

    using AutoMapper;

    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Services.Services.Entity;
    using QuartzEnergy.FracSchedule.Domain.FracSchedule.Entities;
    using QuartzEnergy.FracSchedule.Services.FracSchedule.Mappers;
    using QuartzEnergy.FracSchedule.Services.FracSchedule.Models.Schedules.Entity;
    using QuartzEnergy.FracSchedule.Services.FracSchedule.Models.Schedules.Overviews;

    public sealed class SchedulesService
        : IntIdEntityService<ScheduleEntity, Schedule, ScheduleOverviewsRequest, ScheduleOverviews>, ISchedulesService
    {
        public SchedulesService(IUnitOfWorkFactory unitOfWorkFactory, IMapper mapper)
            : base(unitOfWorkFactory, mapper)
        {
        }

        protected override async Task<ScheduleOverviews> DoGetOverviews(IUnitOfWork uow, ScheduleOverviewsRequest request)
        {
            var schedulesRep = uow.GetRepository<ScheduleEntity>();
            var companiesRep = uow.GetRepository<CompanyEntity>();
            var wellsRep = uow.GetRepository<WellEntity>();

            return await SchedulesMapper.MapToScheduleOverviews(
                request,
                schedulesRep.GetAll(),
                companiesRep.GetAll(),
                wellsRep.GetAll());
        }
    }
}