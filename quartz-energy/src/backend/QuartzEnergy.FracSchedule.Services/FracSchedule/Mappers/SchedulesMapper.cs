namespace QuartzEnergy.FracSchedule.Services.FracSchedule.Mappers
{
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using QuartzEnergy.Common.Services.Specifications;
    using QuartzEnergy.FracSchedule.Domain.FracSchedule.Entities;
    using QuartzEnergy.FracSchedule.Services.FracSchedule.Models.Schedules.Enums;
    using QuartzEnergy.FracSchedule.Services.FracSchedule.Models.Schedules.Overviews;
    using QuartzEnergy.FracSchedule.Services.FracSchedule.Specifications;

    internal sealed class SchedulesMapper
    {
        internal static async Task<ScheduleOverviews> MapToScheduleOverviews(
            ScheduleOverviewsRequest request,
            IQueryable<ScheduleEntity> schedules,
            IQueryable<CompanyEntity> companies,
            IQueryable<WellEntity> wells)
        {
            // Build SQL query
            var query1 = from s in schedules.GetByRegions(request.Regions)
                            .GetByOperators(request.Operators)
                            .GetByStartNextDays(request.StartNextDays)
                         join c in companies on s.CompanyId equals c.Id
                         join w in wells on s.WellId equals w.Id
                         select new
                                    {
                                        Schedule = s,
                                        Company = c,
                                        Well = w
                                    };

            var query = from q1 in query1
                        select new ScheduleOverviewQuery
                        {
                            Schedule = q1.Schedule,
                            Company = q1.Company,
                            Well = q1.Well,
                            RecordsCount = query1.Count()
                        };

            var sortBy = new SortFields<ScheduleOverviewQuery>
                             {
                                { "wellName", e => e.Well.Name },
                                { "operator", e => e.Company.Name },
                                { "fracStartDate", e => e.Schedule.FracStartDate }
                             };
            query = query
                .SortBy(request, sortBy)
                .GetPage(request);

            // Run SQL query
            var entities = await query.ToArrayAsync();

            // Map entities to models
            var overviews = entities.Select(e =>
                {
                    var startIn = 0;
                    var status = ScheduleStatus.Operating;
                    return new ScheduleOverview(
                        e.Schedule.Id,
                        e.Well.Name,
                        e.Company.Name,
                        e.Schedule.FracStartDate,
                        e.Schedule.FracEndDate,
                        (e.Schedule.FracEndDate - e.Schedule.FracStartDate).Days,
                        e.Well.Api,
                        e.Well.SurfaceLat,
                        e.Well.SurfaceLong,
                        e.Well.BottomholeLat,
                        e.Well.BottomholeLong,
                        e.Well.Tvd,
                        startIn,
                        status);
                });

            return new ScheduleOverviews(
                request,
                entities.Any() ? entities.First().RecordsCount : 0,
                overviews,
                null);
        }

        private class ScheduleOverviewQuery
        {
            public ScheduleEntity Schedule { get; set; }

            public CompanyEntity Company { get; set; }

            public WellEntity Well { get; set; }

            public int RecordsCount { get; set; }
        }
    }
}