namespace QuartzEnergy.FracSchedule.Services.FracSchedule.Models.Schedules.Overviews
{
    using System.Collections.Generic;

    using QuartzEnergy.Common.Services.Models.Overviews;

    public sealed class ScheduleOverviews : OverviewsModel<ScheduleOverviewsRequest, ScheduleOverview>
    {
        public ScheduleOverviews(
            ScheduleOverviewsRequest request,
            int recordsCount,
            IEnumerable<ScheduleOverview> overviews,
            ScheduleSummary summary)
            : base(request, recordsCount, overviews)
        {
            this.Summary = summary;
        }

        public ScheduleSummary Summary { get; }
    }
}