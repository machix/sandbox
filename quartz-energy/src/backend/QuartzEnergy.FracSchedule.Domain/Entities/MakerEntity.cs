namespace QuartzEnergy.FracSchedule.Domain.Entities
{
    using System.Collections.Generic;

    using QuartzEnergy.Common.Domain.Entities;
    using QuartzEnergy.Common.Domain.Interfaces;

    public class MakerEntity : IntIdEntity, INamedEntity
    {
        public string Name { get; set; }

        public virtual ICollection<ModelEntity> Models { get; set; }
    }
}
