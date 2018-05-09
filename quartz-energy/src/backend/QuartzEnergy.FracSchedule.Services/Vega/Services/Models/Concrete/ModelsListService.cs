namespace QuartzEnergy.FracSchedule.Services.Vega.Services.Models.Concrete
{
    using System.Linq;

    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Services.Services.Lists;
    using QuartzEnergy.FracSchedule.Domain.Entities;
    using QuartzEnergy.FracSchedule.Services.Vega.Models.Models.Lists;
    using QuartzEnergy.FracSchedule.Services.Vega.Specifications;

    public sealed class ModelsListService
        : IntIdModelsListService<ModelEntity, ModelsListRequest>, IModelsListService
    {
        public ModelsListService(IUnitOfWorkFactory unitOfWorkFactory)
            : base(unitOfWorkFactory)
        {
        }

        protected override IQueryable<ModelEntity> GetEntitiesQuery(
            IRepository<ModelEntity> rep, 
            ModelsListRequest request)
        {
            return rep.GetAll()
                    .GetByMakers(request.Makers);
        }
    }
}
