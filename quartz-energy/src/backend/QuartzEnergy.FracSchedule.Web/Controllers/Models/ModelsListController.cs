namespace QuartzEnergy.FracSchedule.Web.Controllers.Models
{
    using AutoMapper;

    using QuartzEnergy.Common.Web.Constants;
    using QuartzEnergy.Common.Web.Controllers.Lists;
    using QuartzEnergy.FracSchedule.Services.Vega.Models.Models.Lists;
    using QuartzEnergy.FracSchedule.Services.Vega.Services.Models;
    using QuartzEnergy.FracSchedule.Web.Resources.Models.Lists;

    using Microsoft.AspNetCore.Mvc;

    [Route(Routes.ApiRoute + "models/list")]
    public sealed class ModelsListController
        : ModelsListApiController<
            IModelsListService,
            ModelsListRequest,
            ModelsListRequestResource>
    {
        public ModelsListController(IModelsListService service, IMapper mapper)
            : base(service, mapper)
        {
        }
    }
}
