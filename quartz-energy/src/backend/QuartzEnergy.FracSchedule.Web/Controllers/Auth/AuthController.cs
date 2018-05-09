namespace QuartzEnergy.FracSchedule.Web.Controllers.Auth
{
    using AutoMapper;

    using QuartzEnergy.Common.Auth.Services;

    public sealed class AuthController : QuartzEnergy.Common.Auth.Controllers.AuthController
    {
        public AuthController(IAuthService authService, IMapper mapper)
            : base(authService, mapper)
        {
        }
    }
}
