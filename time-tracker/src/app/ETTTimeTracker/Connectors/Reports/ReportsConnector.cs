namespace ETTTimeTracker.Connectors.Reports
{
    using AutoMapper;

    using Ett.TimeTracker.Workflow.Common;

    using ETTTimeTracker.Connectors.Common;
    using ETTTimeTracker.ViewModels;

    internal sealed class ReportsConnector : TimeTrackerConnector
    {
        public ReportsConnector(
            ETTViewModel ettVm, 
            SettingsViewModel settingsVm, 
            Workflow workflow, 
            IMapper mapper)
            : base(ettVm, settingsVm, workflow, mapper)
        {
        }
    }
}