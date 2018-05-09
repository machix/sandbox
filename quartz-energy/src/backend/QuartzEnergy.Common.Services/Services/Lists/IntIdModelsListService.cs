namespace QuartzEnergy.Common.Services.Services.Lists
{
    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Domain.Entities;
    using QuartzEnergy.Common.Domain.Interfaces;

    public abstract class IntIdModelsListService<TEntity, TRequest>
        : ModelsListService<TEntity, int, TRequest>
        where TEntity : IntIdEntity, INamedEntity
    {
        protected IntIdModelsListService(IUnitOfWorkFactory unitOfWorkFactory) : base(unitOfWorkFactory)
        {
        }
    }
}
