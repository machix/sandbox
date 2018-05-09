namespace QuartzEnergy.Common.Web.Controllers.Statistics
{
    using System.Threading.Tasks;

    using AutoMapper;

    using QuartzEnergy.Common.Services.Services.Statistics.Interfaces;
    using QuartzEnergy.Common.Web.Controllers.Common;
    using QuartzEnergy.Common.Web.Resources.Statistics;

    using Microsoft.AspNetCore.Mvc;

    public abstract class StatisticsApiController<TService, TRequest, TRequestResource, TData>
        : ApiController
        where TService : IStatisticsService<TRequest, TData>
    {
        protected readonly TService Service;

        protected readonly IMapper Mapper;

        protected StatisticsApiController(TService service, IMapper mapper)
        {
            this.Service = service;
            this.Mapper = mapper;
        }

        [HttpGet]
        public virtual async Task<IActionResult> Get([FromQuery] TRequestResource requestResource)
        {
            var request = this.Mapper.Map<TRequest>(requestResource);
            var model = await this.Service.GetStatistics(request);
            var resource = this.Mapper.Map<StatisticsResource<TRequest, TData>>(model);

            return this.Ok(resource);
        }
    }
}
