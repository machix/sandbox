namespace QuartzEnergy.FracSchedule.Dal.FracSchedule.EntityConfigurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using QuartzEnergy.FracSchedule.Domain.FracSchedule.Entities;

    internal sealed class RegionConfiguration : IEntityTypeConfiguration<RegionEntity>
    {
        public void Configure(EntityTypeBuilder<RegionEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name).HasMaxLength(50).IsRequired();

            builder.ToTable("Regions");
        }
    }
}