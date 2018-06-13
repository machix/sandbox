namespace ETTTimeTracker.Connectors.Timesheet
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Reactive.Linq;

    using AutoMapper;

    using Ett.TimeTracker.Workflow.ActionCreators.Timesheet;
    using Ett.TimeTracker.Workflow.Actions.Timesheet;
    using Ett.TimeTracker.Workflow.Common;
    using Ett.TimeTracker.Workflow.Extensions;
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
                if (state.Timesheet.Projects.Overviews == null)
                {
                    return;
                }

                var tasks = this.Mapper.Map<IEnumerable<JobTask>>(state.Timesheet.Projects.Overviews);
                this.EttVm.Tasks = new ObservableCollection<JobTask>(tasks);
            });
        }

        public void ApplyRequest()
        {
            var request = this.Mapper.Map<ProjectOverviewsRequestResource>(this.EttVm);
            this.Workflow.Store.Dispatch(new ApplyProjectsRequestAction(request));
            this.Workflow.Store.Dispatch(ProjectsActionCreator.GetProjects(request));
        }

        public void ClearRequest()
        {
            this.Workflow.Store.Dispatch(new ClearProjectsRequestAction());
            var request = new ProjectOverviewsRequestResource();
            this.Workflow.Store.Dispatch(ProjectsActionCreator.GetProjects(request));
        }
    }
}