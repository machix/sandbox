namespace Ett.TimeTracker.Services.TimeTracker.Mappers
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;

    using Ett.Common.Services.Specifications;
    using Ett.TimeTracker.Domain.Entities;
    using Ett.TimeTracker.Services.TimeTracker.Models.Projects.Overviews;
    using Ett.TimeTracker.Services.TimeTracker.Specifications;

    internal static class ProjectsMapper
    {
        internal static async Task<ProjectOverviews> MapToProjectOverviews(
            ProjectOverviewsRequest request,
            IQueryable<ProjectEntity> projects,
            IQueryable<TimeReportingEntity> timeReportings,
            IQueryable<AfeEntity> afes)
        {
            // Build SQL query
            var query1 = from p in projects.GetByDate(request.Date)
                                     .GetByDatePeriod(request.DateStart, request.DateEnd)
                                     .GetByTimeReportings(request.TimeReportings)
                                     .GetByAfes(request.Afes)
                                     .GetByTypeOfTimeEntry(request.IsManualEntry)
                                     .GetByStatus(request.IsActive)
                        join t in timeReportings on p.TimeReportingId equals t.Id
                        join a in afes on p.AfeId equals a.Id
                        select new
                                   {
                                       ProjectId = p.Id,
                                       TimeReporting = t,
                                       Afe = a,
                                       p.Comments,
                                       p.LogTime,
                                       p.IsManualEntry,
                                       p.ManualEntryStart,
                                       p.ManualEntryEnd
                                    };

            var query = from q1 in query1
                        select new ProjectOverviewQuery
                        {
                            ProjectId = q1.ProjectId,
                            TimeReporting = q1.TimeReporting,
                            Afe = q1.Afe,
                            Comments = q1.Comments,
                            LogTime = q1.LogTime,
                            IsManualEntry = q1.IsManualEntry,
                            ManualEntryStart = q1.ManualEntryStart,
                            ManualEntryEnd = q1.ManualEntryEnd,
                            RecordsCount = query1.Count()
                        };

            var sortBy = new SortFields<ProjectOverviewQuery>
            {
                { "timeReporting", e => e.TimeReporting.Name },
                { "afe", e => e.Afe.Name }
            };
            query = query
                .SortBy(request, sortBy)
                .GetPage(request);

            // Run SQL query
            var entities = await query.ToArrayAsync();

            // Map entities to models
            var overviews = entities.Select(e => new ProjectOverview(
                e.ProjectId,
                e.TimeReporting.Name,
                e.Afe.Name,
                e.Comments,
                e.LogTime,
                e.IsManualEntry,
                e.ManualEntryStart,
                e.ManualEntryEnd));

            return new ProjectOverviews(
                request,
                entities.Any() ? entities.First().RecordsCount : 0,
                overviews);

        }

        private class ProjectOverviewQuery
        {
            public int ProjectId { get; set; }

            public TimeReportingEntity TimeReporting { get; set; }

            public AfeEntity Afe { get; set; }

            public string Comments { get; set; }

            public DateTime? LogTime { get; set; }

            public bool IsManualEntry { get; set; }

            public DateTime? ManualEntryStart { get; set; }

            public DateTime? ManualEntryEnd { get; set; }

            public int RecordsCount { get; set; }
        }
    }
}