namespace Ett.Common.IoC.Ninject.IoC
{
    using System;
    using System.Web;
    using System.Web.Http;

    using global::Ninject;
    using global::Ninject.Modules;
    using global::Ninject.Web.Common;

    using Microsoft.Practices.ServiceLocation;

    public static class NinjectWebCommonUtils
    {
        /// <summary>
        ///     Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        public static IKernel CreateKernel(params INinjectModule[] modules)
        {
            var kernel = new StandardKernel(modules);
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                ManualDependencyResolver.SetKernel(kernel); // Manual
                // ReSharper disable once AccessToDisposedClosure
                ServiceLocator.SetLocatorProvider(() => new NinjectServiceLocator(kernel)); // Log4Net
                GlobalConfiguration.Configuration.DependencyResolver =
                    new global::Ninject.Web.WebApi.NinjectDependencyResolver(kernel); // Web API

                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }
    }
}