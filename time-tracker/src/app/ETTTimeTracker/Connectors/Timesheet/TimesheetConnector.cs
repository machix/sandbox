namespace ETTTimeTracker.Connectors.Timesheet
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Reactive.Linq;

    using AutoMapper;

    using Ett.TimeTracker.Workflow.ActionCreators.Timesheet;
    using Ett.TimeTracker.Workflow.Common;
    using Ett.TimeTracker.Workflow.Resources.Projects.Overviews;

    using ETTTimeTracker.Connectors.Common;
    using ETTTimeTracker.Models;
    using ETTTimeTracker.ViewModels;

    internal sealed class TimesheetConnector : TimeTrackerConnector
    {
        public TimesheetConnector(
            ETTViewModel ettVm, 
            SettingsViewModel settingsVm,
            Workflow workflow,
            IMapper mapper)
            : base(ettVm, settingsVm, workflow, mapper)
        {
            this.Workflow.Store
            .DistinctUntilChanged(state => new { state.Timesheet.Request }) 
            .Subscribe(state =>
            {
                var tasks = this.Mapper.Map<IEnumerable<JobTask>>(state.Timesheet.Projects.Overviews);
                this.EttVm.Tasks = new ObservableCollection<JobTask>(tasks);
            });
        }

        public void ApplyRequest()
        {
            var request = this.Mapper.Map<ProjectOverviewsRequestResource>(this.EttVm);
            this.Workflow.Store.Dispatch(ProjectsActionCreator.ApplyProjectsRequest(request));
        }

        public void ClearRequest()
        {
            this.Workflow.Store.Dispatch(ProjectsActionCreator.ClearProjectsRequest());
        }
    }
}