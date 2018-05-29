namespace Ett.Common.Services.Services.Lists
{
    using Ett.Common.Dal.Infrastructure;
    using Ett.Common.Domain.Entities;
    using Ett.Common.Domain.Interfaces;

    public abstract class IntIdNoRequestListService<TEntity>
        : NoRequestListService<TEntity, int>
        where TEntity : IntIdEntity, INamedEntity
    {
        protected IntIdNoRequestListService(IUnitOfWorkFactory unitOfWorkFactory)
            : base(unitOfWorkFactory)
        {
        }
    }
}
