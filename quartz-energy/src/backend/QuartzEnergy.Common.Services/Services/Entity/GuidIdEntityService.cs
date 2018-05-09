namespace QuartzEnergy.Common.Services.Services.Entity
{
    using System;

    using AutoMapper;

    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Domain.Entities;
    using QuartzEnergy.Common.Services.Models.Business;

    public abstract class GuidIdEntityService<TEntity, TModel, TOverviewsRequest, TOverviews>
        : EntityService<TEntity, TModel, Guid, TOverviewsRequest, TOverviews>
        where TEntity : GuidIdEntity
        where TModel : GuidIdBusinessModel
    {
        protected GuidIdEntityService(IUnitOfWorkFactory unitOfWorkFactory, IMapper mapper)
            : base(unitOfWorkFactory, mapper)
        {
        }
    }
}
