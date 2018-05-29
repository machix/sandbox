namespace Ett.Common.Web.Controllers.Entity
{
    using AutoMapper;

    using Ett.Common.Services.Models.Business;
    using Ett.Common.Services.Services.Entity.Interfaces;

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
