namespace QuartzEnergy.FracSchedule.Services.FracSchedule.Models.Schedules.Entity
{
    using System;

    using QuartzEnergy.Common.DataAnnotations.Attributes.Data;
    using QuartzEnergy.Common.Services.Models.Business;

    public sealed class Schedule : IntIdBusinessModel
    {
        public Schedule(
            int id,
            int wellId, 
            int companyId, 
            DateTime fracStartDate, 
            DateTime fracEndDate, 
            DateTime createdDate)
            : base(id)
        {
            this.WellId = wellId;
            this.CompanyId = companyId;
            this.FracStartDate = fracStartDate;
            this.FracEndDate = fracEndDate;
            this.CreatedDate = createdDate;
        }

        [IntId]
        public int WellId { get; }

        [IntId]
        public int CompanyId { get; }

        public DateTime FracStartDate { get; }

        public DateTime FracEndDate { get; }

        public DateTime CreatedDate { get; }
    }
}