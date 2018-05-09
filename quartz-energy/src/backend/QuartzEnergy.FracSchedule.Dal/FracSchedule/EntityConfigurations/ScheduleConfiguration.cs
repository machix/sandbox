namespace QuartzEnergy.FracSchedule.Dal.FracSchedule.EntityConfigurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using QuartzEnergy.FracSchedule.Domain.FracSchedule.Entities;

    internal sealed class ScheduleConfiguration : IEntityTypeConfiguration<ScheduleEntity>
    {
        public void Configure(EntityTypeBuilder<ScheduleEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.WellId).IsRequired();
            builder.Property(e => e.CompanyId).IsRequired();
            builder.Property(e => e.FracStartDate).IsRequired();
            builder.Property(e => e.FracEndDate).IsRequired();
            builder.Property(e => e.CreatedDate).IsRequired();

            builder.HasOne(e => e.Well)
                .WithMany(e => e.Schedules)
                .HasForeignKey(e => e.WellId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Company)
                .WithMany(e => e.Schedules)
                .HasForeignKey(e => e.CompanyId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Schedules");
        }
    }
}