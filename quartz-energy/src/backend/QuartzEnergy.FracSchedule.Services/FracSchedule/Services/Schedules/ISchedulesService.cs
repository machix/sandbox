namespace QuartzEnergy.FracSchedule.Services.FracSchedule.Services.Schedules
{
    using QuartzEnergy.Common.Services.Services.Entity.Interfaces;
    using QuartzEnergy.FracSchedule.Services.FracSchedule.Models.Schedules.Entity;
    using QuartzEnergy.FracSchedule.Services.FracSchedule.Models.Schedules.Overviews;

    public interface ISchedulesService
        : IIntIdEntityService<Schedule, ScheduleOverviewsRequest, ScheduleOverviews>
    {
    }
}