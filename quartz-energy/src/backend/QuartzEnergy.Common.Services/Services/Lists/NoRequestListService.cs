namespace QuartzEnergy.Common.Services.Services.Lists
{
    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Domain.Entities;
    using QuartzEnergy.Common.Domain.Interfaces;
    using QuartzEnergy.Common.Services.Models.Lists;

    public abstract class NoRequestListService<TEntity, TId>
        : ModelsListService<TEntity, TId, EmptyListRequest>
        where TEntity : Entity<TId>, INamedEntity
    {
        protected NoRequestListService(IUnitOfWorkFactory unitOfWorkFactory)
            : base(unitOfWorkFactory)
        {
        }
    }
}
