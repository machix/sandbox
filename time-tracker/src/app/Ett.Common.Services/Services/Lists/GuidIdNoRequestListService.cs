namespace Ett.Common.Services.Services.Lists
{
    using System;

    using Ett.Common.Dal.Infrastructure;
    using Ett.Common.Domain.Entities;
    using Ett.Common.Domain.Interfaces;

    public abstract class GuidIdNoRequestListService<TEntity>
        : NoRequestListService<TEntity, Guid>
        where TEntity : GuidIdEntity, INamedEntity
    {
        protected GuidIdNoRequestListService(IUnitOfWorkFactory unitOfWorkFactory)
            : base(unitOfWorkFactory)
        {
        }
    }
}
