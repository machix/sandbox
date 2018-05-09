namespace QuartzEnergy.FracSchedule.Web.Resources.Vehicles.Statistics
{
    using System.Collections.Generic;

    using QuartzEnergy.Common.Web.Resources.Statistics;

    public sealed class VehiclesByMakerStatisticsResource
        : NoRequestStatisticsResource<VehiclesByMakerDataResource>
    {
        public VehiclesByMakerStatisticsResource()
        {            
        }

        public VehiclesByMakerStatisticsResource(
            IEnumerable<StatisticsItemResource<VehiclesByMakerDataResource>> items)
            : base(items)
        {
        }
    }
}
