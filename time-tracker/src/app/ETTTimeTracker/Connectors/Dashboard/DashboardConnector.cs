namespace ETTTimeTracker.Connectors.Dashboard
{
    using AutoMapper;

    using Ett.TimeTracker.Workflow.Common;

    using ETTTimeTracker.Connectors.Common;
    using ETTTimeTracker.ViewModels;

    internal sealed class DashboardConnector : TimeTrackerConnector
    {
        public DashboardConnector(
            ETTViewModel ettVm, 
            SettingsViewModel settingsVm, 
            Workflow workflow, 
            IMapper mapper)
            : base(ettVm, settingsVm, workflow, mapper)
        {
        }
    }
}