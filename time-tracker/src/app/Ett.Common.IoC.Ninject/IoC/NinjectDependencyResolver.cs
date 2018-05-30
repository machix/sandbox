namespace Ett.Common.IoC.Ninject.IoC
{
    using System.Web.Http.Dependencies;

    using global::Ninject;

    using IDependencyResolver = System.Web.Mvc.IDependencyResolver;

    public sealed class NinjectDependencyResolver : NinjectDependencyScope, IDependencyResolver
    {
        private readonly IKernel kernel;

        public NinjectDependencyResolver(IKernel kernel)
            : base(kernel)
        {
            this.kernel = kernel;
        }

        public IDependencyScope BeginScope()
        {
            return new NinjectDependencyScope(this.kernel.BeginBlock());
        }
    }
}