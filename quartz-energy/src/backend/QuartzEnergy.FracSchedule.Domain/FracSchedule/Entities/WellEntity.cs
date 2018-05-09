namespace QuartzEnergy.FracSchedule.Domain.FracSchedule.Entities
{
    using System.Collections.Generic;

    using QuartzEnergy.Common.Domain.Entities;
    using QuartzEnergy.Common.Domain.Interfaces;

    public class WellEntity : IntIdEntity, INamedEntity
    {
        public string Name { get; set; }

        public float SurfaceLat { get; set; }

        public float SurfaceLong { get; set; }

        public float BottomholeLat { get; set; }

        public float BottomholeLong { get; set; }

        public string Tvd { get; set; }

        public string Api { get; set; }

        public int RegionId { get; set; }

        public virtual RegionEntity Region { get; set; }

        public virtual ICollection<ScheduleEntity> Schedules { get; set; }
    }
}