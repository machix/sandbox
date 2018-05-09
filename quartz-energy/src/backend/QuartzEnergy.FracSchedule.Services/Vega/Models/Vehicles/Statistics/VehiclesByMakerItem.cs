namespace QuartzEnergy.FracSchedule.Services.Vega.Models.Vehicles.Statistics
{
    using QuartzEnergy.Common.Services.Models.Statistics;
    public sealed class VehiclesByMakerItem : StatisticsItem<VehiclesByMakerData>
    {
        public VehiclesByMakerItem(string label, VehiclesByMakerData data)
            : base(label, data)
        {
        }
    }
}
