namespace QuartzEnergy.FracSchedule.Domain.FracSchedule.Entities
{
    using System.Collections.Generic;

    using QuartzEnergy.Common.Domain.Entities;
    using QuartzEnergy.Common.Domain.Interfaces;

    public class RegionEntity : IntIdEntity, INamedEntity
    {
        public string Name { get; set; }

        public virtual ICollection<WellEntity> Wells { get; set; }
    }
}