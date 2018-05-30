namespace Ett.TimeTracker.Services.TimeTracker.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Ett.TimeTracker.Domain.Entities;

    internal static class ProjectSpecifications
    {
        internal static IQueryable<ProjectEntity> GetByTimeReportings(
            this IQueryable<ProjectEntity> query,
            IEnumerable<int> timeReportings)
        {
            if (timeReportings == null)
            {
                return query;
            }

            var enumerable = timeReportings as int[] ?? timeReportings.ToArray();
            if (enumerable.Any())
            {
                query = query.Where(e => enumerable.Contains(e.TimeReportingId));
            }

            return query;
        }

        internal static IQueryable<ProjectEntity> GetByAfes(
            this IQueryable<ProjectEntity> query,
            IEnumerable<int> afes)
        {
            if (afes == null)
            {
                return query;
            }

            var enumerable = afes as int[] ?? afes.ToArray();
            if (enumerable.Any())
            {
                query = query.Where(e => enumerable.Contains(e.AfeId));
            }

            return query;
        }

        internal static IQueryable<ProjectEntity> GetByTypeOfTimeEntry(
            this IQueryable<ProjectEntity> query,
            bool? isManualEntry)
        {
            if (!isManualEntry.HasValue)
            {
                return query;
            }

            return query.Where(e => e.IsManualEntry == isManualEntry);
        }

        internal static IQueryable<ProjectEntity> GetByStatus(
            this IQueryable<ProjectEntity> query,
            bool? isActive)
        {
            if (!isActive.HasValue)
            {
                return query;
            }

            return query;
        }

        internal static IQueryable<ProjectEntity> GetByDate(
            this IQueryable<ProjectEntity> query,
            DateTime? date)
        {
            if (!date.HasValue)
            {
                return query;
            }

            return query.Where(e => e.Date == date);
        }

        internal static IQueryable<ProjectEntity> GetByDatePeriod(
            this IQueryable<ProjectEntity> query,
            DateTime? start,
            DateTime? end)
        {
            if (start.HasValue)
            {
                query = query.Where(e => e.Date >= start);
            }

            if (end.HasValue)
            {
                query = query.Where(e => e.Date <= end);
            }

            return query;
        }
    }
}