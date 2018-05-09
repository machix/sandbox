namespace QuartzEnergy.Common.Services.Services.Lists
{
    using System.Linq;
    using System.Threading.Tasks;

    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Domain.Entities;
    using QuartzEnergy.Common.Domain.Interfaces;
    using QuartzEnergy.Common.Services.Mappers;
    using QuartzEnergy.Common.Services.Models.Lists;
    using QuartzEnergy.Common.Services.Services.Common;
    using QuartzEnergy.Common.Services.Services.Lists.Interfaces;

    public abstract class ModelsListService<TEntity, TId, TRequest>
        : UnitOfWorkService, IModelsListService<TRequest>
        where TEntity : Entity<TId>, INamedEntity
    {
        protected ModelsListService(IUnitOfWorkFactory unitOfWorkFactory)
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

                return await ModelsListMapper.MapToModelsList<TEntity, TId, TRequest>(
                    this.GetEntitiesQuery(rep, request),
                    request);
            }
        }
    }
}
