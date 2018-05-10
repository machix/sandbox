namespace QuartzEnergy.FracSchedule.Web.FracSchedule.Controllers.Schedules
{
    using AutoMapper;

    using QuartzEnergy.Common.Web.Controllers.Entity;
    using QuartzEnergy.FracSchedule.Services.FracSchedule.Models.Schedules.Entity;
    using QuartzEnergy.FracSchedule.Services.FracSchedule.Models.Schedules.Overviews;
    using QuartzEnergy.FracSchedule.Services.FracSchedule.Services.Schedules;
    using QuartzEnergy.FracSchedule.Web.FracSchedule.Resources.Schedules.Entity;
    using QuartzEnergy.FracSchedule.Web.FracSchedule.Resources.Schedules.Overviews;

    public sealed class SchedulesController :
        IntIdEntityApiController<
            ISchedulesService,
            Schedule,
            ScheduleOverviewsRequest,
            ScheduleOverviews,
            ScheduleResource,
            ScheduleOverviewsRequestResource,
            ScheduleOverviewsResource>
    {
        public SchedulesController(ISchedulesService service, IMapper mapper)
            : base(service, mapper)
        {
        }
    }
}