namespace ETTTimeTracker.Connectors.Common
{
    using AutoMapper;

    using Ett.TimeTracker.Workflow.Common;

    using ETTTimeTracker.ViewModels;

    internal abstract class TimeTrackerConnector
    {
        protected readonly ETTViewModel EttVm;

        protected readonly SettingsViewModel SettingsVm;

        protected readonly Workflow Workflow;

        protected readonly IMapper Mapper;

        protected TimeTrackerConnector(
            ETTViewModel ettVm, 
            SettingsViewModel settingsVm, 
            Workflow workflow, 
            IMapper mapper)
        {
            this.EttVm = ettVm;
            this.SettingsVm = settingsVm;
            this.Workflow = workflow;
            this.Mapper = mapper;
        }
    }
}