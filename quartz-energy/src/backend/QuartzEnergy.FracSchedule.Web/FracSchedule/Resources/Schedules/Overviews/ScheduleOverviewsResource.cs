namespace QuartzEnergy.FracSchedule.Web.FracSchedule.Resources.Schedules.Overviews
{
    using System.Collections.Generic;

    using QuartzEnergy.Common.Web.Resources.Overviews;

    public sealed class ScheduleOverviewsResource 
        : OverviewsResource<ScheduleOverviewsRequestResource, ScheduleOverviewResource>
    {
        public ScheduleOverviewsResource()
        {            
        }

        public ScheduleOverviewsResource(
            ScheduleOverviewsRequestResource request,
            int recordsCount,
            IEnumerable<ScheduleOverviewResource> overviews,
            ScheduleSummaryResource summary)
            : base(request, recordsCount, overviews)
        {
            this.Summary = summary;
        }

        public ScheduleSummaryResource Summary { get; set; }
    }
}