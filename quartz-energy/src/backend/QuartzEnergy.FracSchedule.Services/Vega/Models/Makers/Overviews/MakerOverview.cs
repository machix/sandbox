namespace QuartzEnergy.FracSchedule.Services.Vega.Models.Makers.Overviews
{
    using System.ComponentModel.DataAnnotations;

    using QuartzEnergy.Common.DataAnnotations.Attributes.Data;

    public sealed class MakerOverview
    {
        public MakerOverview(
            int makerId, 
            string name)
        {
            this.MakerId = makerId;
            this.Name = name;
        }

        [IntId]
        public int MakerId { get; }

        [Required]
        [MaxLength(50)]
        public string Name { get; }
    }
}
