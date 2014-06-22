using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EssentialTools.Models;
using Ninject;

namespace EssentialTools.Infrastructure
{
    public class NinjectDependencyResolver: IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver()
        {
            kernel = new StandardKernel();
            AddBindings();
        }

        private void AddBindings()
        {
            kernel.Bind<IValueConverter>().To<LinqValueCalculator>();
            kernel.Bind<IDiscountHelper>().To<DefaultDiscountHelper>().WithPropertyValue("DiscountSize",25M);
            kernel.Bind<IDiscountHelper>().To<FlexibleDiscountHelper>().WhenInjectedInto<LinqValueCalculator>();
        }
        public object GetService(Type serviceType)
        {
            //throw new NotImplementedException();
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            //throw new NotImplementedException();
            return kernel.GetAll(serviceType);
        }
    }
}