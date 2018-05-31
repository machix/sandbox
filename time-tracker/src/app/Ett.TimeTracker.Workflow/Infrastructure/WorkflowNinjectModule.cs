namespace Ett.TimeTracker.Workflow.Infrastructure
{
    using AutoMapper;

    using Ett.Common.Dal.Infrastructure;
    using Ett.Common.Dal.Infrastructure.Concrete;
    using Ett.TimeTracker.Dal.Infrastructure;
    using Ett.TimeTracker.Services.TimeTracker.Infrastructure;
    using Ett.TimeTracker.Services.TimeTracker.Services.Projects;
    using Ett.TimeTracker.Services.TimeTracker.Services.Projects.Concrete;
    using Ett.TimeTracker.Workflow.Configuration;
    using Ett.TimeTracker.Workflow.Configuration.Concrete;

    using Ninject.Modules;
    using Ninject.Parameters;

    internal class WorkflowNinjectModule : NinjectModule
    {
        public override void Load()
        {
            // AutoMapper
            var config = new MapperConfiguration(
                c => {
                        c.AddProfile(new TimeTrackerProfile());
                    });
            var mapper = config.CreateMapper();
            this.Bind<IMapper>().ToConstant(mapper);

            // Configuration
            this.Bind<IWorkflowConfiguration>().To<WorkflowConfiguration>().InSingletonScope();

            // Entity Framework
            this.Bind<IUnitOfWork>().To<UnitOfWork>().InTransientScope();
            this.Bind<IUnitOfWorkFactory>().To<UnitOfWorkFactory>().InTransientScope();

//            var configuration = ManualDependencyResolver.Get<IWorkflowConfiguration>();
//            IParameter connString = new ConstructorArgument(
//                "defaultConnectionString", 
//                configuration.ConnectionString);
            this.Bind<ISessionFactory>().To<TimeTrackerSessionFactory>()
                .InTransientScope()
                .WithConstructorArgument("Data Source=(local);Initial Catalog=TimeTracker;User Id=TimeTracker;Password=DbPassword!234;MultipleActiveResultSets=True;persist security info=True;");
          

            // Services
            this.Bind<IProjectsService>().To<ProjectsService>().InTransientScope();
        }
    }
}