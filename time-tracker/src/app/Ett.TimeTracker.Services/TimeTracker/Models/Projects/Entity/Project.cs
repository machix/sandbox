namespace Ett.TimeTracker.Services.TimeTracker.Models.Projects.Entity
{
    using System;

    using Ett.Common.DataAnnotations.Attributes.Data;
    using Ett.Common.Services.Models.Business;

    public sealed class Project : IntIdBusinessModel
    {
        public Project(
            int id, 
            DateTime 
            date, 
            string 
            comments, 
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

        public DateTime Date { get; }

        public string Comments { get; }

        [IntId]
        public int TimeReportingId { get; }

        [IntId]
        public int AfeId { get; }

        public DateTime? LogTime { get; }

        public bool IsManualEntry { get; }

        public DateTime? ManualEntryStart { get; }

        public DateTime? ManualEntryEnd { get; }

        public bool IsArchived { get; }
    }
}