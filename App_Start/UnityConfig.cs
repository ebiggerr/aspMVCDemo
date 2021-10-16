using System.Web.Mvc;
using aspMVCDemo.Controllers.Accounts;
using aspMVCDemo.Manager;
using Unity;
using Unity.Mvc5;

namespace aspMVCDemo
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IAccountManager, AccountManager>();
            container.RegisterType<IAccountController, AccountController>("Account");
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}