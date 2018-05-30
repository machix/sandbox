namespace Ett.TimeTracker.Dal.Infrastructure
{
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using Ett.Common.Dal.Infrastructure.Concrete;
    using Ett.TimeTracker.Dal.EntityConfigurations;
    using Ett.TimeTracker.Domain.Entities;

    public class TimeTrackerDbContext : DatabaseContext
    {
        public TimeTrackerDbContext()
        {
        }

        public TimeTrackerDbContext(DbConnection connection)
            : base(connection)
        {
        }

        public DbSet<AfeEntity> Afes { get; set; }

        public DbSet<ProjectEntity> Projects { get; set; }

        public DbSet<TimeReportingEntity> TimeReportings { get; set; }

        public DbSet<UserEntity> Users { get; set; }

        public DbSet<UserPhotoEntity> UserPhotos { get; set; }

        public DbSet<UserSettingsEntity> UserSettings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
#pragma warning disable 618
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
#pragma warning restore 618

            modelBuilder.Configurations.Add(new AfeConfiguration());
            modelBuilder.Configurations.Add(new ProjectConfiguration());
            modelBuilder.Configurations.Add(new TimeReportingConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new UserPhotoConfiguration());
            modelBuilder.Configurations.Add(new UserSettingsConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}