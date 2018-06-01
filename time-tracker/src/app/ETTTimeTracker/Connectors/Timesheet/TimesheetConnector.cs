namespace ETTTimeTracker.Connectors.Timesheet
{
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;

    using Ett.TimeTracker.Workflow.ActionCreators.Timesheet;
    using Ett.TimeTracker.Workflow.Common;
    using Ett.TimeTracker.Workflow.Extensions;
    using Ett.TimeTracker.Workflow.Resources.Projects.Overviews;

    using ETTTimeTracker.Models;
    using ETTTimeTracker.ViewModels;

    internal sealed class TimesheetConnector
    {
        private readonly ETTViewModel ett;

        private readonly SettingsViewModel settings;

        public TimesheetConnector(
            ETTViewModel ett, 
            SettingsViewModel settings)
        {
            this.ett = ett;
            this.settings = settings;

            Workflow.Instance.Store.Subscribe(state =>
            {
                if (state.Timesheet?.Projects?.Overviews == null)
                {
                    return;
                }

                this.ett.Tasks = new ObservableCollection<JobTask>(
                    state.Timesheet.Projects.Overviews.Select(p => new JobTask
                    {
                        Name = p.TimeReporting,
                        AFE = p.Afe,
                        Comments = p.Comments,
                        CostCenter = p.Afe
                    }));
            });
        }

        public void UpdateProjects()
        {
            Workflow.Instance.Store.Dispatch(
                ProjectsActionCreator.GetProjects(new ProjectOverviewsRequestResource()));
        }
    }
}