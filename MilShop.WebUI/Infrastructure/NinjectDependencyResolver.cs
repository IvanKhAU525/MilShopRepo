using MilShop.Domain.Abstract;
using MilShop.Domain.Entities;
using Moq;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MilShop.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {

        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            Mock<IShopRepository> mock = new Mock<IShopRepository>();
            mock.Setup(m => m.Goods).Returns(new List<Commodity>
            {
                new Commodity   {   Name = "Береты", Price = 120    },
                new Commodity   {   Name = "Берцы", Price = 300     },
                new Commodity   {   Name = "Фуфайка", Price = 500   }
            });
            kernel.Bind<IShopRepository>().ToConstant(mock.Object);
        }
    }
}