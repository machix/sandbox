namespace QuartzEnergy.FracSchedule.Services.Vega.Services.Makers.Concrete
{
    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Services.Services.Lists;
    using QuartzEnergy.FracSchedule.Domain.Entities;

    public sealed class MakersListService
        : IntIdNoRequestListService<MakerEntity>, IMakersListService
    {
        public MakersListService(IUnitOfWorkFactory unitOfWorkFactory)
            : base(unitOfWorkFactory)
        {
        }
    }
}
