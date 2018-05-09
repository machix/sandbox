namespace QuartzEnergy.FracSchedule.Domain.FracSchedule.Entities
{
    using System;

    using QuartzEnergy.Common.Domain.Entities;

    public class ScheduleEntity : IntIdEntity
    {
        public int WellId { get; set; }

        public int CompanyId { get; set; }

        public DateTime FracStartDate { get; set; }

        public DateTime FracEndDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual WellEntity Well { get; set; }

        public virtual CompanyEntity Company { get; set; }
    }
}