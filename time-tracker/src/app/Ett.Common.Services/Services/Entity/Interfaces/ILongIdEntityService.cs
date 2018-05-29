namespace Ett.Common.Services.Services.Entity.Interfaces
{
    using Ett.Common.Services.Models.Business;

    public interface ILongIdEntityService<TModel, in TOverviewsRequest, TOverviews>
        : IEntityService<TModel, long, TOverviewsRequest, TOverviews>
        where TModel : LongIdBusinessModel
    {
    }
}
