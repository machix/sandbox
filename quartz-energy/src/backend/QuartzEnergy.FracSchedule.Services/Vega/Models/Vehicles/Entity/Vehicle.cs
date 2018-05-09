namespace QuartzEnergy.FracSchedule.Services.Vega.Models.Vehicles.Entity
{
    using System.Collections.Generic;

    using QuartzEnergy.Common.DataAnnotations.Attributes.Data;
    using QuartzEnergy.Common.Services.Models.Business;

    public sealed class Vehicle : IntIdBusinessModel
    {
        public Vehicle(
            int id, 
            int makerId,    
            int modelId, 
            int ownerId, 
            bool isRegistered,
            string description,
            IEnumerable<VehiclePhoto> photos)
            : base(id)
        {
            this.MakerId = makerId;
            this.ModelId = modelId;
            this.OwnerId = ownerId;
            this.IsRegistered = isRegistered;
            this.Description = description;
            this.Photos = photos;            
        }

        [IntId]
        public int MakerId { get; }

        [IntId]
        public int ModelId { get; }

        [IntId]
        public int OwnerId { get; }

        public bool IsRegistered { get; }

        public string Description { get; }

        public IEnumerable<VehiclePhoto> Photos { get; }
    }
}
