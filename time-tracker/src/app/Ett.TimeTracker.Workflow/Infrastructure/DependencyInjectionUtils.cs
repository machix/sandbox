namespace Ett.TimeTracker.Workflow.Infrastructure
{
    using Ett.Common.IoC.Ninject.IoC;
    using Ett.Common.IoC.Ninject.Modules;
    using Ett.TimeTracker.Services.TimeTracker.Infrastructure;

    using Ninject;

    internal static class DependencyInjectionUtils
    {
        internal static void Initialize()
        {
            var kernel = new StandardKernel(
                new WorkflowNinjectModule(),
                new AutoMapperModule(
                    new TimeTrackerProfile(),
                    new TimeTrackerResourcesProfile()));
            ManualDependencyResolver.SetKernel(kernel);
        }
    }
}