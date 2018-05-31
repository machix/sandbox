namespace Ett.TimeTracker.Workflow.Reducers.Common
{
    using Ett.TimeTracker.Workflow.Reducers.Dashboard;
    using Ett.TimeTracker.Workflow.Reducers.Reports;
    using Ett.TimeTracker.Workflow.Reducers.Settings;
    using Ett.TimeTracker.Workflow.Reducers.Timesheet;
    using Ett.TimeTracker.Workflow.States.Common;

    using Redux;

    internal static class WorkflowReducer
    {
        public static WorkflowState Reduce(WorkflowState state, IAction action)
        {
            return new WorkflowState
            {
                Loading = LoadingReducer.Reduce(state.Loading, action),
                Dashboard = DashboardReducer.Reduce(state.Dashboard, action),
                Reports = ReportsReducer.Reduce(state.Reports, action),
                Settings = SettingsReducer.Reduce(state.Settings, action),
                Timesheet = TimesheetReducer.Reduce(state.Timesheet, action)
            };
        }
    }
}