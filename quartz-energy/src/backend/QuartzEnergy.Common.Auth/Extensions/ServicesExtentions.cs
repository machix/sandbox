﻿namespace QuartzEnergy.Common.Auth.Extensions
{
    using QuartzEnergy.Common.Auth.Database;
    using QuartzEnergy.Common.Auth.Services;
    using QuartzEnergy.Common.Auth.Services.Concrete;
    using QuartzEnergy.Common.Auth.Utils;

    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.IdentityModel.Tokens;

    public static class ServicesExtentions
    {
        public static IServiceCollection AddAuth(
            this IServiceCollection services,
            string connectionString,
            string migrationsAssemblyName)
        {
            services.AddScoped<IAuthService, AuthService>();

            services
                .AddDbContext<AuthDbContext>(opt => opt.UseSqlServer(connectionString, optionsBuilder =>
                    optionsBuilder.MigrationsAssembly(migrationsAssemblyName)))
                .AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AuthDbContext>();

            services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(cfg =>
                {
                    cfg.RequireHttpsMetadata = false;
                    cfg.SaveToken = true;
                    cfg.TokenValidationParameters = new TokenValidationParameters
                                                    {
                                                        IssuerSigningKey = CryptoUtils.CreateSecurityKey(),
                                                        ValidateAudience = false,
                                                        ValidateIssuer = false,
                                                        ValidateLifetime = false,
                                                        ValidateIssuerSigningKey = true
                                                    };
                });

            return services;
        }
    }
}
