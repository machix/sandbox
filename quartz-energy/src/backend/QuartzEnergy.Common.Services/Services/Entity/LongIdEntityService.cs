namespace QuartzEnergy.Common.Services.Services.Entity
{
    using AutoMapper;

    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Domain.Entities;
    using QuartzEnergy.Common.Services.Models.Business;

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
