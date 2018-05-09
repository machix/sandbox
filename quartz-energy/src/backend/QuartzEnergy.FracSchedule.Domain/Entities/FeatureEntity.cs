namespace QuartzEnergy.FracSchedule.Domain.Entities
{
    using System.Collections.Generic;

    using QuartzEnergy.Common.Domain.Entities;
    using QuartzEnergy.Common.Domain.Interfaces;

    public class FeatureEntity : IntIdEntity, INamedEntity
    {
        public string Name { get; set; }

        public virtual ICollection<ModelFeatureEntity> ModelFeatures { get; set; }
    }
}
