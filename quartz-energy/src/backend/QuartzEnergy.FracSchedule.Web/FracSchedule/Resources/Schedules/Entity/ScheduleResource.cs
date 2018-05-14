namespace QuartzEnergy.FracSchedule.Web.FracSchedule.Resources.Schedules.Entity
{
    using System;

    using QuartzEnergy.Common.DataAnnotations.Attributes.Data;
    using QuartzEnergy.Common.Web.Resources.Business;

    public sealed class ScheduleResource : IntIdResource
    {
        public ScheduleResource()
        {            
        }

        public ScheduleResource(
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
        public int WellId { get; set; }

        [IntId]
        public int CompanyId { get; set; }

        public DateTime FracStartDate { get; set; }

        public DateTime FracEndDate { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}