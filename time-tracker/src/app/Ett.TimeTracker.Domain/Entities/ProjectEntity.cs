namespace Ett.TimeTracker.Domain.Entities
{
    using System;

    using Ett.Common.Domain.Entities;

    public class ProjectEntity : IntIdEntity
    {
        public DateTime Date { get; set; }

        public string Comments { get; set; }

        public int TimeReportingId { get; set; }

        public int AfeId { get; set; }

        public DateTime? LogTime { get; set; }

        public bool IsManualEntry { get; set; }

        public DateTime? ManualEntryStart { get; set; }

        public DateTime? ManualEntryEnd { get; set; }

        public virtual TimeReportingEntity TimeReporting { get; set; }

        public virtual AfeEntity Afe { get; set; }
    }
}