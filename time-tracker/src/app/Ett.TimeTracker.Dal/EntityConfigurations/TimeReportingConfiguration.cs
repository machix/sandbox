namespace Ett.TimeTracker.Dal.EntityConfigurations
{
    using System.Data.Entity.ModelConfiguration;

    using Ett.TimeTracker.Domain.Entities;

    internal sealed class TimeReportingConfiguration : EntityTypeConfiguration<TimeReportingEntity>
    {
        internal TimeReportingConfiguration()
        {
            this.HasKey(e => e.Id);

            this.Property(e => e.Name).IsRequired().HasMaxLength(50);

            this.ToTable("TimeReportings");
        }
    }
}