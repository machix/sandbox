namespace QuartzEnergy.FracSchedule.Services.Vega.Models.Models.Lists
{
    using System.Collections.Generic;

    using QuartzEnergy.Common.DataAnnotations.Attributes.Data;

    public sealed class ModelsListRequest
    {
        public ModelsListRequest(IEnumerable<int> makers)
        {
            this.Makers = makers;
        }

        [IntIds]
        public IEnumerable<int> Makers { get; }
    }
}
