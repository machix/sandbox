namespace Ett.TimeTracker.Workflow.ActionCreators.Timesheet
{
    using System.Threading.Tasks;

    using AutoMapper;

    using Ett.Common.IoC.Ninject.IoC;
    using Ett.TimeTracker.Services.TimeTracker.Models.Projects.Overviews;
    using Ett.TimeTracker.Services.TimeTracker.Services.Projects;
    using Ett.TimeTracker.Workflow.Actions.Common;
    using Ett.TimeTracker.Workflow.Actions.Timesheet;
    using Ett.TimeTracker.Workflow.Resources.Projects.Overviews;
    using Ett.TimeTracker.Workflow.States.Common;

    using Redux;

    using Taiste.Redux;

    public static class ProjectsActionCreator
    {
        public static IAction ApplyProjectsRequest(
            ProjectOverviewsRequestResource request)
        {
            return new ThunkAction<WorkflowState>((dispatch, getState) => {
                dispatch(new ApplyProjectsRequestAction(request));
                dispatch(GetProjects(request));
            });
        }

        public static IAction ClearProjectsRequest()
        {
            return new ThunkAction<WorkflowState>((dispatch, getState) => {
                dispatch(new ClearProjectsRequestAction());
                dispatch(GetProjects(new ProjectOverviewsRequestResource()));
            });     
        }

        public static IAction GetProjects(
            ProjectOverviewsRequestResource requestResource)
        {
            return new ThunkAction<WorkflowState>((dispatch, getState) => {
                Task.Factory.StartNew(
                    async () => {
                    dispatch(new ProcessStartAction());

                    var projectsService = ManualDependencyResolver.Get<IProjectsService>();
                    var request = Mapper.Map<ProjectOverviewsRequest>(requestResource);
                    var overviews = await projectsService.GetOverviews(request);
                    var overviewsResource = Mapper.Map<ProjectOverviewsResource>(overviews);
                    dispatch(new ProjectsLoadedAction(overviewsResource));

                    dispatch(new ProcessEndAction());
                });
            });
        }
    }
}