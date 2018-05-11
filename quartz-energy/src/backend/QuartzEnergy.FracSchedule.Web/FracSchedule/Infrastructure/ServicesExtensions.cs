namespace QuartzEnergy.FracSchedule.Web.FracSchedule.Infrastructure
{
    using Microsoft.Extensions.DependencyInjection;

    using QuartzEnergy.Common.Web.Infrastructure;
    using QuartzEnergy.FracSchedule.Dal.FracSchedule.Infrastructure;
    using QuartzEnergy.FracSchedule.Services.FracSchedule.Services.Companies;
    using QuartzEnergy.FracSchedule.Services.FracSchedule.Services.Companies.Concrete;
    using QuartzEnergy.FracSchedule.Services.FracSchedule.Services.Regions;
    using QuartzEnergy.FracSchedule.Services.FracSchedule.Services.Regions.Concrete;
    using QuartzEnergy.FracSchedule.Services.FracSchedule.Services.Schedules;
    using QuartzEnergy.FracSchedule.Services.FracSchedule.Services.Schedules.Concrete;

    public static class ServicesExtensions
    {
        /// <summary>
        /// Application services registration
        /// </summary>
        /// <param name="services"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static IServiceCollection AddFracScheduleServices(
            this IServiceCollection services,
            string connectionString)
        {

            services.AddScoped<IFracScheduleSessionFactory, FracScheduleSessionFactory>(provider => new FracScheduleSessionFactory(connectionString));
            services.AddUowMapperService<ISchedulesService, SchedulesService, IFracScheduleSessionFactory>();
            services.AddUowService<IRegionsListService, RegionsListService, IFracScheduleSessionFactory>();
            services.AddUowService<ICompaniesListService, CompaniesListService, IFracScheduleSessionFactory>();

            return services;
        }
    }
}
