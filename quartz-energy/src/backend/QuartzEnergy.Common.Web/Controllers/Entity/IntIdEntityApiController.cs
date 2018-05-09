namespace QuartzEnergy.Common.Web.Controllers.Entity
{
    using AutoMapper;

    using QuartzEnergy.Common.Services.Models.Business;
    using QuartzEnergy.Common.Services.Services.Entity.Interfaces;

    public abstract class IntIdEntityApiController
        <TService, TModel, TOverviewsRequest, TOverviews, TResource, TOverviewsRequestResource, TOverviewsResource> : 
            EntityApiController<TService, TModel, int, TOverviewsRequest, TOverviews, TResource, TOverviewsRequestResource, TOverviewsResource>
        where TService : IIntIdEntityService<TModel, TOverviewsRequest, TOverviews> 
        where TModel : IntIdBusinessModel
    {
        protected IntIdEntityApiController(TService service, IMapper mapper)
            : base(service, mapper)
        {
        }
    }
}
