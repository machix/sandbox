namespace Ett.Common.IoC.Ninject.IoC
{
    using global::Ninject;
    using global::Ninject.Parameters;

    public sealed class ManualDependencyResolver
    {
        private static StandardKernel kernel;

        public static void SetKernel(StandardKernel krnl)
        {
            kernel = krnl;
        }

        public static TService Get<TService>()
        {
            return kernel.Get<TService>();
        }

        public static TService Get<TService>(params IParameter[] parameters)
        {
            return kernel.Get<TService>(parameters);
        }
    }
}