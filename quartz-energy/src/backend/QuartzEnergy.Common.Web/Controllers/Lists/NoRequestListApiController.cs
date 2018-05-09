namespace QuartzEnergy.Common.Web.Controllers.Lists
{
    using AutoMapper;

    using QuartzEnergy.Common.Services.Models.Lists;
    using QuartzEnergy.Common.Services.Services.Lists.Interfaces;
    using QuartzEnergy.Common.Web.Resources.Lists;

    public abstract class NoRequestListApiController<TService>
        : ModelsListApiController<TService, EmptyListRequest, EmptyListRequestResource>
        where TService : INoRequestListService
    {
        protected NoRequestListApiController(TService service, IMapper mapper)
            : base(service, mapper)
        {
        }
    }
}
