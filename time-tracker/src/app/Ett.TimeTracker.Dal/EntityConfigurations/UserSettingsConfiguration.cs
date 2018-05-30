namespace Ett.TimeTracker.Dal.EntityConfigurations
{
    using System.Data.Entity.ModelConfiguration;

    using Ett.TimeTracker.Domain.Entities;

    internal sealed class UserSettingsConfiguration : EntityTypeConfiguration<UserSettingsEntity>
    {
        internal UserSettingsConfiguration()
        {
            this.HasKey(e => e.Id);

            this.Property(e => e.UserId).IsRequired();
            this.Property(e => e.CostCenterId).IsOptional().HasMaxLength(20);
            this.Property(e => e.DateFormat).IsRequired().HasMaxLength(20);
            this.Property(e => e.Is12HourFormat).IsRequired();
            this.Property(e => e.MaximumWorkingHours).IsOptional();
            this.Property(e => e.LoggingReminder).IsRequired();
            this.Property(e => e.MaxWorkingTimeReminder).IsRequired();
            this.Property(e => e.IdleReminder).IsRequired();
            this.Property(e => e.IdleTime).IsOptional();
            this.Property(e => e.ReminderTime).IsOptional();
            this.Property(e => e.MonReminder).IsRequired();
            this.Property(e => e.TuesReminder).IsRequired();
            this.Property(e => e.WedReminder).IsRequired();
            this.Property(e => e.ThursReminder).IsRequired();
            this.Property(e => e.FriReminder).IsRequired();
            this.Property(e => e.SatReminder).IsRequired();
            this.Property(e => e.SunReminder).IsRequired();
            this.Property(e => e.EmailTimeEntryUpdates).IsRequired();
            this.Property(e => e.EmailWeeklyReports).IsRequired();

            this.HasRequired(e => e.User)
                .WithMany(e => e.Settings)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            this.ToTable("UserSettings");
        }
    }
}