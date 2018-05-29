namespace Ett.Common.Services.Services.Lists
{
    using Ett.Common.Dal.Infrastructure;
    using Ett.Common.Domain.Entities;
    using Ett.Common.Domain.Interfaces;

    public abstract class LongIdModelsListService<TEntity, TRequest>
        : ModelsListService<TEntity, long, TRequest>
        where TEntity : LongIdEntity, INamedEntity
    {
        protected LongIdModelsListService(IUnitOfWorkFactory unitOfWorkFactory) : base(unitOfWorkFactory)
        {
        }
    }
}
