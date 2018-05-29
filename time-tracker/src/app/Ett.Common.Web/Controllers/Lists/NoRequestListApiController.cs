namespace Ett.Common.Web.Controllers.Lists
{
    using AutoMapper;

    using Ett.Common.Services.Models.Lists;
    using Ett.Common.Services.Services.Lists.Interfaces;
    using Ett.Common.Web.Resources.Lists;

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
