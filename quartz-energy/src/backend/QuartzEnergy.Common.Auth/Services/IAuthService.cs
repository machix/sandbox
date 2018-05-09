namespace QuartzEnergy.Common.Auth.Services
{
    using System.Threading.Tasks;

    using QuartzEnergy.Common.Auth.Models;

    public interface IAuthService
    {
        Task<RegisterResult> Register(Register register);

        Task<LoginResult> Login(Login login);
    }
}
