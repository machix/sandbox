namespace QuartzEnergy.FracSchedule.Web.FracSchedule.Controllers.Regions
{
    using AutoMapper;

    using Microsoft.AspNetCore.Mvc;

    using QuartzEnergy.Common.Web.Constants;
    using QuartzEnergy.Common.Web.Controllers.Lists;
    using QuartzEnergy.FracSchedule.Services.FracSchedule.Services.Regions;

    [Route(Routes.ApiRoute + "regions/list")]
    public sealed class RegionsListController
        : NoRequestListApiController<IRegionsListService>
    {
        public RegionsListController(IRegionsListService service, IMapper mapper)
            : base(service, mapper)
        {
        }
    }
}