namespace Ett.TimeTracker.Services.TimeTracker.Models.Projects.Overviews
{
    using System;
    using System.Collections.Generic;

    using Ett.Common.DataAnnotations.Attributes.Data;
    using Ett.Common.Services.Models.Overviews;

    public sealed class ProjectOverviewsRequest : OverviewsRequestModel
    {
        public ProjectOverviewsRequest(
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
        public IEnumerable<int> TimeReportings { get; }

        [IntIds]
        public IEnumerable<int> Afes { get; }

        public bool? IsManualEntry { get; }

        public bool? IsArchived { get; }

        public DateTime? Date { get; }

        public DateTime? DateStart { get; }

        public DateTime? DateEnd { get; }
    }
}