namespace Ett.TimeTracker.Workflow.Infrastructure
{
    using Ett.Common.IoC.Ninject.IoC;

    using Ninject;

    internal static class DependencyInjectionUtils
    {
        internal static void Initialize()
        {
            var kernel = new StandardKernel(new WorkflowNinjectModule());
            ManualDependencyResolver.SetKernel(kernel);
        }
    }
}