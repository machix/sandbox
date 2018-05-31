namespace Ett.TimeTracker.Workflow.Resources.Projects.Overviews
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Ett.Common.DataAnnotations.Attributes.Data;

    public sealed class ProjectOverviewResource
    {
        public ProjectOverviewResource()
        {
            
        }

        public ProjectOverviewResource(
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
        public int ProjectId { get; set; }

        [Required]
        [MaxLength(50)]
        public string TimeReporting { get; set; }

        [Required]
        [MaxLength(20)]
        public string Afe { get; set; }

        public string Comments { get; set; }

        public DateTime? LogTime { get; set; }

        public bool IsManualEntry { get; set; }

        public DateTime? ManualEntryStart { get; set; }

        public DateTime? ManualEntryEnd { get; set; }
    }
}