namespace QuartzEnergy.Common.Services.Services.Lists
{
    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Domain.Entities;
    using QuartzEnergy.Common.Domain.Interfaces;

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
