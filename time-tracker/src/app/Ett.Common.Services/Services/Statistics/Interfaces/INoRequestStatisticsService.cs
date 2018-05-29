namespace Ett.Common.Services.Services.Statistics.Interfaces
{
    using Ett.Common.Services.Models.Statistics;
    public interface INoRequestStatisticsService<TData> : IStatisticsService<EmptyStatisticsRequest, TData>
    {        
    }
}
