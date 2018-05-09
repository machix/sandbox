namespace QuartzEnergy.FracSchedule.Web.Infrastructure
{
    using QuartzEnergy.Common.Dal.Infrastructure;
    using QuartzEnergy.FracSchedule.Dal.Infrastructure;
    using QuartzEnergy.FracSchedule.Services.Vega.Services.Features;
    using QuartzEnergy.FracSchedule.Services.Vega.Services.Features.Concrete;
    using QuartzEnergy.FracSchedule.Services.Vega.Services.Makers;
    using QuartzEnergy.FracSchedule.Services.Vega.Services.Makers.Concrete;
    using QuartzEnergy.FracSchedule.Services.Vega.Services.Models;
    using QuartzEnergy.FracSchedule.Services.Vega.Services.Models.Concrete;
    using QuartzEnergy.FracSchedule.Services.Vega.Services.Owners;
    using QuartzEnergy.FracSchedule.Services.Vega.Services.Owners.Concrete;
    using QuartzEnergy.FracSchedule.Services.Vega.Services.Vehicles;
    using QuartzEnergy.FracSchedule.Services.Vega.Services.Vehicles.Concrete;

    using Microsoft.Extensions.DependencyInjection;

    public static class ServicesExtensions
    {
        /// <summary>
        /// Application services registration
        /// </summary>
        /// <param name="services"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static IServiceCollection AddVegaServices(
            this IServiceCollection services,
            string connectionString)
        {

            services.AddScoped<ISessionFactory, VegaSessionFactory>(provider => new VegaSessionFactory(connectionString));
            services.AddScoped<IVehiclesService, VehiclesService>();
            services.AddScoped<IMakersListService, MakersListService>();
            services.AddScoped<IModelsListService, ModelsListService>();
            services.AddScoped<IFeaturesListService, FeaturesListService>();
            services.AddScoped<IOwnersListService, OwnersListService>();
            services.AddScoped<IVehiclesStatisticsService, VehiclesStatisticsService>();

            return services;
        }
    }
}
