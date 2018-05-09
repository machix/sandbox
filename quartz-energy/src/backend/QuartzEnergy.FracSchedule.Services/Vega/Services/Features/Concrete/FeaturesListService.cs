namespace QuartzEnergy.FracSchedule.Services.Vega.Services.Features.Concrete
{
    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Services.Services.Lists;
    using QuartzEnergy.FracSchedule.Domain.Entities;

    public sealed class FeaturesListService
        : IntIdNoRequestListService<FeatureEntity>, IFeaturesListService
    {
        public FeaturesListService(IUnitOfWorkFactory unitOfWorkFactory)
            : base(unitOfWorkFactory)
        {
        }
    }
}
