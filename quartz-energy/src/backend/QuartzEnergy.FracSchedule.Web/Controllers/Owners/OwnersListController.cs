namespace QuartzEnergy.FracSchedule.Web.Controllers.Owners
{
    using AutoMapper;

    using QuartzEnergy.Common.Web.Constants;
    using QuartzEnergy.Common.Web.Controllers.Lists;
    using QuartzEnergy.FracSchedule.Services.Vega.Services.Owners;

    using Microsoft.AspNetCore.Mvc;

    [Route(Routes.ApiRoute + "owners/list")]
    public sealed class OwnersListController
        : NoRequestListApiController<IOwnersListService>
    {
        public OwnersListController(IOwnersListService service, IMapper mapper)
            : base(service, mapper)
        {
        }
    }
}
