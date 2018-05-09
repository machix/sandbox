namespace QuartzEnergy.Common.Services.Services.Lists
{
    using System;

    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Domain.Entities;
    using QuartzEnergy.Common.Domain.Interfaces;

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
