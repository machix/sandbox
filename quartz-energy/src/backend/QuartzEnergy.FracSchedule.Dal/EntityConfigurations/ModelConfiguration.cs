namespace QuartzEnergy.FracSchedule.Dal.EntityConfigurations
{
    using QuartzEnergy.FracSchedule.Domain.Entities;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal sealed class ModelConfiguration : IEntityTypeConfiguration<ModelEntity>
    {
        public void Configure(EntityTypeBuilder<ModelEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name).HasMaxLength(50).IsRequired();
            builder.Property(e => e.MakerId).IsRequired();

            builder.HasOne(e => e.Maker)                
                .WithMany(e => e.Models)
                .HasForeignKey(e => e.MakerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Models");
        }
    }
}
