namespace QuartzEnergy.FracSchedule.Domain.FracSchedule.Entities
{
    using System.Collections.Generic;

    using QuartzEnergy.Common.Domain.Entities;
    using QuartzEnergy.Common.Domain.Interfaces;

    public class StateEntity : IntIdEntity, INamedEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public virtual ICollection<ContactEntity> Contacts { get; set; }
    }
}