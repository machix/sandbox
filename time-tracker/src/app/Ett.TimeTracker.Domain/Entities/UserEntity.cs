namespace Ett.TimeTracker.Domain.Entities
{
    using System;
    using System.Collections.Generic;

    using Ett.Common.Domain.Entities;
    using Ett.Common.Domain.Interfaces;

    public class UserEntity : IntIdEntity, INamedEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime? LastLoginDate { get; set; }

        public virtual ICollection<UserPhotoEntity> Photos { get; set; }

        public virtual ICollection<UserSettingsEntity> Settings { get; set; }
    }
}