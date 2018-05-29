namespace Ett.Common.Services.Services.Lists
{
    using Ett.Common.Dal.Infrastructure;
    using Ett.Common.Domain.Entities;
    using Ett.Common.Domain.Interfaces;
    using Ett.Common.Services.Models.Lists;

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
