namespace Ett.TimeTracker.Workflow.Actions.Timesheet
{
    using Ett.TimeTracker.Workflow.Resources.Projects.Overviews;

    using Redux;
    public sealed class ApplyProjectsRequestAction : IAction
    {
        public ApplyProjectsRequestAction(ProjectOverviewsRequestResource request)
        {
            this.Request = request;
        }

        public ProjectOverviewsRequestResource Request { get; }
    }
}