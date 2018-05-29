namespace Ett.Common.Services.Services.Lists
{
    using Ett.Common.Dal.Infrastructure;
    using Ett.Common.Domain.Entities;
    using Ett.Common.Domain.Interfaces;

    public abstract class IntIdModelsListService<TEntity, TRequest>
        : ModelsListService<TEntity, int, TRequest>
        where TEntity : IntIdEntity, INamedEntity
    {
        protected IntIdModelsListService(IUnitOfWorkFactory unitOfWorkFactory) : base(unitOfWorkFactory)
        {
        }
    }
}
