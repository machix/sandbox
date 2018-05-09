namespace QuartzEnergy.Common.Web.Controllers.Statistics
{
    using AutoMapper;

    using QuartzEnergy.Common.Services.Models.Statistics;
    using QuartzEnergy.Common.Services.Services.Statistics.Interfaces;
    using QuartzEnergy.Common.Web.Resources.Statistics;

    public abstract class NoRequestStatisticsApiController<TService, TData>
        : StatisticsApiController<TService, EmptyStatisticsRequest, EmptyStatisticsRequestResource, TData>
        where TService : IStatisticsService<EmptyStatisticsRequest, TData>
    {
        protected NoRequestStatisticsApiController(TService service, IMapper mapper)
            : base(service, mapper)
        {
        }
    }
}
