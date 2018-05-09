namespace QuartzEnergy.Common.Services.Services.Entity.Interfaces
{
    using QuartzEnergy.Common.Services.Models.Business;

    public interface IIntIdEntityService<TModel, in TOverviewsRequest, TOverviews>
        : IEntityService<TModel, int, TOverviewsRequest, TOverviews>
        where TModel : IntIdBusinessModel
    {
    }
}
