namespace QuartzEnergy.FracSchedule.Services.FracSchedule.Models.Schedules.Overviews
{
    using System.Collections.Generic;

    using QuartzEnergy.Common.DataAnnotations.Attributes.Data;
    using QuartzEnergy.Common.Services.Models.Overviews;
    public sealed class ScheduleOverviewsRequest : OverviewsRequestModel
    {
        public ScheduleOverviewsRequest(
            IEnumerable<int> regions, 
            IEnumerable<int> operators, 
            int? startNextDays,
            string sortBy,
            bool desc,
            int? pageSize,
            int? pageNumber)
            : base(sortBy, desc, pageSize, pageNumber)
        {
            this.Regions = regions;
            this.Operators = operators;
            this.StartNextDays = startNextDays;
        }

        [IntIds]
        public IEnumerable<int> Regions { get; }

        [IntIds]
        public IEnumerable<int> Operators { get; }

        public int? StartNextDays { get; }
    }
}