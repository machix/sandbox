namespace Ett.TimeTracker.Dal.EntityConfigurations
{
    using System.Data.Entity.ModelConfiguration;

    using Ett.TimeTracker.Domain.Entities;

    internal sealed class ProjectConfiguration : EntityTypeConfiguration<ProjectEntity>
    {
        internal ProjectConfiguration()
        {
            this.HasKey(e => e.Id);

            this.Property(e => e.Date).IsRequired();
            this.Property(e => e.Comments).IsOptional();
            this.Property(e => e.TimeReportingId).IsRequired();
            this.Property(e => e.AfeId).IsRequired();
            this.Property(e => e.LogTime).IsOptional();
            this.Property(e => e.IsManualEntry).IsRequired();
            this.Property(e => e.ManualEntryStart).IsOptional();
            this.Property(e => e.ManualEntryEnd).IsOptional();

            this.HasRequired(e => e.TimeReporting)
                .WithMany(e => e.Projects)
                .HasForeignKey(e => e.TimeReportingId)
                .WillCascadeOnDelete(false);

            this.HasRequired(e => e.Afe)
                .WithMany(e => e.Projects)
                .HasForeignKey(e => e.AfeId)
                .WillCascadeOnDelete(false);

            this.ToTable("Projects");
        }
    }
}