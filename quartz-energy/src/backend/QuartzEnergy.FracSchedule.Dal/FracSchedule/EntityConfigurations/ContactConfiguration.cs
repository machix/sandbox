namespace QuartzEnergy.FracSchedule.Dal.FracSchedule.EntityConfigurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using QuartzEnergy.FracSchedule.Domain.FracSchedule.Entities;

    internal sealed class ContactConfiguration : IEntityTypeConfiguration<ContactEntity>
    {
        public void Configure(EntityTypeBuilder<ContactEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.CompanyId).IsRequired();
            builder.Property(e => e.ContactOrder).IsRequired();
            builder.Property(e => e.Name).HasMaxLength(50).IsRequired().HasColumnName("FullName");
            builder.Property(e => e.Email).HasMaxLength(255).IsRequired();
            builder.Property(e => e.Phone).HasMaxLength(30).IsRequired();
            builder.Property(e => e.City).HasMaxLength(50).IsRequired();
            builder.Property(e => e.StateId).IsRequired();

            builder.HasOne(e => e.Company)
                .WithMany(e => e.Contacts)
                .HasForeignKey(e => e.CompanyId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.State)
                .WithMany(e => e.Contacts)
                .HasForeignKey(e => e.StateId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Contacts");
        }
    }
}