namespace QuartzEnergy.Common.Web.Controllers.Common
{
    using QuartzEnergy.Common.Web.Constants;

    using Microsoft.AspNetCore.Mvc;

    [Route(Routes.ApiRoute + "[controller]")]
    public abstract class ApiController : Controller
    {        
    }
}
