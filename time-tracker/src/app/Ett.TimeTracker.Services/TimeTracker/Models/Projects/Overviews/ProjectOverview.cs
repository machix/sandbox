namespace Ett.TimeTracker.Services.TimeTracker.Models.Projects.Overviews
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Ett.Common.DataAnnotations.Attributes.Data;

    public sealed class ProjectOverview
    {
        public ProjectOverview(
            int projectId, 
            string timeReporting, 
            string afe, 
            string comments, 
            DateTime? logTime, 
            bool isManualEntry, 
            DateTime? manualEntryStart, 
            DateTime? manualEntryEnd)
        {
            this.ProjectId = projectId;
            this.TimeReporting = timeReporting;
            this.Afe = afe;
            this.Comments = comments;
            this.LogTime = logTime;
            this.IsManualEntry = isManualEntry;
            this.ManualEntryStart = manualEntryStart;
            this.ManualEntryEnd = manualEntryEnd;
        }

        [IntId]
        public int ProjectId { get; }

        [Required]
        [MaxLength(50)]
        public string TimeReporting { get; }

        [Required]
        [MaxLength(20)]
        public string Afe { get; }

        public string Comments { get; }

        public DateTime? LogTime { get; }

        public bool IsManualEntry { get; }

        public DateTime? ManualEntryStart { get; }

        public DateTime? ManualEntryEnd { get; }
    }
}