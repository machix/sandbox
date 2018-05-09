namespace QuartzEnergy.FracSchedule.Web.Controllers.Features
{
    using AutoMapper;

    using QuartzEnergy.Common.Web.Constants;
    using QuartzEnergy.Common.Web.Controllers.Lists;
    using QuartzEnergy.FracSchedule.Services.Vega.Services.Features;

    using Microsoft.AspNetCore.Mvc;

    [Route(Routes.ApiRoute + "features/list")]
    public sealed class FeaturesListController
        : NoRequestListApiController<IFeaturesListService>
    {
        public FeaturesListController(IFeaturesListService service, IMapper mapper)
            : base(service, mapper)
        {
        }
    }
}
