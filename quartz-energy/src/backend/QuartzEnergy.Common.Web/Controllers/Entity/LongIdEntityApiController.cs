namespace QuartzEnergy.Common.Web.Controllers.Entity
{
    using AutoMapper;

    using QuartzEnergy.Common.Services.Models.Business;
    using QuartzEnergy.Common.Services.Services.Entity.Interfaces;

    public abstract class LongIdEntityApiController
        <TService, TModel, TOverviewsRequest, TOverviews, TResource, TOverviewsRequestResource, TOverviewsResource> :
            EntityApiController<TService, TModel, long, TOverviewsRequest, TOverviews, TResource, TOverviewsRequestResource, TOverviewsResource>
        where TService : ILongIdEntityService<TModel, TOverviewsRequest, TOverviews>
        where TModel : LongIdBusinessModel
    {
        protected LongIdEntityApiController(TService service, IMapper mapper)
            : base(service, mapper)
        {
        }
    }
}
