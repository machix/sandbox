namespace Ett.TimeTracker.Workflow.States.Timesheet
{
    using Ett.TimeTracker.Workflow.Resources.Projects.Overviews;

    public sealed class TimesheetState
    {
        public ProjectOverviewsRequestResource Request { get; set; } = new ProjectOverviewsRequestResource();

        public ProjectOverviewsResource Projects { get; set; } = new ProjectOverviewsResource();
    }
}