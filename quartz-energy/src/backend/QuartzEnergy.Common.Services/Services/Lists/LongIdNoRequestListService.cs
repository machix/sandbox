namespace QuartzEnergy.Common.Services.Services.Lists
{
    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Domain.Entities;
    using QuartzEnergy.Common.Domain.Interfaces;

    public abstract class LongIdNoRequestListService<TEntity>
        : NoRequestListService<TEntity, long>
        where TEntity : LongIdEntity, INamedEntity
    {
        protected LongIdNoRequestListService(IUnitOfWorkFactory unitOfWorkFactory)
            : base(unitOfWorkFactory)
        {
        }
    }
}
