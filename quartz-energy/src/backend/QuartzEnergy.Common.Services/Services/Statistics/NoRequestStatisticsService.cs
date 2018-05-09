namespace QuartzEnergy.Common.Services.Services.Statistics
{
    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Services.Models.Statistics;

    public abstract class NoRequestStatisticsService<TData>
        : StatisticsService<EmptyStatisticsRequest, TData>
    {
        protected NoRequestStatisticsService(IUnitOfWorkFactory unitOfWorkFactory)
            : base(unitOfWorkFactory)
        {
        }
    }
}
