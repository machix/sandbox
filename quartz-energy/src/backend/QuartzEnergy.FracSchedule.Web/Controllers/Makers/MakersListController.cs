namespace QuartzEnergy.FracSchedule.Web.Controllers.Makers
{
    using AutoMapper;

    using QuartzEnergy.Common.Web.Constants;
    using QuartzEnergy.Common.Web.Controllers.Lists;
    using QuartzEnergy.FracSchedule.Services.Vega.Services.Makers;

    using Microsoft.AspNetCore.Mvc;

    [Route(Routes.ApiRoute + "makers/list")]
    public sealed class MakersListController
        : NoRequestListApiController<IMakersListService>
    {
        public MakersListController(IMakersListService service, IMapper mapper)
            : base(service, mapper)
        {
        }
    }
}
