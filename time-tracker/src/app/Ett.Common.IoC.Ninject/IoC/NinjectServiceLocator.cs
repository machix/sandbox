namespace Ett.Common.IoC.Ninject.IoC
{
    using System;
    using System.Collections.Generic;

    using global::Ninject;

    using Microsoft.Practices.ServiceLocation;

    public class NinjectServiceLocator : ServiceLocatorImplBase
    {
        public NinjectServiceLocator(StandardKernel kernel)
        {
            this.Kernel = kernel;
        }

        public StandardKernel Kernel { get; }

        protected override object DoGetInstance(Type serviceType, string key)
        {
            if (key == null)
            {
                return this.Kernel.Get(serviceType);
            }

            return this.Kernel.Get(serviceType, key);
        }

        protected override IEnumerable<object> DoGetAllInstances(Type serviceType)
        {
            return this.Kernel.GetAll(serviceType);
        }
    }
}