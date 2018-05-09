﻿using Microsoft.AspNetCore.Builder;
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
    using QuartzEnergy.FracSchedule.Dal.Infrastructure;
    using QuartzEnergy.FracSchedule.Web.Configuration;
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
            var connectionString = this.configuration.GetConnectionString("Default");
            var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            var uploadFolder = Path.Combine(this.environment.ContentRootPath, this.appConfiguration.UploadFolder);

            services
                .AddAutoMapper()
                .AddEntityFramework<VegaSqlServerDbContext>(connectionString)
                .AddVegaServices(connectionString)
                .AddMvcWithModelValidation(out IMvcBuilder mvc)
                .AddCorsEnable()
                .AddSwagger()
                .AddAuth(connectionString, assemblyName)
                .AddFiles(uploadFolder);

            mvc.UseCamelCaseJson()
                .AddAuth();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCorsEnable()
               .UseStaticFiles()
               .UseMvcWithDefaultRoute()
               .UseSwaggerPage()
               .UseAuth();
        }
    }
}
