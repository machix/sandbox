namespace QuartzEnergy.FracSchedule.Web.FracSchedule.Resources.Schedules.Overviews
{
    using QuartzEnergy.Common.DataAnnotations.Attributes.Numbers;

    public sealed class ScheduleSummaryResource
    {
        public ScheduleSummaryResource()
        {            
        }

        public ScheduleSummaryResource(
            int operatingCount, 
            int next7DaysCount, 
            int next830DaysCount, 
            int next3160DaysCount, 
            int next60PlusDaysCount)
        {
            this.OperatingCount = operatingCount;
            this.Next7DaysCount = next7DaysCount;
            this.Next830DaysCount = next830DaysCount;
            this.Next3160DaysCount = next3160DaysCount;
            this.Next60PlusDaysCount = next60PlusDaysCount;
        }

        [MinIntValue(0)]
        public int OperatingCount { get; set; }

        [MinIntValue(0)]
        public int Next7DaysCount { get; set; }

        [MinIntValue(0)]
        public int Next830DaysCount { get; set; }

        [MinIntValue(0)]
        public int Next3160DaysCount { get; set; }

        [MinIntValue(0)]
        public int Next60PlusDaysCount { get; set; }
    }
}