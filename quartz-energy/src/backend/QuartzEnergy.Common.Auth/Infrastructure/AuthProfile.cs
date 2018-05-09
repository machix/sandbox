namespace QuartzEnergy.Common.Auth.Infrastructure
{
    using AutoMapper;

    using QuartzEnergy.Common.Auth.Models;
    using QuartzEnergy.Common.Auth.Resources;
    using QuartzEnergy.Common.Auth.Utils;

    using Microsoft.AspNetCore.Identity;

    public class AuthProfile : Profile
    {
        public AuthProfile()
        {
            this.CreateMap<RegisterResource, Register>()
                .ConstructUsing(
                    r => new Register(
                        r.UserName,
                        r.Email,
                        r.Password));

            this.CreateMap<LoginResource, Login>()
                .ConstructUsing(
                    r => new Login(
                        r.UserName,
                        r.Password));

            this.CreateMap<RegisterResult, RegisterResultResource>();

            this.CreateMap<LoginResult, LoginResultResource>();

            this.CreateMap<LoggedInUser, LoggedInUserResource>();

            this.CreateMap<IdentityUser, LoggedInUser>()
                .ConstructUsing(
                    i => new LoggedInUser(
                        i.UserName,
                        i.Email,
                        CryptoUtils.CreateToken(i)));
        }
    }
}
