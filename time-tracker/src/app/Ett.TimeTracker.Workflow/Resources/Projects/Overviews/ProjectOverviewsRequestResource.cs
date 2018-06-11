namespace Ett.TimeTracker.Workflow.Resources.Projects.Overviews
{
    using System;
    using System.Collections.Generic;

    using Ett.Common.DataAnnotations.Attributes.Data;
    using Ett.Common.Web.Resources.Overviews;

    public sealed class ProjectOverviewsRequestResource : OverviewsRequestResource
    {
        public ProjectOverviewsRequestResource()
        {            
        }

        public ProjectOverviewsRequestResource(
            IEnumerable<int> timeReportings,
            IEnumerable<int> afes,
            bool? isManualEntry,
            bool? isArchived,
            DateTime? date,
            DateTime? dateStart,
            DateTime? dateEnd,
            string sortBy,
            bool desc,
            int? pageSize,
            int? pageNumber)
            : base(sortBy, desc, pageSize, pageNumber)
        {
            this.TimeReportings = timeReportings;
            this.Afes = afes;
            this.IsManualEntry = isManualEntry;
            this.IsArchived = isArchived;
            this.Date = date;
            this.DateStart = dateStart;
            this.DateEnd = dateEnd;
        }

        [IntIds]
        public IEnumerable<int> TimeReportings { get; set; }

        [IntIds]
        public IEnumerable<int> Afes { get; set; }

        public bool? IsManualEntry { get; set; }

        public bool? IsArchived { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateEnd { get; set; }
    }
}