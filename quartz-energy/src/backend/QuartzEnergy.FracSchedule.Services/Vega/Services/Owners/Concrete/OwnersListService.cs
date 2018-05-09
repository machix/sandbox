namespace QuartzEnergy.FracSchedule.Services.Vega.Services.Owners.Concrete
{
    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Services.Models.Lists;
    using QuartzEnergy.Common.Services.Services.Lists;
    using QuartzEnergy.FracSchedule.Domain.Entities;
    using QuartzEnergy.FracSchedule.Services.Vega.Services.Owners;

    public sealed class OwnersListService
        : PersonsListService<OwnerEntity, int, EmptyListRequest>, IOwnersListService
    {
        public OwnersListService(IUnitOfWorkFactory unitOfWorkFactory)
            : base(unitOfWorkFactory)
        {
        }
    }
}
