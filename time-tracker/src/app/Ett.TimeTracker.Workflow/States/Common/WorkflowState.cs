namespace Ett.TimeTracker.Workflow.States.Common
{
    using Ett.TimeTracker.Workflow.States.Dashboard;
    using Ett.TimeTracker.Workflow.States.Reports;
    using Ett.TimeTracker.Workflow.States.Settings;
    using Ett.TimeTracker.Workflow.States.Timesheet;

    public sealed class WorkflowState
    {
        public LoadingState Loading { get; set; }

        public DashboardState Dashboard { get; set; }

        public ReportsState Reports { get; set; }

        public SettingsState Settings { get; set; }

        public TimesheetState Timesheet { get; set; }
    }
}