namespace QuartzEnergy.FracSchedule.Domain.FracSchedule.Entities
{
    using System.Collections.Generic;

    using QuartzEnergy.Common.Domain.Entities;
    using QuartzEnergy.Common.Domain.Interfaces;

    public class CompanyEntity : IntIdEntity, INamedEntity
    {
        public string Name { get; set; }

        public virtual ICollection<ContactEntity> Contacts { get; set; }

        public virtual ICollection<ScheduleEntity> Schedules { get; set; }
    }
}