using System.Web.Mvc;
using aspMVCDemo.Controllers.Accounts;
using aspMVCDemo.Manager;
using Unity;
using Unity.Mvc5;

namespace aspMVCDemo
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IAccountManager, AccountManager>();
            container.RegisterType<IAccountController, AccountController>("Account");        

            return container;
        }
    }
}