namespace Ett.TimeTracker.Domain.Entities
{
    using System.Collections.Generic;

    using Ett.Common.Domain.Entities;
    using Ett.Common.Domain.Interfaces;

    public class AfeEntity : IntIdEntity, INamedEntity
    {
        public string Name { get; set; }

        public virtual ICollection<ProjectEntity> Projects { get; set; }
    }
}