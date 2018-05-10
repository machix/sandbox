namespace QuartzEnergy.FracSchedule.Web.FracSchedule.Controllers.Companies
{
    using AutoMapper;

    using QuartzEnergy.Common.Web.Constants;
    using QuartzEnergy.Common.Web.Controllers.Lists;
    
    using Microsoft.AspNetCore.Mvc;

    using QuartzEnergy.FracSchedule.Services.FracSchedule.Services.Companies;

    [Route(Routes.ApiRoute + "companies/list")]
    public sealed class CompaniesListController
        : NoRequestListApiController<ICompaniesListService>
    {
        public CompaniesListController(ICompaniesListService service, IMapper mapper)
            : base(service, mapper)
        {
        }
    }
}