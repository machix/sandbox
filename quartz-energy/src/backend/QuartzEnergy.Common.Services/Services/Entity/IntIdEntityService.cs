namespace QuartzEnergy.Common.Services.Services.Entity
{
    using AutoMapper;

    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Domain.Entities;
    using QuartzEnergy.Common.Services.Models.Business;

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
