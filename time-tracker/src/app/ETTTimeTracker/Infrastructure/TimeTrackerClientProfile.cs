namespace ETTTimeTracker.Infrastructure
{
    using AutoMapper;

    using Ett.Common.Mapping.Extensions;
    using Ett.TimeTracker.Workflow.Resources.Projects.Overviews;

    using ETTTimeTracker.Models;

    public class TimeTrackerClientProfile : Profile
    {
        public TimeTrackerClientProfile()
        {
            this.CreateMap<ProjectOverviewResource, JobTask>()
                .ConstructUsing(r => new JobTask
                {
                    Name = r.TimeReporting,
                    AFE = r.Afe,
                    Comments = r.Comments,
                    CostCenter = r.Afe
                })
                .IgnoreAllUnmapped();
        }
    }
}