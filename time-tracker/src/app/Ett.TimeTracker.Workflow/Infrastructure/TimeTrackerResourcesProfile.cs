namespace Ett.TimeTracker.Workflow.Infrastructure
{
    using System.Collections.Generic;

    using AutoMapper;

    using Ett.Common.Mapping.Infrastructure;
    using Ett.TimeTracker.Services.TimeTracker.Models.Projects.Entity;
    using Ett.TimeTracker.Services.TimeTracker.Models.Projects.Overviews;
    using Ett.TimeTracker.Workflow.Resources.Projects.Entity;
    using Ett.TimeTracker.Workflow.Resources.Projects.Overviews;

    public sealed class TimeTrackerResourcesProfile : ResourcesProfile
    {
        public TimeTrackerResourcesProfile()
        {
            // Requests
            this.CreateMap<ProjectOverviewsRequestResource, ProjectOverviewsRequest>()
                .ConstructUsing(
                    r => new ProjectOverviewsRequest(
                        r.TimeReportings,
                        r.Afes,
                        r.IsManualEntry,
                        r.IsActive,
                        r.Date,
                        r.DateStart,
                        r.DateEnd,
                        r.SortBy,
                        r.Desc,
                        r.PageSize,
                        r.PageNumber));

            // Overviews
            this.CreateMap<ProjectOverview, ProjectOverviewResource>()
                .ConstructUsing(
                    m => new ProjectOverviewResource(
                        m.ProjectId,
                        m.TimeReporting,
                        m.Afe,
                        m.Comments,
                        m.LogTime,
                        m.IsManualEntry,
                        m.ManualEntryStart,
                        m.ManualEntryEnd));

            this.CreateMap<ProjectOverviews, ProjectOverviewsResource>()
                .ConstructUsing(
                    m => new ProjectOverviewsResource(
                        Mapper.Map<ProjectOverviewsRequestResource>(m.Request),
                        m.RecordsCount,
                        Mapper.Map<IEnumerable<ProjectOverviewResource>>(m.Overviews)));

            // CRUD
            this.CreateMap<ProjectResource, Project>()
                .ConstructUsing(
                    r => new Project(
                        r.Id,
                        r.Date,
                        r.Comments,
                        r.TimeReportingId,
                        r.AfeId,
                        r.LogTime,
                        r.IsManualEntry,
                        r.ManualEntryStart,
                        r.ManualEntryEnd));
        }
    }
}