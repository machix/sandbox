namespace QuartzEnergy.FracSchedule.Domain.Entities
{
    using System.Collections.Generic;

    using QuartzEnergy.Common.Domain.Entities;
    using QuartzEnergy.Common.Domain.Interfaces;

    public class OwnerEntity : IntIdEntity, INamedPerson
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public virtual ICollection<VehicleEntity> Vehicles { get; set; }
    }
}
