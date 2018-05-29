namespace Ett.Common.Services.Services.Statistics
{
    using Ett.Common.Dal.Infrastructure;
    using Ett.Common.Services.Models.Statistics;

    public abstract class NoRequestStatisticsService<TData>
        : StatisticsService<EmptyStatisticsRequest, TData>
    {
        protected NoRequestStatisticsService(IUnitOfWorkFactory unitOfWorkFactory)
            : base(unitOfWorkFactory)
        {
        }
    }
}
