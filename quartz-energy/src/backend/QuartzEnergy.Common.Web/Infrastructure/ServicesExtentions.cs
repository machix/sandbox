namespace QuartzEnergy.Common.Web.Infrastructure
{
    using System;

    using AutoMapper;

    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.Common.Dal.Infrastructure.Concrete;
    using QuartzEnergy.Common.Web.Mvc;
    using QuartzEnergy.Common.Web.Validation;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    using Swashbuckle.AspNetCore.Swagger;

    public static class ServicesExtentions
    {
        /// <summary>
        /// Entity Framework data access layer registration
        /// </summary>
        /// <typeparam name="TDbContext"></typeparam>
        /// <param name="services"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static IServiceCollection AddEntityFramework<TDbContext>(
            this IServiceCollection services,
            string connectionString) where TDbContext : DbContext
        {
            services
                .AddEntityFrameworkSqlServer()
                .AddDbContext<TDbContext>(options => 
                    options.UseSqlServer(connectionString, opt => opt.UseRowNumberForPaging()));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUnitOfWorkFactory, UnitOfWorkFactory>();

            return services;
        }

        public static IServiceCollection AddMvcWithModelValidation(
            this IServiceCollection services,
            out IMvcBuilder mvcBuilder)
        {
            mvcBuilder = services.AddMvc(
                config =>
                    {
                        config.ModelBinderProviders.Insert(0, new AppModelBinderProvider());
                        config.Filters.Add(typeof(ValidateModelFilter));
                        config.Filters.Add(typeof(ModelErrorsFilter));
                    });

            return services;
        }

        public static IServiceCollection AddCorsEnable(
            this IServiceCollection services)
        {
            services.AddCors(options =>
                {
                    options.AddPolicy(Constants.AllowCors,
                        builder => builder.AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod());
                });

            return services;
        }

        public static IServiceCollection AddSwagger(
            this IServiceCollection services)
        {
            services.AddSwaggerGen(s =>
                    {
                        s.SwaggerDoc("v1", new Info { Title = "API", Version = "v1" });
                    });
            
            return services;
        }

        public static IServiceCollection AddUowMapperService<TIService, TService, TISessionFactory>(
            this IServiceCollection services)
            where TIService : class 
            where TService : class, TIService
            where TISessionFactory: ISessionFactory
        {
            var serviceProvider = services.BuildServiceProvider();
            var uowf = new UnitOfWorkFactory(serviceProvider.GetService<TISessionFactory>());
            var mapper = serviceProvider.GetService<IMapper>();

            services.AddScoped<TIService, TService>(p => 
                (TService)Activator.CreateInstance(typeof(TService), uowf, mapper));

            return services;
        }

        public static IServiceCollection AddUowService<TIService, TService, TISessionFactory>(
            this IServiceCollection services)
            where TIService : class 
            where TService : class, TIService
            where TISessionFactory: ISessionFactory
        {
            var serviceProvider = services.BuildServiceProvider();
            var uowf = new UnitOfWorkFactory(serviceProvider.GetService<TISessionFactory>());

            services.AddScoped<TIService, TService>(p => 
                (TService)Activator.CreateInstance(typeof(TService), uowf));

            return services;
        }
    }
}
