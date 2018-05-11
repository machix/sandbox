namespace QuartzEnergy.FracSchedule.Web.Infrastructure
{
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

    using QuartzEnergy.Common.Web.Infrastructure;

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

            services.AddScoped<IVegaSessionFactory, VegaSessionFactory>(p => new VegaSessionFactory(connectionString));
            services.AddUowMapperService<IVehiclesService, VehiclesService, IVegaSessionFactory>();
            services.AddUowService<IMakersListService, MakersListService, IVegaSessionFactory>();
            services.AddUowService<IModelsListService, ModelsListService, IVegaSessionFactory>();
            services.AddUowService<IFeaturesListService, FeaturesListService, IVegaSessionFactory>();
            services.AddUowService<IOwnersListService, OwnersListService, IVegaSessionFactory>();
            services.AddUowService<IVehiclesStatisticsService, VehiclesStatisticsService, IVegaSessionFactory>();

            return services;
        }
    }
}
