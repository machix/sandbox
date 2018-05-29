namespace Ett.Common.Web.Controllers.Statistics
{
    using AutoMapper;

    using Ett.Common.Services.Models.Statistics;
    using Ett.Common.Services.Services.Statistics.Interfaces;
    using Ett.Common.Web.Resources.Statistics;

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
