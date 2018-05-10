namespace QuartzEnergy.FracSchedule.Web.FracSchedule.Infrastructure
{
    using System.Collections.Generic;

    using AutoMapper;

    using QuartzEnergy.Common.Mapping.Infrastructure;
    using QuartzEnergy.FracSchedule.Services.FracSchedule.Models.Schedules.Overviews;
    using QuartzEnergy.FracSchedule.Web.FracSchedule.Resources.Schedules.Overviews;
    using QuartzEnergy.FracSchedule.Web.FracSchedule.Resources.Schedules.Entity;

    public sealed class FracScheduleResourcesProfile : ResourcesProfile
    {
        public FracScheduleResourcesProfile()
        {
            // Requests
            this.CreateMap<ScheduleOverviewsRequestResource, ScheduleOverviewsRequest>()
                .ConstructUsing(
                    r => new ScheduleOverviewsRequest(
                        r.Regions,
                        r.Operators,
                        r.StartNextDays,
                        r.SortBy,
                        r.Desc,
                        r.PageSize,
                        r.PageNumber))
                .ReverseMap()
                .ConstructUsing(
                    m => new ScheduleOverviewsRequestResource(
                        m.Regions,
                        m.Operators,
                        m.StartNextDays,
                        m.SortBy,
                        m.Desc,
                        m.PageSize,
                        m.PageNumber));

            // Overviews
            this.CreateMap<ScheduleOverview, ScheduleOverviewResource>()
                .ConstructUsing(
                    m => new ScheduleOverviewResource(
                        m.ScheduleId, 
                        m.WellName, 
                        m.Operator, 
                        m.FracStartDate, 
                        m.FracEndDate, 
                        m.Duration, 
                        m.Api,
                        m.SurfaceLat,
                        m.SurfaceLong,
                        m.BottomholeLat,
                        m.BottomholeLong,
                        m.Tvd,
                        m.StartIn,
                        m.Status));

            this.CreateMap<ScheduleSummary, ScheduleSummaryResource>()
                .ConstructUsing(
                    m => new ScheduleSummaryResource(
                        m.OperatingCount,
                        m.Next7DaysCount,
                        m.Next830DaysCount,
                        m.Next3160DaysCount,
                        m.Next60PlusDaysCount));

            this.CreateMap<ScheduleOverviews, ScheduleOverviewsResource>()
                .ConstructUsing(
                    m => new ScheduleOverviewsResource(
                        Mapper.Map<ScheduleOverviewsRequestResource>(m.Request),
                        m.RecordsCount,
                        Mapper.Map<IEnumerable<ScheduleOverviewResource>>(m.Overviews),
                        Mapper.Map<ScheduleSummaryResource>(m.Summary)));

            // CRUD
            this.CreateMap<ScheduleResource, ScheduleResource>()
                .ConstructUsing(
                    r => new ScheduleResource(
                        r.Id,
                        r.WellId,
                        r.CompanyId,
                        r.FracStartDate,
                        r.FracEndDate,
                        r.CreatedDate))
                .ReverseMap()
                .ConstructUsing(
                    m => new ScheduleResource(
                        m.Id,
                        m.WellId,
                        m.CompanyId,
                        m.FracStartDate,
                        m.FracEndDate,
                        m.CreatedDate));
        }
    }
}
