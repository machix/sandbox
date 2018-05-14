namespace QuartzEnergy.FracSchedule.Web.FracSchedule.Resources.Schedules.Overviews
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using QuartzEnergy.Common.DataAnnotations.Attributes.Data;
    using QuartzEnergy.FracSchedule.Services.FracSchedule.Models.Schedules.Enums;

    public sealed class ScheduleOverviewResource
    {
        public ScheduleOverviewResource()
        {            
        }

        public ScheduleOverviewResource(
            int scheduleId, 
            string wellName,
            string @operator, 
            DateTime fracStartDate, 
            DateTime fracEndDate, 
            int duration, 
            string api, 
            double surfaceLat, 
            double surfaceLong, 
            double bottomholeLat, 
            double bottomholeLong, 
            string tvd, 
            int? startIn,
            ScheduleStatus status)
        {
            this.ScheduleId = scheduleId;
            this.WellName = wellName;
            this.Operator = @operator;
            this.FracStartDate = fracStartDate;
            this.FracEndDate = fracEndDate;
            this.Duration = duration;
            this.Api = api;
            this.SurfaceLat = surfaceLat;
            this.SurfaceLong = surfaceLong;
            this.BottomholeLat = bottomholeLat;
            this.BottomholeLong = bottomholeLong;
            this.Tvd = tvd;
            this.StartIn = startIn;
            this.Status = status;
        }

        [IntId]
        public int ScheduleId { get; set; }

        [Required]
        [MaxLength(50)]
        public string WellName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Operator { get; set; }

        public DateTime FracStartDate { get; set; }

        public DateTime FracEndDate { get; set; }

        public int Duration { get; set; }

        [Required]
        [MaxLength(20)]
        public string Api { get; set; }

        public double SurfaceLat { get; set; }

        public double SurfaceLong { get; set; }

        public double BottomholeLat { get; set; }

        public double BottomholeLong { get; set; }

        [Required]
        [MaxLength(255)]
        public string Tvd { get; set; }

        public int? StartIn { get; set; }

        public ScheduleStatus Status { get; set; }
    }
}