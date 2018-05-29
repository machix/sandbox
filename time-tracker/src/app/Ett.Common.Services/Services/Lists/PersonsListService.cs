namespace Ett.Common.Services.Services.Lists
{
    using System.Linq;
    using System.Threading.Tasks;

    using Ett.Common.Dal.Infrastructure;
    using Ett.Common.Domain.Entities;
    using Ett.Common.Domain.Interfaces;
    using Ett.Common.Services.Mappers;
    using Ett.Common.Services.Models.Lists;
    using Ett.Common.Services.Services.Common;
    using Ett.Common.Services.Services.Lists.Interfaces;

    public abstract class PersonsListService<TEntity, TId, TRequest>
        : UnitOfWorkService, IModelsListService<TRequest>
        where TEntity : Entity<TId>, INamedPerson
    {
        protected PersonsListService(IUnitOfWorkFactory unitOfWorkFactory)
            : base(unitOfWorkFactory)
        {
        }

        protected virtual IQueryable<TEntity> GetEntitiesQuery(IRepository<TEntity> rep, TRequest request)
        {
            return rep.GetAll();
        }

        public virtual async Task<ModelsList<TRequest>> GetList(TRequest request)
        {
            using (var uow = this.CreateWithDisabledLazyLoading())
            {
                var rep = uow.GetRepository<TEntity>();

                return await ModelsListMapper.MapToPersonsList<TEntity, TId, TRequest>(
                           this.GetEntitiesQuery(rep, request),
                           request);
            }
        }
    }
}
