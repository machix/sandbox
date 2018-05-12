using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace QuartzEnergy.FracSchedule.Web
{
    using System.IO;
    using System.Reflection;

    using AutoMapper;

    using QuartzEnergy.Common.Auth.Extensions;
    using QuartzEnergy.Common.Files.Extensions;
    using QuartzEnergy.Common.Web.Infrastructure;
    using QuartzEnergy.FracSchedule.Dal.FracSchedule.Infrastructure;
    using QuartzEnergy.FracSchedule.Dal.Infrastructure;
    using QuartzEnergy.FracSchedule.Web.Configuration;
    using QuartzEnergy.FracSchedule.Web.FracSchedule.Infrastructure;
    using QuartzEnergy.FracSchedule.Web.Infrastructure;

    public class Startup
    {
        private readonly IConfiguration configuration;
        private readonly AppConfiguration appConfiguration;
        private readonly IHostingEnvironment environment;

        public Startup(
            IConfiguration configuration, 
            IHostingEnvironment environment)
        {
            this.configuration = configuration;
            this.environment = environment;
            this.appConfiguration = configuration.GetSection("App").Get<AppConfiguration>();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var vegaConnectionString = this.configuration.GetConnectionString("Vega");
            var fracScheduleConnectionString = this.configuration.GetConnectionString("FracSchedule");
            var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            var uploadFolder = Path.Combine(this.environment.ContentRootPath, this.appConfiguration.UploadFolder);

            services
                .AddAuth(fracScheduleConnectionString, assemblyName)
                .AddAutoMapper()
                .AddEntityFramework<VegaSqlServerDbContext>(vegaConnectionString)
                .AddEntityFramework<FracScheduleSqlServerDbContext>(fracScheduleConnectionString)
                .AddVegaServices(vegaConnectionString)
                .AddFracScheduleServices(fracScheduleConnectionString)
                .AddMvcWithModelValidation(out IMvcBuilder mvc)
                .AddCorsEnable()
                .AddSwagger()
                .AddFiles(uploadFolder);

            mvc
                .AddAuth()
                .UseCamelCaseJson();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app
               .UseAuth()
               .UseCorsEnable()
               .UseStaticFiles()
               .UseMvcWithDefaultRoute()
               .UseSwaggerPage();
        }
    }
}
