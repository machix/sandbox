namespace Ett.TimeTracker.Workflow.States.Common
{
    using Ett.TimeTracker.Workflow.States.Dashboard;
    using Ett.TimeTracker.Workflow.States.Reports;
    using Ett.TimeTracker.Workflow.States.Settings;
    using Ett.TimeTracker.Workflow.States.Timesheet;

    public sealed class WorkflowState
    {
        public LoadingState Loading { get; set; } = new LoadingState();

        public DashboardState Dashboard { get; set; } = new DashboardState();

        public ReportsState Reports { get; set; } = new ReportsState();

        public SettingsState Settings { get; set; } = new SettingsState();

        public TimesheetState Timesheet { get; set; } = new TimesheetState();
    }
}