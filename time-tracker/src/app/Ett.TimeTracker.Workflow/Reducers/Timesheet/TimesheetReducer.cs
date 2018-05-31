namespace Ett.TimeTracker.Workflow.Reducers.Timesheet
{
    using Ett.TimeTracker.Workflow.Actions.Timesheet;
    using Ett.TimeTracker.Workflow.States.Timesheet;

    using Redux;

    internal static class TimesheetReducer
    {
        public static TimesheetState Reduce(TimesheetState state, IAction action)
        {
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