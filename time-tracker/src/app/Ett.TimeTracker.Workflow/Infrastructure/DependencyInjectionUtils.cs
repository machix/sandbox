namespace Ett.TimeTracker.Workflow.Infrastructure
{
    using System.Collections.Generic;

    using AutoMapper;

    using Ett.Common.IoC.Ninject.IoC;
    using Ett.Common.IoC.Ninject.Modules;
    using Ett.TimeTracker.Services.TimeTracker.Infrastructure;

    using Ninject;

    internal static class DependencyInjectionUtils
    {
        internal static void Initialize(params Profile[] profiles)
        {
            var profilesList = new List<Profile>
            {
                new TimeTrackerProfile(),
                new TimeTrackerResourcesProfile()
            };
            profilesList.AddRange(profiles);

            var kernel = new StandardKernel(
                new WorkflowNinjectModule(),
                new AutoMapperModule(profilesList.ToArray()));

            ManualDependencyResolver.SetKernel(kernel);
        }
    }
}