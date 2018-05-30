﻿namespace Ett.TimeTracker.Services.TimeTracker.Services.Projects.Concrete
{
    using System.Threading.Tasks;

    using AutoMapper;

    using Ett.Common.Dal.Infrastructure;
    using Ett.Common.Services.Services.Entity;
    using Ett.TimeTracker.Domain.Entities;
    using Ett.TimeTracker.Services.TimeTracker.Models.Projects.Entity;
    using Ett.TimeTracker.Services.TimeTracker.Models.Projects.Overviews;

    public class ProjectsService
        : IntIdEntityService<ProjectEntity, Project, ProjectOverviewsRequest, ProjectOverviews>, IProjectsService
    {
        public ProjectsService(IUnitOfWorkFactory unitOfWorkFactory, IMapper mapper)
            : base(unitOfWorkFactory, mapper)
        {
        }

        protected override Task<ProjectOverviews> DoGetOverviews(IUnitOfWork uow, ProjectOverviewsRequest request)
        {
            var projectsRep = uow.GetRepository<ProjectEntity>();

            throw new System.NotImplementedException();
        }
    }
}