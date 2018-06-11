namespace Ett.TimeTracker.Workflow.Resources.Projects.Entity
{
    using System;

    using Ett.Common.DataAnnotations.Attributes.Data;
    using Ett.Common.Web.Resources.Business;

    public sealed class ProjectResource : IntIdResource
    {
        public ProjectResource(
            int id,
            DateTime date,
            string comments,
            int timeReportingId,
            int afeId,
            DateTime? logTime,
            bool isManualEntry,
            DateTime? manualEntryStart,
            DateTime? manualEntryEnd,
            bool isArchived)
            : base(id)
        {
            this.Date = date;
            this.Comments = comments;
            this.TimeReportingId = timeReportingId;
            this.AfeId = afeId;
            this.LogTime = logTime;
            this.IsManualEntry = isManualEntry;
            this.ManualEntryStart = manualEntryStart;
            this.ManualEntryEnd = manualEntryEnd;
            this.IsArchived = isArchived;
        }

        public DateTime Date { get; set; }

        public string Comments { get; set; }

        [IntId]
        public int TimeReportingId { get; set; }

        [IntId]
        public int AfeId { get; set; }

        public DateTime? LogTime { get; set; }

        public bool IsManualEntry { get; set; }

        public DateTime? ManualEntryStart { get; set; }

        public DateTime? ManualEntryEnd { get; set; }

        public bool IsArchived { get; set; }
    }
}