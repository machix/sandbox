﻿namespace QuartzEnergy.FracSchedule.Domain.Entities
{
    using QuartzEnergy.Common.Domain.Entities;

    public class PhotoEntity : GuidIdEntity
    {
        public string FileName { get; set; }

        public string OriginalFileName { get; set; }

        public string MimeType { get; set; }

        public int VehicleId { get; set; }

        public virtual VehicleEntity Vehicle { get; set; }
    }
}
