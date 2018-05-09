namespace QuartzEnergy.FracSchedule.Web.Resources.Vehicles.Statistics
{
    using QuartzEnergy.Common.Web.Resources.Statistics;

    public sealed class VehiclesByMakerItemResource : StatisticsItemResource<VehiclesByMakerDataResource>
    {
        public VehiclesByMakerItemResource(string label, VehiclesByMakerDataResource DataResource)
            : base(label, DataResource)
        {
        }
    }
}
