namespace ETTTimeTracker.Connectors.Settings
{
    using AutoMapper;

    using Ett.TimeTracker.Workflow.Common;

    using ETTTimeTracker.Connectors.Common;
    using ETTTimeTracker.ViewModels;

    internal sealed class SettingsConnector : TimeTrackerConnector
    {
        public SettingsConnector(
            ETTViewModel ettVm, 
            SettingsViewModel settingsVm, 
            Workflow workflow, 
            IMapper mapper)
            : base(ettVm, settingsVm, workflow, mapper)
        {
        }
    }
}