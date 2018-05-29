namespace Ett.Common.Services.Services.Lists
{
    using System;
    using Ett.Common.Dal.Infrastructure;
    using Ett.Common.Domain.Entities;
    using Ett.Common.Domain.Interfaces;

    public abstract class GuidIdModelsListService<TEntity, TRequest>
        : ModelsListService<TEntity, Guid, TRequest>
        where TEntity : GuidIdEntity, INamedEntity
    {
        protected GuidIdModelsListService(IUnitOfWorkFactory unitOfWorkFactory) : base(unitOfWorkFactory)
        {
        }
    }
}
