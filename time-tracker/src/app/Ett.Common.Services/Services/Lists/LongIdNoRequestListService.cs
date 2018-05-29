namespace Ett.Common.Services.Services.Lists
{
    using Ett.Common.Dal.Infrastructure;
    using Ett.Common.Domain.Entities;
    using Ett.Common.Domain.Interfaces;

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
