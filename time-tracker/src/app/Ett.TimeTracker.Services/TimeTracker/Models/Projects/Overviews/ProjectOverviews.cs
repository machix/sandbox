namespace Ett.TimeTracker.Services.TimeTracker.Models.Projects.Overviews
{
    using System.Collections.Generic;

    using Ett.Common.Services.Models.Overviews;

    public sealed class ProjectOverviews : OverviewsModel<ProjectOverviewsRequest, ProjectOverview>
    {
        public ProjectOverviews(
            ProjectOverviewsRequest request,
            int recordsCount,
            IEnumerable<ProjectOverview> overviews)
            : base(request, recordsCount, overviews)
        {
        }
    }
}