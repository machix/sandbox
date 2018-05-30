namespace Ett.TimeTracker.Dal.EntityConfigurations
{
    using System.Data.Entity.ModelConfiguration;

    using Ett.TimeTracker.Domain.Entities;

    internal sealed class AfeConfiguration : EntityTypeConfiguration<AfeEntity>
    {
        internal AfeConfiguration()
        {
            this.HasKey(e => e.Id);

            this.Property(e => e.Name).IsRequired().HasMaxLength(20);

            this.ToTable("Afes");
        }
    }
}