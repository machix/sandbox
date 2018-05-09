namespace QuartzEnergy.FracSchedule.Services.Vega.Models.Vehicles.Overviews
{
    using System.Collections.Generic;

    using QuartzEnergy.Common.Services.Models.Overviews;

    public sealed class VehicleOverviews : OverviewsModel<VehicleOverviewsRequest, VehicleOverview>
    {
        public VehicleOverviews(
            VehicleOverviewsRequest request, 
            int recordsCount, 
            IEnumerable<VehicleOverview> overviews)
            : base(request, recordsCount, overviews)
        {
        }
    }
}
