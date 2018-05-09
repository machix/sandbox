using Microsoft.EntityFrameworkCore;

namespace QuartzEnergy.FracSchedule.Dal.EntityConfigurations
{
    using QuartzEnergy.FracSchedule.Domain.Entities;

    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal sealed class FeatureConfiguration : IEntityTypeConfiguration<FeatureEntity>
    {
        public void Configure(EntityTypeBuilder<FeatureEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name).HasMaxLength(50).IsRequired();

            builder.ToTable("Features");
        }
    }
}
