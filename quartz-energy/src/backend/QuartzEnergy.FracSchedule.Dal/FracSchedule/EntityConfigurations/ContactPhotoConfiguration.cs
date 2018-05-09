namespace QuartzEnergy.FracSchedule.Dal.FracSchedule.EntityConfigurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using QuartzEnergy.FracSchedule.Domain.FracSchedule.Entities;

    internal sealed class ContactPhotoConfiguration : IEntityTypeConfiguration<ContactPhotoEntity>
    {
        public void Configure(EntityTypeBuilder<ContactPhotoEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.FileName).HasMaxLength(255).IsRequired();
            builder.Property(e => e.MimeType).HasMaxLength(255).IsRequired();
            builder.Property(e => e.ContactId).IsRequired();

            builder.HasOne(e => e.Contact)
                .WithMany(e => e.Photos)
                .HasForeignKey(e => e.ContactId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("ContactPhotos");
        }
    }
}