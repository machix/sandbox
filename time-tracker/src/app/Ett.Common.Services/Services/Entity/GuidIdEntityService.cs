﻿namespace Ett.Common.Services.Services.Entity
{
    using System;

    using AutoMapper;

    using Ett.Common.Dal.Infrastructure;
    using Ett.Common.Domain.Entities;
    using Ett.Common.Services.Models.Business;

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
