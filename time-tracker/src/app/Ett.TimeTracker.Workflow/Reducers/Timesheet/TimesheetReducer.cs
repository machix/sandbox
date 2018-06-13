namespace Ett.TimeTracker.Workflow.Reducers.Timesheet
{
    using Ett.TimeTracker.Workflow.Actions.Timesheet;
    using Ett.TimeTracker.Workflow.Resources.Projects.Overviews;
    using Ett.TimeTracker.Workflow.States.Timesheet;

    using Redux;

    internal static class TimesheetReducer
    {
        public static TimesheetState Reduce(TimesheetState state, IAction action)
        {
            if (action is ApplyProjectsRequestAction)
            {
                return new TimesheetState
                {
                    Request = ((ApplyProjectsRequestAction)action).Request
                };
            }

            if (action is ClearProjectsRequestAction)
            {
                return new TimesheetState
                {
                    Request = new ProjectOverviewsRequestResource()
                };
            }

            if (action is ProjectsLoadedAction)
            {
                return new TimesheetState
                {
                    Projects = ((ProjectsLoadedAction)action).Projects
                };
            }

            return state;
        }
    }
}