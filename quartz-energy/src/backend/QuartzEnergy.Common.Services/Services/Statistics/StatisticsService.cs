﻿namespace QuartzEnergy.Common.Services.Services.Statistics
{
    using System.Threading.Tasks;

    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Services.Models.Statistics;
    using QuartzEnergy.Common.Services.Services.Common;
    using QuartzEnergy.Common.Services.Services.Statistics.Interfaces;

    public abstract class StatisticsService<TRequest, TData>
        : UnitOfWorkService, IStatisticsService<TRequest, TData>
    {
        protected StatisticsService(IUnitOfWorkFactory unitOfWorkFactory)
            : base(unitOfWorkFactory)
        {
        }

        protected abstract Task<Statistics<TRequest, TData>> DoGetStatistics(IUnitOfWork uow, TRequest request);

        public virtual async Task<Statistics<TRequest, TData>> GetStatistics(TRequest request)
        {
            using (var uow = this.CreateWithDisabledLazyLoading())
            {
                return await this.DoGetStatistics(uow, request);
            }
        }
    }
}
