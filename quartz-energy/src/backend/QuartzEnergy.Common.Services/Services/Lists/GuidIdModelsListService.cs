namespace QuartzEnergy.Common.Services.Services.Lists
{
    using System;
    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Domain.Entities;
    using QuartzEnergy.Common.Domain.Interfaces;

    public abstract class GuidIdModelsListService<TEntity, TRequest>
        : ModelsListService<TEntity, Guid, TRequest>
        where TEntity : GuidIdEntity, INamedEntity
    {
        protected GuidIdModelsListService(IUnitOfWorkFactory unitOfWorkFactory) : base(unitOfWorkFactory)
        {
        }
    }
}
