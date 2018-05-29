namespace Ett.Common.Web.Controllers.Common
{
    using Ett.Common.Web.Constants;

    using System.Web.Mvc;

    [Route(Routes.ApiRoute + "[controller]")]
    public abstract class ApiController : System.Web.Http.ApiController
    {        
    }
}
