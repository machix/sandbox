namespace Ett.TimeTracker.Dal.EntityConfigurations
{
    using System.Data.Entity.ModelConfiguration;

    using Ett.TimeTracker.Domain.Entities;

    internal sealed class UserPhotoConfiguration : EntityTypeConfiguration<UserPhotoEntity>
    {
        internal UserPhotoConfiguration()
        {
            this.HasKey(e => e.Id);

            this.Property(e => e.FileName).IsRequired().HasMaxLength(255);
            this.Property(e => e.MimeType).IsRequired().HasMaxLength(20);
            this.Property(e => e.UserId).IsRequired();

            this.HasRequired(e => e.User)
                .WithMany(e => e.Photos)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            this.ToTable("UserPhotos");
        }
    }
}