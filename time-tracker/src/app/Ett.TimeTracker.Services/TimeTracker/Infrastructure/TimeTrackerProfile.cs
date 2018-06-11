namespace Ett.TimeTracker.Services.TimeTracker.Infrastructure
{
    using AutoMapper;

    using Ett.TimeTracker.Domain.Entities;
    using Ett.TimeTracker.Services.TimeTracker.Models.Projects.Entity;

    public class TimeTrackerProfile : Profile
    {
        public TimeTrackerProfile()
        {
            // Entities
            this.CreateMap<ProjectEntity, Project>()
                .ConstructUsing(
                    e => new Project(
                        e.Id,
                        e.Date,
                        e.Comments,
                        e.TimeReportingId,
                        e.AfeId,
                        e.LogTime,
                        e.IsManualEntry,
                        e.ManualEntryStart,
                        e.ManualEntryEnd,
                        e.IsArchived));
        }
    }
}