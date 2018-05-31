namespace Ett.TimeTracker.Workflow.States.Timesheet
{
    using Ett.TimeTracker.Workflow.Resources.Projects.Overviews;

    public sealed class TimesheetState
    {
        public ProjectOverviewsResource Projects { get; set; }
    }
}