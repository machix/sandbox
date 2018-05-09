namespace QuartzEnergy.Common.Services.Services.Statistics.Interfaces
{
    using QuartzEnergy.Common.Services.Models.Statistics;
    public interface INoRequestStatisticsService<TData> : IStatisticsService<EmptyStatisticsRequest, TData>
    {        
    }
}
