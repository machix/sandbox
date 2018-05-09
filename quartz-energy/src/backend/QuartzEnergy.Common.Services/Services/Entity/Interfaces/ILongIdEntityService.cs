namespace QuartzEnergy.Common.Services.Services.Entity.Interfaces
{
    using QuartzEnergy.Common.Services.Models.Business;

    public interface ILongIdEntityService<TModel, in TOverviewsRequest, TOverviews>
        : IEntityService<TModel, long, TOverviewsRequest, TOverviews>
        where TModel : LongIdBusinessModel
    {
    }
}
