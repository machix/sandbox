namespace QuartzEnergy.FracSchedule.Dal.EntityConfigurations
{
    using QuartzEnergy.FracSchedule.Domain.Entities;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal sealed class MakerConfiguration : IEntityTypeConfiguration<MakerEntity>
    {
        public void Configure(EntityTypeBuilder<MakerEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name).HasMaxLength(50).IsRequired();

            builder.ToTable("Makers");
        }
    }
}
