namespace Ett.TimeTracker.Services.TimeTracker.Services.Projects
{
    using Ett.Common.Services.Services.Entity.Interfaces;
    using Ett.TimeTracker.Services.TimeTracker.Models.Projects.Entity;
    using Ett.TimeTracker.Services.TimeTracker.Models.Projects.Overviews;

    public interface IProjectsService
        : IIntIdEntityService<Project, ProjectOverviewsRequest, ProjectOverviews>
    {
    }
}