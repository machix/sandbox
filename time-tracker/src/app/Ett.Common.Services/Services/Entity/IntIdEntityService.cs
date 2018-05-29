namespace Ett.Common.Services.Services.Entity
{
    using AutoMapper;

    using Ett.Common.Dal.Infrastructure;
    using Ett.Common.Domain.Entities;
    using Ett.Common.Services.Models.Business;

    public abstract class IntIdEntityService<TEntity, TModel, TOverviewsRequest, TOverviews>
        : EntityService<TEntity, TModel, int, TOverviewsRequest, TOverviews>
        where TEntity : IntIdEntity
        where TModel : IntIdBusinessModel
    {
        protected IntIdEntityService(IUnitOfWorkFactory unitOfWorkFactory, IMapper mapper)
            : base(unitOfWorkFactory, mapper)
        {
        }
    }
}
