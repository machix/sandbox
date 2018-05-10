namespace QuartzEnergy.FracSchedule.Services.FracSchedule.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using QuartzEnergy.FracSchedule.Domain.FracSchedule.Entities;

    internal static class ScheduleSpecifications
    {
        internal static IQueryable<ScheduleEntity> GetByRegions(
            this IQueryable<ScheduleEntity> query,
            IEnumerable<int> regions)
        {
            if (regions == null)
            {
                return query;
            }

            var enumerable = regions as int[] ?? regions.ToArray();
            if (enumerable.Any())
            {
                query = query.Where(e => enumerable.Contains(e.Well.RegionId));
            }

            return query;
        }

        internal static IQueryable<ScheduleEntity> GetByOperators(
            this IQueryable<ScheduleEntity> query,
            IEnumerable<int> operators)
        {
            if (operators == null)
            {
                return query;
            }

            var enumerable = operators as int[] ?? operators.ToArray();
            if (enumerable.Any())
            {
                query = query.Where(e => enumerable.Contains(e.CompanyId));
            }

            return query;
        }

        internal static IQueryable<ScheduleEntity> GetByStartNextDays(
            this IQueryable<ScheduleEntity> query,
            int? days)
        {
            if (!days.HasValue)
            {
                return query;
            }

            var start = DateTime.Today.ToUniversalTime().AddDays(days.Value);
            query = query.Where(e => e.FracStartDate <= start);

            return query;
        }
    }
}