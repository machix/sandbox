namespace Ett.TimeTracker.Dal.EntityConfigurations
{
    using System.Data.Entity.ModelConfiguration;

    using Ett.TimeTracker.Domain.Entities;

    internal sealed class UserConfiguration : EntityTypeConfiguration<UserEntity>
    {
        internal UserConfiguration()
        {
            this.HasKey(e => e.Id);

            this.Property(e => e.Name).IsRequired().HasMaxLength(20);
            this.Property(e => e.Email).IsRequired().HasMaxLength(256);
            this.Property(e => e.Password).IsRequired();
            this.Property(e => e.LastLoginDate).IsOptional();

            this.ToTable("Users");
        }
    }
}