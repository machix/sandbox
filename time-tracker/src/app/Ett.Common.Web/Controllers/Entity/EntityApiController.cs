namespace Ett.Common.Web.Controllers.Entity
{
    using System.Threading.Tasks;
    using System.Web.Http;

    using AutoMapper;

    using Ett.Common.Services.Models.Business;
    using Ett.Common.Services.Services.Entity.Interfaces;

    using ApiController = Common.ApiController;

    public abstract class EntityApiController
        <TService, TBusinessModel, TId, TOverviewsRequest, TOverviews, TResource, TOverviewsRequestResource, TOverviewsResource>
        : ApiController
        where TService : IEntityService<TBusinessModel, TId, TOverviewsRequest, TOverviews>
        where TBusinessModel : BusinessModel<TId>
    {
        protected readonly TService Service;

        protected readonly IMapper Mapper;

        protected EntityApiController(TService service, IMapper mapper)
        {
            this.Service = service;
            this.Mapper = mapper;
        }

        [HttpGet]
        [Route("overviews")]        
        public virtual async Task<IHttpActionResult> Get([FromUri] TOverviewsRequestResource requestResource)
        {
            var request = this.Mapper.Map<TOverviewsRequest>(requestResource);
            var overviews = await this.Service.GetOverviews(request);
            var overviewsResource = this.Mapper.Map<TOverviewsResource>(overviews);

            return this.Ok(overviewsResource);
        }

        [HttpGet]
        [Route("{id}")]
        public virtual async Task<IHttpActionResult> Get([FromUri] TId id)
        {
            var model = await this.Service.Read(id);
            var resource = this.Mapper.Map<TResource>(model);

            return this.Ok(resource);
        }

        [HttpPost]
        public virtual async Task<IHttpActionResult> Post([FromBody] TResource resource)
        {
            var model = this.Mapper.Map<TBusinessModel>(resource);
            var result = await this.Service.CreateOrUpdate(model);

            return this.Ok(this.Mapper.Map<TResource>(result));
        }

        [HttpPut]
        [Route("{id}")]
        public virtual async Task<IHttpActionResult> Put([FromUri] TId id, [FromBody] TResource resource)
        {
            var model = this.Mapper.Map<TBusinessModel>(resource);
            model.UpdateId(id);
            var result = await this.Service.CreateOrUpdate(model);

            return this.Ok(this.Mapper.Map<TResource>(result));
        }

        [HttpDelete]
        [Route("{id}")]
        public virtual async Task Delete([FromUri] TId id)
        {
            await this.Service.Delete(id);
        }
    }
}
