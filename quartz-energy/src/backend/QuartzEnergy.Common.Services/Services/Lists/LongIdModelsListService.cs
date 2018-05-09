namespace QuartzEnergy.Common.Services.Services.Lists
{
    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Domain.Entities;
    using QuartzEnergy.Common.Domain.Interfaces;

    public abstract class LongIdModelsListService<TEntity, TRequest>
        : ModelsListService<TEntity, long, TRequest>
        where TEntity : LongIdEntity, INamedEntity
    {
        protected LongIdModelsListService(IUnitOfWorkFactory unitOfWorkFactory) : base(unitOfWorkFactory)
        {
        }
    }
}
