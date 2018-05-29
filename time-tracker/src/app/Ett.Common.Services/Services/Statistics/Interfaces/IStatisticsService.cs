namespace Ett.Common.Services.Services.Statistics.Interfaces
{
    using Ett.Common.Services.Models.Statistics;
    using System.Threading.Tasks;

    public interface IStatisticsService<TRequest, TData>
    {
        Task<Statistics<TRequest, TData>> GetStatistics(TRequest request);
    }
}
