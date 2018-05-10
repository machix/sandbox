namespace QuartzEnergy.FracSchedule.Services.FracSchedule.Services.Regions.Concrete
{
    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Services.Services.Lists;
    using QuartzEnergy.FracSchedule.Domain.FracSchedule.Entities;

    public sealed class RegionsListService
        : IntIdNoRequestListService<RegionEntity>, IRegionsListService
    {
        public RegionsListService(IUnitOfWorkFactory unitOfWorkFactory)
            : base(unitOfWorkFactory)
        {
        }
    }
}