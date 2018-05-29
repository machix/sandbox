namespace Ett.Common.Web.Controllers.Lists
{
    using System.Threading.Tasks;
    using System.Web.Http;

    using AutoMapper;

    using Ett.Common.Services.Services.Lists.Interfaces;
    using Ett.Common.Web.Resources.Lists;

    using ApiController = Common.ApiController;

    public abstract class ModelsListApiController<TService, TRequest, TRequestResource>
        : ApiController
        where TService : IModelsListService<TRequest>
    {
        protected readonly TService Service;

        protected readonly IMapper Mapper;

        protected ModelsListApiController(TService service, IMapper mapper)
        {
            this.Service = service;
            this.Mapper = mapper;
        }

        [HttpGet]
        public virtual async Task<IHttpActionResult> Get([FromUri] TRequestResource requestResource)
        {
            var request = this.Mapper.Map<TRequest>(requestResource);
            var model = await this.Service.GetList(request);
            var resource = this.Mapper.Map<ModelsListResource<TRequest>>(model);

            return this.Ok(resource);
        }
    }
}
