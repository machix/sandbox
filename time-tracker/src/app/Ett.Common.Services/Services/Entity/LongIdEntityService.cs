namespace Ett.Common.Services.Services.Entity
{
    using AutoMapper;

    using Ett.Common.Dal.Infrastructure;
    using Ett.Common.Domain.Entities;
    using Ett.Common.Services.Models.Business;

    public abstract class LongIdEntityService<TEntity, TModel, TOverviewsRequest, TOverviews>
        : EntityService<TEntity, TModel, long, TOverviewsRequest, TOverviews>
        where TEntity : LongIdEntity
        where TModel : LongIdBusinessModel
    {
        protected LongIdEntityService(IUnitOfWorkFactory unitOfWorkFactory, IMapper mapper)
            : base(unitOfWorkFactory, mapper)
        {
        }
    }
}
