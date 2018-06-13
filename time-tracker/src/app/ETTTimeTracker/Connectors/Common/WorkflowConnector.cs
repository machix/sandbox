namespace ETTTimeTracker.Connectors.Common
{
    using AutoMapper;

    using Ett.TimeTracker.Workflow.Common;

    using ETTTimeTracker.Connectors.Dashboard;
    using ETTTimeTracker.Connectors.Reports;
    using ETTTimeTracker.Connectors.Settings;
    using ETTTimeTracker.Connectors.Timesheet;
    using ETTTimeTracker.ViewModels;

    internal sealed class WorkflowConnector : TimeTrackerConnector
    {
        public DashboardConnector Dashboard { get; }

        public ReportsConnector Reports { get; }

        public SettingsConnector Settings { get; }

        public TimesheetConnector Timesheet { get; }

        public WorkflowConnector(
            ETTViewModel ettVm,
            SettingsViewModel settingsVm,
            Workflow workflow,
            IMapper mapper)
            : base(ettVm, settingsVm, workflow, mapper)
        {
            this.Dashboard = new DashboardConnector(ettVm, settingsVm, workflow, mapper);
            this.Reports = new ReportsConnector(ettVm, settingsVm, workflow, mapper);
            this.Settings = new SettingsConnector(ettVm, settingsVm, workflow, mapper);
            this.Timesheet = new TimesheetConnector(ettVm, settingsVm, workflow, mapper);
        }
    }
}