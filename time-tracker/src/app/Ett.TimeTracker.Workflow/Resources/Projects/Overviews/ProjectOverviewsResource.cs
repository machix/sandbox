namespace Ett.TimeTracker.Workflow.Resources.Projects.Overviews
{
    using System.Collections.Generic;

    using Ett.Common.Web.Resources.Overviews;

    public sealed class ProjectOverviewsResource : OverviewsResource<ProjectOverviewsRequestResource, ProjectOverviewResource>
    {
        public ProjectOverviewsResource()
        {            
        }

        public ProjectOverviewsResource(
            ProjectOverviewsRequestResource request,
            int recordsCount,
            IEnumerable<ProjectOverviewResource> overviews)
            : base(request, recordsCount, overviews)
        {
        }
    }
}