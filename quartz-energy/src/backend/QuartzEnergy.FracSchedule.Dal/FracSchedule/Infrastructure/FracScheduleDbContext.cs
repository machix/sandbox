namespace QuartzEnergy.FracSchedule.Dal.FracSchedule.Infrastructure
{
    using Microsoft.EntityFrameworkCore;

    using QuartzEnergy.Common.Dal.Infrastructure.Concrete;
    using QuartzEnergy.FracSchedule.Dal.FracSchedule.EntityConfigurations;
    using QuartzEnergy.FracSchedule.Domain.FracSchedule.Entities;

    public class FracScheduleDbContext : DatabaseContext
    {
        public FracScheduleDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public FracScheduleDbContext(DbContextOptions options)
            : base(options)
        {            
        }

        public FracScheduleDbContext(DbContextOptions<FracScheduleDbContext> options)
            : base(options)
        {            
        }

        public DbSet<RegionEntity> Regions { get; set; }   

        public DbSet<StateEntity> States { get; set; }   

        public DbSet<CompanyEntity> Companies { get; set; }   

        public DbSet<ContactEntity> Contacts { get; set; }   

        public DbSet<ContactPhotoEntity> ContactPhotos { get; set; }   

        public DbSet<WellEntity> Wells { get; set; }   

        public DbSet<ScheduleEntity> Schedules { get; set; }   


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RegionConfiguration());
            modelBuilder.ApplyConfiguration(new StateConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new ContactPhotoConfiguration());
            modelBuilder.ApplyConfiguration(new WellConfiguration());
            modelBuilder.ApplyConfiguration(new ScheduleConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
