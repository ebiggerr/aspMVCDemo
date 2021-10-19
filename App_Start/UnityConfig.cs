using System.Web.Mvc;
using aspMVCDemo.Controllers.Accounts;
using aspMVCDemo.Controllers.Authentictation;
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
            
            container.RegisterType<ILoginController, LoginController>("Login");
            container.RegisterType<IRegisterController, RegisterController>("Register");
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}