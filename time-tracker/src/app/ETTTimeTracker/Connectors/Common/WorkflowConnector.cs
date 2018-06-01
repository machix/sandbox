namespace ETTTimeTracker.Connectors.Common
{
    using ETTTimeTracker.Connectors.Dashboard;
    using ETTTimeTracker.Connectors.Reports;
    using ETTTimeTracker.Connectors.Settings;
    using ETTTimeTracker.Connectors.Timesheet;
    using ETTTimeTracker.ViewModels;

    internal sealed class WorkflowConnector
    {
        public DashboardConnector Dashboard { get; }

        public ReportsConnector Reports { get; }

        public SettingsConnector Settings { get; }

        public TimesheetConnector Timesheet { get; }

        public WorkflowConnector(
            ETTViewModel ett,
            SettingsViewModel settings)
        {
            this.Dashboard = new DashboardConnector(ett, settings);
            this.Reports = new ReportsConnector(ett, settings);
            this.Settings = new SettingsConnector(ett, settings);
            this.Timesheet = new TimesheetConnector(ett, settings);
        }
    }
}