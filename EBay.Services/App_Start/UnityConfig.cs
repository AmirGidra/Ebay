using Ebay.BLL;
using Ebay.DAL;
using System.Web.Http;
using Unity;
using Unity.WebApi;
using System.Data.Entity;
using Ebay.DAL.Interfaces;
using Ebay.DAL.Implementation;
using Entity;

namespace EBay.Services
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IProductBLL, ProductBLL>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType(typeof(IRepository<>), typeof(Repository<>));
            container.RegisterType<ICategoryRepository, CategoryRepository>();
            container.RegisterType<IUserTableRepository, UserTableRepository>();
            container.RegisterType<DbContext, APLabDBEntities>();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

       
    }

   
}