namespace QuartzEnergy.FracSchedule.Services.Vega.Models.Models.Entity
{
    using System.ComponentModel.DataAnnotations;

    using QuartzEnergy.Common.DataAnnotations.Attributes.Data;
    using QuartzEnergy.Common.Services.Models.Business;

    public sealed class Model: IntIdBusinessModel
    {
        public Model(
            int id, 
            string name, 
            int makerId)
            : base(id)
        {
            this.Name = name;
            this.MakerId = makerId;
        }

        [Required]
        [MaxLength(50)]
        public string Name { get; }

        [IntId]
        public int MakerId { get; }
    }
}
