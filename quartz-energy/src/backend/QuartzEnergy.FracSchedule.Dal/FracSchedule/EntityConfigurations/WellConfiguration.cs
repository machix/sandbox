namespace QuartzEnergy.FracSchedule.Dal.FracSchedule.EntityConfigurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using QuartzEnergy.FracSchedule.Domain.FracSchedule.Entities;

    internal sealed class WellConfiguration : IEntityTypeConfiguration<WellEntity>
    {
        public void Configure(EntityTypeBuilder<WellEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name).HasMaxLength(50).IsRequired();
            builder.Property(e => e.SurfaceLat).IsRequired();
            builder.Property(e => e.SurfaceLong).IsRequired();
            builder.Property(e => e.BottomholeLat).IsRequired();
            builder.Property(e => e.BottomholeLong).IsRequired();
            builder.Property(e => e.Tvd).HasMaxLength(255).IsRequired(false);
            builder.Property(e => e.Api).HasMaxLength(20).IsRequired();
            builder.Property(e => e.RegionId).IsRequired();

            builder.HasOne(e => e.Region)
                .WithMany(e => e.Wells)
                .HasForeignKey(e => e.RegionId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Wells");
        }
    }
}