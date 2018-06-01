namespace Ett.TimeTracker.Workflow.ActionCreators.Timesheet
{
    using AutoMapper;

    using Ett.Common.IoC.Ninject.IoC;
    using Ett.TimeTracker.Services.TimeTracker.Models.Projects.Overviews;
    using Ett.TimeTracker.Services.TimeTracker.Services.Projects;
    using Ett.TimeTracker.Workflow.Actions.Common;
    using Ett.TimeTracker.Workflow.Actions.Timesheet;
    using Ett.TimeTracker.Workflow.Extensions;
    using Ett.TimeTracker.Workflow.Resources.Projects.Overviews;
    using Ett.TimeTracker.Workflow.States.Common;

    public static class ProjectsActionCreator
    {
        public static AsyncActionsCreator<WorkflowState> GetProjects(
            ProjectOverviewsRequestResource requestResource)
        {
            return async (dispatch, getState) =>
            {
                dispatch(new LoadingStartAction());

                var projectsService = ManualDependencyResolver.Get<IProjectsService>();
                var request = Mapper.Map<ProjectOverviewsRequest>(requestResource);
                var overviews = await projectsService.GetOverviews(request);
                var overviewsResource = Mapper.Map<ProjectOverviewsResource>(overviews);
                dispatch(new ProjectsLoadedAction(overviewsResource));

                dispatch(new LoadingEndAction());
            };
        }
    }
}