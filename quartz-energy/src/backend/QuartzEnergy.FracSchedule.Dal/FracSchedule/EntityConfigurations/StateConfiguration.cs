namespace QuartzEnergy.FracSchedule.Dal.FracSchedule.EntityConfigurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using QuartzEnergy.FracSchedule.Domain.FracSchedule.Entities;

    internal sealed class StateConfiguration : IEntityTypeConfiguration<StateEntity>
    {
        public void Configure(EntityTypeBuilder<StateEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Code).HasMaxLength(2).IsRequired();
            builder.Property(e => e.Name).HasMaxLength(50).IsRequired();

            builder.ToTable("States");
        }
    }
}