namespace QuartzEnergy.FracSchedule.Domain.FracSchedule.Entities
{
    using System.Collections.Generic;

    using QuartzEnergy.Common.Domain.Entities;
    using QuartzEnergy.Common.Domain.Interfaces;

    public class ContactEntity : IntIdEntity, INamedEntity
    {
        public int CompanyId { get; set; }

        public int ContactOrder { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string City { get; set; }

        public int StateId { get; set; }

        public virtual CompanyEntity Company { get; set; }

        public virtual StateEntity State { get; set; }

        public virtual ICollection<ContactPhotoEntity> Photos { get; set; }
    }
}