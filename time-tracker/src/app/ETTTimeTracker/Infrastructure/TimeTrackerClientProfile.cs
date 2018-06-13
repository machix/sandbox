namespace ETTTimeTracker.Infrastructure
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;

    using Ett.Common.Mapping.Extensions;
    using Ett.TimeTracker.Workflow.Resources.Projects.Overviews;

    using ETTTimeTracker.Models;
    using ETTTimeTracker.ViewModels;

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

            this.CreateMap<IEnumerable<ProjectOverviewResource>, IEnumerable<JobTask>>()
                .ConstructUsing(
                    r =>
                        {
                            if (r == null)
                            {
                                return new JobTask[0];
                            }

                            return r.Select(Mapper.Map<JobTask>);
                        });

            this.CreateMap<ProjectOverviewsRequestResource, ETTViewModel>()
                .IgnoreAllUnmapped()
                .ReverseMap()
                .IgnoreAllUnmapped();
        }
    }
}