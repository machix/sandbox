namespace Ett.TimeTracker.Workflow.Actions.Timesheet
{
    using Ett.TimeTracker.Workflow.Resources.Projects.Overviews;

    using Redux;
    public sealed class ProjectsLoadedAction : IAction
    {
        public ProjectsLoadedAction(ProjectOverviewsResource projects)
        {
            this.Projects = projects;
        }

        public ProjectOverviewsResource Projects { get; }
    }
}